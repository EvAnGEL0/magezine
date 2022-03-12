using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace magezine
{
    public partial class PersonalAdd : MetroForm
    {
        public PersonalAdd()
        {
            InitializeComponent();
        }

        private void PersonalAdd_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
db_conect db = new db_conect();
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string key = null;
            switch (metroDolzn.Text)
            {
                case "Директор": key = "1";
                    break;
                case "Кассир": key = "2";
                    break;
                case "Кладовщик ": key = "3";
                    break;

            }
            if (metroSurname.Text ==""|metroName.Text == ""|metroPatronymic.Text ==""|metroLogin.Text == ""| metroPasswd.Text ==""|metroDolzn.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                if (db.dublirov("login", "users", "login", "'" + metroLogin.Text + "'"))
                {
                    
                    db.PersonalAdd(metroSurname.Text, metroName.Text, metroPatronymic.Text, key, metroLogin.Text, metroPasswd.Text);
                    metroSurname.Text = "";
                    metroName.Text = "";
                    metroPatronymic.Text = "";
                    metroLogin.Text = "";
                    metroPasswd.Text = "";
                    metroDolzn.Text = "";
                }
                else
                {
                    MessageBox.Show("Такая запись уже есть!");
                }
            }
            key = null;
                
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
