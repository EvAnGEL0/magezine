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
    public partial class ChekAdd : MetroForm
    {
        public ChekAdd()
        {
            InitializeComponent();
        }

        string key;
        db_conect db_ = new db_conect();
        private void ChekAdd_Load(object sender, EventArgs e)
        {
            key = db_.ChekAdd();
            metroLabel1.Text = "Номер чека: " + key;
           
            db_.GetStore();
            metroComboBox.DataSource = db_.dtGetStore;
            metroComboBox.DisplayMember = "nameTovar";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBoxColum.Text != "")
            {
                db_.CheckListAdd(key, metroComboBox.Text, metroTextBoxColum.Text);
                db_.GetChecAdd(key);
                dataGridView.DataSource = db_.dtGetChecAdd;
                metroLabeItoge.Text = "Всего: " + db_.suumChek(key);
            }
            else
            {
                MessageBox.Show("Заполните поля!");
            }
        }
        private void getChecKict()
        {
            db_.GetChecAdd(key);
            dataGridView.DataSource = db_.dtGetChecAdd;
        }


        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 3] = "Товарный че";
            ExcelApp.Cells[3, 2] = metroLabel1.Text;
            ExcelApp.Cells[2, 2] = "Корпорация праздников";
            ExcelApp.Cells[4, 2] = "Наименование товара";
            ExcelApp.Cells[4, 3] = "Количество";
            ExcelApp.Cells[4, 4] = "Цена";
            //ExcelApp.Cells[2, 5] = "";
            //цикл записи данных
            int i;
            for (i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView.Columns.Count; j++)
                {
                    ExcelApp.Cells[i + 5, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Cells[i + 4,3] = metroLabeItoge.Text;

            ExcelApp.Cells[i + 5, 3] = DateTime.Now.ToString("dd.MM.yyyy");
            ExcelApp.Cells[i + 5, 2] = "Дата:";
            ExcelApp.Cells[i + 6, 3] = "Подпись:";
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить товар " + dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString() + " из чека?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                db_.StoreListAdd(dataGridView[1, dataGridView.CurrentCell.RowIndex].Value.ToString(), dataGridView[2, dataGridView.CurrentCell.RowIndex].Value.ToString());
                db_.HandbookDel("checklist", "keyCheckList", dataGridView[0, dataGridView.CurrentCell.RowIndex].Value.ToString());
                getChecKict();
            }
        }
    }
}
