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
    
    public partial class Kladovhik : MetroForm
    {
        db_conect db_ = new db_conect();
        public Kladovhik()
        {
            InitializeComponent();
        }

        private void Kladovhik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handbook_kategoriy handbook1 = new handbook_kategoriy();
            handbook1.ShowDialog();
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Handbook_eden_izmeren handbook = new Handbook_eden_izmeren();
            handbook.ShowDialog();
        }

        private void Kladovhik_Load(object sender, EventArgs e)
        {
            splitPostavka.Dock = DockStyle.Fill;
            splitStore.Dock = DockStyle.Fill;
            GetStor();
            splitPostavka.Visible = false;
            splitStore.Visible = true;
        }

        private void metroLabelPostavki_Click(object sender, EventArgs e)
        {
            //добавить
            // splitPostavka.Dock = DockStyle.Fill;
            splitPostavka.Visible = true;
            splitStore.Visible = false;
            db_.GetPrihod();
            dataGridViewProhod.DataSource = db_.dtPrihod;

        }

        private void dataGridViewProhod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db_.GetPrihodList(dataGridViewProhod[0,dataGridViewProhod.CurrentCell.RowIndex].Value.ToString());
            dataGridViewProhodList.DataSource = db_.dtPrihodList;
        }

        private void metroButtonMewPost_Click(object sender, EventArgs e)
        {
            PrihodAdd add = new PrihodAdd();
            add.FormClosing += new FormClosingEventHandler(update);
            add.ShowDialog();
        }

        private void update(object sender, FormClosingEventArgs e)
        {
            //добавить 
            db_.GetPrihod();
            dataGridViewProhod.DataSource = db_.dtPrihod;


        }

        private void metroLabelSklade_Click(object sender, EventArgs e)
        {
            splitPostavka.Visible = false;
            splitStore.Visible = true;
            GetStor();
           

        }
        private void GetStor()
        {
            db_.GetStore();
            dataGridStore.DataSource = db_.dtGetStore;
        }
        private void gStor(object sendber, FormClosingEventArgs e)
        {
            GetStor();
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            StoreAdd storeAdd = new StoreAdd();
            storeAdd.FormClosing += new FormClosingEventHandler(gStor);
            storeAdd.ShowDialog();
        }

        private void metroButtonUpdate_Click(object sender, EventArgs e)
        {
            StoreUpdate storeUpdate = new StoreUpdate();

            storeUpdate.FormClosing += new FormClosingEventHandler(gStor);
            storeUpdate.key = dataGridStore[0, dataGridStore.CurrentCell.RowIndex].Value.ToString();
            storeUpdate.metroTextname.Text = dataGridStore[1, dataGridStore.CurrentCell.RowIndex].Value.ToString();
            storeUpdate.metroTextKol_vo.Text = dataGridStore[4, dataGridStore.CurrentCell.RowIndex].Value.ToString();
            storeUpdate.ShowDialog();
            storeUpdate.metroComboCategor.Text = dataGridStore[3, dataGridStore.CurrentCell.RowIndex].Value.ToString();
            storeUpdate.metroComboEden.Text = dataGridStore[2, dataGridStore.CurrentCell.RowIndex].Value.ToString();

        }

        private void metroButtonDel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить товар " + dataGridStore[1, dataGridStore.CurrentCell.RowIndex].Value.ToString() + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (db_.relations("checklist", "keyStore", dataGridStore[0, dataGridStore.CurrentCell.RowIndex].Value.ToString()))
                    if (db_.relations("priselost", "keyStore", dataGridStore[0, dataGridStore.CurrentCell.RowIndex].Value.ToString()))
                        if (db_.relations("prihodlist", "keyStore", dataGridStore[0, dataGridStore.CurrentCell.RowIndex].Value.ToString()))
                            db_.HandbookDel("store", "keyStore", dataGridStore[0, dataGridStore.CurrentCell.RowIndex].Value.ToString());
                 GetStor();

            }   
        }

        private void выходИзПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчетСоСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GetStor();
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 4] = "Отчет о остатках товаров на складе ";
            
            ExcelApp.Cells[2, 2] = "Товар";
            ExcelApp.Cells[2, 3] = "Единица измерения";
            ExcelApp.Cells[2, 4] = "Котегория товара";
            ExcelApp.Cells[2, 5] = "Количество";
            //цикл записи данных
            int i;
            for ( i = 0; i < dataGridStore.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridStore.Columns.Count; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = dataGridStore.Rows[i].Cells[j].Value;
                }
            }
            
            ExcelApp.Cells[i+3, 3] = DateTime.Now.ToString("dd.MM.yyyy");
            ExcelApp.Cells[i+3, 2] = "Дата:";
            ExcelApp.Cells[i+3, 4] = "Подпись:";
            //Microsoft.Office.Interop.Excel.Range rng = ExcelWorkSheet.Range["K3"];
            //rng.Formula = "=SUM(J3:J1000)";
            //rng.FormulaHidden = false;
            Microsoft.Office.Interop.Excel.Range rng2 = ExcelWorkSheet.Range["A1 : K1000"];
            Microsoft.Office.Interop.Excel.Range rng3 = ExcelWorkSheet.Range["E1"];
            rng2.Font.Name = "Times New Roman";
            rng3.Font.Bold = true;
            rng2.Font.Size = 14;
            rng2.EntireColumn.AutoFit();
            rng2.EntireRow.AutoFit();
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
