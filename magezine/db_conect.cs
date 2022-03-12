using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magezine
{
    class db_conect
    {
        string connectionString ="server=localhost;port=3306;username=root;password=qwerty;database=corporehen2";
        static MySqlConnection msConnect;// обект для установки сойденения
        static MySqlCommand msCommand; //обект для выполнения запроса
        static  MySqlDataAdapter msDataAdapter;

        // соединение с бд
         public bool Connect()
        {
            try
            {
                //создание обеста соединения с заданной строкой подключения
                msConnect = new MySqlConnection(connectionString);
                //открытие подключение
                msConnect.Open();
                //Создание обекта запрос
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch (Exception ex) //возникновение ошибки
            {
                //вывод сообщения
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false;
            }

        }
        //отключение бд
         public void Close()
        {
            msConnect.Close();
        }






        //Аторицация пользователя, принимает параметры с формы автризации
        static public string User; //логин
        static public string Role; //пароль 
        static public string keyLog;//код пользователя
        public void Authorization(string login, string password)
        {
            try
            {
                string sql = @"select keyPosition from users where Login ='" + login + "' and Password = '" + password + "' and uwol = 0;";

                msCommand.CommandText = sql;

                //фиксируем результат запроса
                Object result = msCommand.ExecuteScalar();

                //если в результате запроса полученно недоступное значение
                if (result != null)
            {
                //заполняем информацию о авторизованном пользователе
                Role = Convert.ToString(result);
                User = login;
                    msCommand.CommandText = @"select keyUsers from users where Login ='" + login + "' and Password = '" + password + "';";
                    Object result1 = msCommand.ExecuteScalar();
                    keyLog = Convert.ToString(result);

                }
            else
            {
                //иначе тип  пользователя не авторизованный
                Role = null;
            }

            }
            catch (Exception ex) //при вознекновении ошибки
            {
                Role = User = null; //обнуляем значение полей
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        public bool dublirov(string selectText, string table, string poleWhere, string textwhere)
            
        {
            msCommand.CommandText = "select "+selectText+"  from "+table+" where "+poleWhere+" = "+textwhere+"";
            Object result1 = msCommand.ExecuteScalar();
            if (result1 == null)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        //get users
        public DataTable dtGetUsers = new DataTable();
        public void GetUsers ()
        {
            msCommand.CommandText = @"select users.patronymic,users.name, users.surname, position.Position, users.Login from users  JOIN position ON position.keyPosition=users.keyPosition where users.uwol=null or users.uwol=0";
            dtGetUsers.Clear();
            msDataAdapter.Fill(dtGetUsers);
        }

        //new user
        public void PersonalAdd(string surname,string name, string patronymic,string postion, string login, string passwd)
        {
            msCommand.CommandText = "insert  into users values (null, '"+surname+"','"+name+"','"+patronymic+"',"+postion+", '"+login+"','"+passwd+"', 0)";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись добавлена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }
        //update user
        public void PersonalUpdate(string Surname, string name, string patronymic, string dolzn, string login)
        {
            msCommand.CommandText = "update users set surname='"+Surname+ "',name='"+name+ "', patronymic='"+ patronymic + "', keyPosition='"+dolzn+ "' where login='"+login+"'";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись добавлена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }

        public void PersonalUpdate(string password, string login)
        {
            msCommand.CommandText = "update users set password = '"+password+"' where login='" + login + "'";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Пароль успешно изменен.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }

        public void PersonalDismissal(string login)
        {
            msCommand.CommandText = "update users set uwol = 1  where login='" + login + "'";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Работник уволен.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }

        //прайс лист
        public DataTable dtGetPriseList = new DataTable();
        public void GetPriseList()
        {
            msCommand.CommandText = "select priselost.keyPriseLost , store.nameTovar, priselost.date,priselost.cena from priselost JOIN store ON store.keyStore=priselost.keyStore";
            dtGetPriseList.Clear();
            msDataAdapter.Fill(dtGetPriseList);

        }


        public void PriseListeAdd(string keyStory, string date, string cena)
        {
            try
            {
                keyStory = PoiskKey("store", "nameTovar", "keyStore", keyStory);

            
            
                msCommand.CommandText = "insert into priselost values (null, " + keyStory + ",'" + date + "'," + cena + ")";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Запись добавлена.");

                }
                else
                    System.Windows.Forms.MessageBox.Show("Ошибка!");
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }

        }


        // идет дублирование данных из-за прайс листа
        public DataTable dtGetKasirStore = new DataTable();
        public void GetKasirStore()
        {
            msCommand.CommandText = @"select store.nameTovar,categorytov.CategoryTov,edizmeren.EdIzmeren,store.kolvo, priselost.cena  from store
             join priselost on priselost.keyStore = store.keyStore  
             join edizmeren on edizmeren.keyEdIzmeren = store.keyEdIzmeren
             join categorytov on categorytov.keyCategoryTov = store.keyCategoryTov and priselost.date =(select max(date)from priselost) order by store.nameTovar ";
            dtGetKasirStore.Clear();
            msDataAdapter.Fill(dtGetKasirStore);
        }

        public DataTable dtGetChecAdd = new DataTable();
        public void GetChecAdd(string keyChek)
        {
            try
            {
                msCommand.CommandText = @"select checklist.keyCheckList, store.nameTovar, checklist.kolvo, priselost.cena from checklist 
            join store on store.keyStore = checklist.keyStore 
            join priselost on priselost.keyPriseLost = checklist.keyPriseLost where checklist.keyCheck = " + keyChek;
                dtGetChecAdd.Clear();
                msDataAdapter.Fill(dtGetChecAdd);
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }
        }
        public string suumChek(string keyChek)
        {
            msCommand.CommandText = @"select sum( checklist.kolvo * priselost.cena) from checklist 
            join store on store.keyStore = checklist.keyStore
            join priselost on priselost.keyPriseLost = checklist.keyPriseLost where checklist.keyCheck = "+keyChek;
            object result = msCommand.ExecuteScalar();

            return Convert.ToString(result);
        }
        public void CheckListAdd(string keyCheck, string keyStore, string kolvo)
        {
            try
            {
                keyStore = PoiskKey("store", "nameTovar", "keyStore", keyStore);
                //проверка кол-во товара на складе
                msCommand.CommandText = "select kolvo from store where keyStore = " + keyStore;
                object returhStor = msCommand.ExecuteScalar();
                if (Convert.ToInt32(returhStor) >= Convert.ToInt32(kolvo))
                {
                    string revers = Convert.ToString(Convert.ToInt32(returhStor) - Convert.ToInt32(kolvo));
                    msCommand.CommandText = "update store set kolvo =" + revers + " where keyStore = " + keyStore + "; ";
                    msCommand.ExecuteNonQuery();


                    //проверка на существующую запись
                    msCommand.CommandText = "select kolvo from checklist where keyCheck=" + keyCheck + " and keyStore=" + keyStore + " ;";
                    object result = msCommand.ExecuteScalar();
                    string prise;
                    msCommand.CommandText = "select keyPriseLost from priselost where keyStore =" + keyStore + " order by date DESC";
                    object resultPrise = msCommand.ExecuteScalar();
                    prise = Convert.ToString(resultPrise);
                    if (result == null)
                    {

                        msCommand.CommandText = "insert into checklist values (null," + keyCheck + "," + keyStore + "," + kolvo + ", " + prise + ")";
                        if (msCommand.ExecuteNonQuery() > 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Запись добавлена.");

                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Ошибка!");
                    }
                    else
                    {
                        string kol = Convert.ToString(Convert.ToInt32(result) + Convert.ToInt32(kolvo));
                        msCommand.CommandText = "update checklist set kolvo=" + kol + " where  keyCheck=" + keyCheck + " and keyStore=" + keyStore + " ;";
                        msCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Нет укзанного количества товара на складе!");
                }
            }
            catch
            {
                MessageBox.Show("На данный товар не установлена цена.", "Действие невозможно!");
                msCommand.CommandText = "select kolvo from store where keyStore = " + keyStore;
                object returhStor = msCommand.ExecuteScalar();
                string revers = Convert.ToString(Convert.ToInt32(returhStor) + Convert.ToInt32(kolvo));
                msCommand.CommandText = "update store set kolvo =" + revers + " where keyStore = " + keyStore + "; ";
                msCommand.ExecuteNonQuery();
            }
        }
        //возврат товара на склад
        public void StoreListAdd(string nameTov, string kolvo, bool id = true)
        {
            try
            {
                string res;
            msCommand.CommandText = "select kolvo from store where nameTovar = '"+ nameTov+"'";
            object returhStor = msCommand.ExecuteScalar();
            if (id)
            {
                 res = Convert.ToString(Convert.ToInt32(returhStor) + Convert.ToInt32(kolvo));
            }
            else 
            {
                res = Convert.ToString(Convert.ToInt32(returhStor) - Convert.ToInt32(kolvo));
            }
            msCommand.CommandText = "update store set kolvo =" + res + " where nameTovar = '" + nameTov + "'; ";
            msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }
        }


        public string ChekAdd()
        {
            try
            {
                DateTime date = new DateTime();
            date = DateTime.Now;
            string dateTime = date.ToString("yyyy-MM-dd hh:mm:ss"); //INSERT INTO `corporehen2`.`check` (`date`, `keyUsers`) VALUES('2020-12-12 03:24:32', '2');
            msCommand.CommandText = "insert into  checks (date, keyUsers) values ('" + dateTime+"',"+keyLog+");";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                msCommand.CommandText = "select keyCheck from checks where date = '" + dateTime+"';";
                Object result = msCommand.ExecuteScalar();
                return Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Ошибка добавления.");
                return null;
            }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления.");
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
                return null;
            }
        }



        //public void PriseListUpdate()
        //{
        //    msCommand.CommandText = "";
        //    if (msCommand.ExecuteNonQuery() > 0)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Запись изменена.");

        //    }
        //    else
        //        System.Windows.Forms.MessageBox.Show("Ошибка!");

        //}










        //категории товара
        public DataTable dtGetKategoriy = new DataTable();
        public void GetKategoriy()
        {
            msCommand.CommandText = "select * from categorytov order by CategoryTov ";
            dtGetKategoriy.Clear();
            msDataAdapter.Fill(dtGetKategoriy);

        }
        //еденица измерения товара
        public DataTable dtGetEdenIzmeren = new DataTable();
        public void GetEdenIzmeren()
        {
            msCommand.CommandText = "select * from edizmeren";
            dtGetEdenIzmeren.Clear();
            msDataAdapter.Fill(dtGetEdenIzmeren);

        }
        //справочник добовление
        public void HandbookAdd(string text, string table)
        {
            msCommand.CommandText = "insert into "+table+" values (null,'"+text+"')";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись добавлена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }
        
        //справочник редоктирование
        public void HandbookUpdate(string table, string namePoly, string text,string poleWhrere, string texstWhere)
        {
            msCommand.CommandText = "update "+table+" set "+namePoly+" = '"+text+"'  where "+poleWhrere+"="+texstWhere+"";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись изменена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");

        }

        //удаление из справочника и других таблиц
        public void HandbookDel(string table,string poleWhere, string textWhere)
        {
            msCommand.CommandText = "DELETE from " + table+ " WHERE " + poleWhere+"="+textWhere+""; // 
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись удалена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }

        //проверка на связи в другой таблице
        public bool relations (string table, string where, string textWhere)
        {
            msCommand.CommandText = "select * from "+table+" where "+where+" = "+textWhere;
            object retur = msCommand.ExecuteScalar();
            if (retur == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Данная запись используется в других таблицах!","Невозможно удаление!");
                return false;
            }
        }



        //таблица поставок
        public DataTable dtGetPostavhik = new DataTable();
        public void GetPostavhik()
        {
            msCommand.CommandText = "select keyContractor, nameContractor, adres, telephon from contractor order by nameContractor";
            dtGetPostavhik.Clear();
            msDataAdapter.Fill(dtGetPostavhik);
        }

        //новая поставка
        public void PostavhikAdd(string name,string telephon, string adres)
        {
            msCommand.CommandText = "insert into contractor values (null,'"+name+"','"+telephon+"', '"+adres+"')";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись добавлена.");  

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }

        //редоктирование поставки 
        public void PostavhikUpdate(string newname, string telephon,string adres, string name)
        {
            msCommand.CommandText = "update contractor set nameContractor = '"+newname+ "', telephon='"+telephon+ "', adres = '"+adres+ "' where nameContractor='"+name+"'";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись изменена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }





        public DataTable dtPrihod = new DataTable();
        public void GetPrihod()
        {
            msCommand.CommandText = "select prihod.keyPrihod, prihod.numPrihood,prihod.date,contractor.nameContractor,prihod.keyUsers from prihod  " +
                "JOIN contractor on contractor.keyContractor=prihod.keyContractor  ORDER BY date;"; ///добавить отбор про дате
            dtPrihod.Clear();
            msDataAdapter.Fill(dtPrihod);
        
        }
        
        
        public DataTable dtPrihodList = new DataTable();
        public void GetPrihodList(string keyPrihod)
        {
            if (keyPrihod == "")
            { }
            else
            {
                msCommand.CommandText = "select prihodlist.keyPrihodList, store.nameTovar, prihodlist.kolvo, prihodlist.cena from prihodlist join store on store.keyStore=prihodlist.keyStore where prihodlist.keyPrihod = " + keyPrihod + "";
                dtPrihodList.Clear();
                msDataAdapter.Fill(dtPrihodList);
            } }

        public void PrihodAdd(string nameConractor, string data, string keyUser, string numPrihod)
        {
            try
            {

                nameConractor = PoiskKey("contractor", "nameContractor", "keyContractor", nameConractor);
            msCommand.CommandText = "insert into prihod values (null," + nameConractor + ",'"+data+"', "+keyUser+","+numPrihod+");";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                //System.Windows.Forms.MessageBox.Show("Создан новый приход.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }
        }
         
        public string keyPrihod (string numPrihod)
        {
            msCommand.CommandText = "select keyPrihod from prihod where numPrihood = " + numPrihod+"";
            object retur = msCommand.ExecuteScalar();
            return Convert.ToString(retur);
        }

        public void PrihodListAdd(string keyPrihod, string keySklad, string kol_vo, string cena)
        {
            try
            {
                msCommand.CommandText = "select keyStore from prihodlist where keyStore =" + keySklad+ " and keyPrihod="+ keyPrihod;
            object reult = msCommand.ExecuteScalar();
            if (reult == null)
            {
                msCommand.CommandText = "select kolvo from store where keyStore =" + keySklad + ";";
                object result = msCommand.ExecuteScalar();
                string kolStoc = Convert.ToString(result);
                kolStoc = Convert.ToString(Convert.ToInt32(kol_vo) + Convert.ToInt32(kolStoc));

                msCommand.CommandText = "update store set kolvo =" + kolStoc + " where   keyStore =" + keySklad + ";";
                msCommand.ExecuteNonQuery();


                msCommand.CommandText = "insert into prihodlist values (null, " + keyPrihod + "," + keySklad + "," + kol_vo + "," + cena + ")";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Запись сохранена.");

                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            else
                MessageBox.Show("Данная запись уже существует!");
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }
        }



        public DataTable dtGetStore = new DataTable();
        public void GetStore ()
        {
            msCommand.CommandText = @"select store.keyStore,store.nameTovar,edizmeren.EdIzmeren, categorytov.CategoryTov, store.kolvo  from store
                join categorytov on categorytov.keyCategoryTov = store.keyCategoryTov
                join edizmeren on edizmeren.keyEdIzmeren = store.keyEdIzmeren";
            dtGetStore.Clear();
            msDataAdapter.Fill(dtGetStore);
        }

        public void StoreAdd(string nameTov, string EdenIzmeren, string CatrigorTov, string Kol_vo)
        {
            try
            {
                msCommand.CommandText = "select keyStore from store where nameTovar='" + nameTov + "';";
            object result = msCommand.ExecuteScalar();

            if (result == null)
            {
                string keyCat = PoiskKey("categorytov", "CategoryTov", "keyCategoryTov", CatrigorTov);
                string keyEd = PoiskKey("edizmeren", "EdIzmeren", "keyEdIzmeren", EdenIzmeren);
                msCommand.CommandText = "insert into store values (null,'" + nameTov + "'," + keyEd + ", " + keyCat + ", " + Kol_vo + ")";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Запись сохранена!");
                }
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Этот товар уже есть в базе.");
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }
        }

        public void StoreUpdate(string keyStore,string nameTov, string EdenicaIzmeren, string CategotTov,string kol_vo)
        {
            try
            {
                msCommand.CommandText = "select keyStore from store where nameTovar='" + nameTov + "';";
            object result = msCommand.ExecuteScalar();

            if (result == null)
            {
                string keyEd = PoiskKey("edizmeren", "EdIzmeren", "keyEdIzmeren", EdenicaIzmeren);
                string keyCat = PoiskKey("categorytov", "CategoryTov", "keyCategoryTov", CategotTov);
                msCommand.CommandText = "update store set nameTovar = '" + nameTov + "', keyEdIzmeren='" + keyEd + "', keyCategoryTov='" + keyCat + "', kolvo = " + kol_vo + " where keyStore= " + keyStore + ";";
                if (msCommand.ExecuteNonQuery() > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Запись изменена.");

                }
                else
                    System.Windows.Forms.MessageBox.Show("Ошибка!");
            }
            else
                MessageBox.Show("Этот товар уже есть в базе.");
            }
            catch
            {
                MessageBox.Show("Данная ошибка вызвана  по причине дискотека с базой данных или перезаполненные базы данных", "Ошибка. Сервер не отвечает.");
            }
        }

        public void StoreDel (string keyStore)
        {
            msCommand.CommandText = "DELETE from store where keyStore = " + keyStore+"";
            if (msCommand.ExecuteNonQuery() > 0)
            {
                System.Windows.Forms.MessageBox.Show("Запись удалена.");

            }
            else
                System.Windows.Forms.MessageBox.Show("Ошибка!");
        }






        public string PoiskKey(string TableName, string poleNema, string poleKeyName, string text)
        {
            msCommand.CommandText = "select " + poleKeyName + " from " + TableName + " where " + poleNema + "='" + text + "';";
            //фиксируем результат запроса
            Object result = msCommand.ExecuteScalar();
            return result.ToString();
        }

    }
    
}
