using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace magezine
{
    public partial class PrihodAdd : MetroForm
    {
        db_conect db_ = new db_conect();
        string keyPrihod;

        public PrihodAdd()
        {
            InitializeComponent();
        }

        private void metroClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroBNext_Click(object sender, EventArgs e)
        {
            if (metroTextNum.Text == "" | metroComboContraktor.Text == "" | datePrihod.Text == "")
                MessageBox.Show("Заполните поля!", "Ошибка!");
            else    
            {
                db_.PrihodAdd(metroComboContraktor.Text, datePrihod.Value.ToString("yyyy-MM-dd"), db_conect.keyLog, metroTextNum.Text);
                keyPrihod = db_.keyPrihod(metroTextNum.Text);
                db_.GetPrihodList(keyPrihod);
                dataGridVPrihodList.DataSource = db_.dtPrihodList;
                groupPrihod.Visible = false;
                groupPriseList.Visible = true;

            }
        }

        private void PrihodAdd_Load(object sender, EventArgs e)
        {
            groupPrihod.Dock = DockStyle.Fill;
            groupPrihod.Visible = true;
            groupPriseList.Dock = DockStyle.Fill;
            groupPriseList.Visible = false;  
            db_.GetPostavhik();
            metroComboContraktor.DataSource = db_.dtGetPostavhik;
            metroComboContraktor.DisplayMember = "nameContractor";
            metroComboContraktor.ValueMember = "keyContractor";
            db_.GetStore();
            metroComboTov.DataSource = db_.dtGetStore;
            metroComboTov.DisplayMember = "nameTovar";
        }

        private void metroTextNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            if (metroTextCena.Text == "" | metroTextKol_vo.Text == "")
            {
                MessageBox.Show("Заполните поля.");
            }
            else
            {



                db_.PrihodListAdd(keyPrihod, db_.PoiskKey("store", "nameTovar", "keyStore", "" + metroComboTov.Text + ""), metroTextKol_vo.Text, metroTextCena.Text);
                db_.GetPrihodList(keyPrihod);
                dataGridVPrihodList.DataSource = db_.dtPrihodList;
            }
        }

        private void metroButtonNewTow_Click(object sender, EventArgs e)
        {
            StoreAdd storeAdd = new StoreAdd();
            storeAdd.ShowDialog();
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroLabelKol_vo_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить товар " + dataGridVPrihodList[1, dataGridVPrihodList.CurrentCell.RowIndex].Value.ToString() + " из поставки?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                db_.StoreListAdd(dataGridVPrihodList[1, dataGridVPrihodList.CurrentCell.RowIndex].Value.ToString(), dataGridVPrihodList[2, dataGridVPrihodList.CurrentCell.RowIndex].Value.ToString(),false);
                db_.HandbookDel("prihodlist", "keyPrihodList", dataGridVPrihodList[0, dataGridVPrihodList.CurrentCell.RowIndex].Value.ToString());
                db_.GetPrihodList(keyPrihod);
                dataGridVPrihodList.DataSource = db_.dtPrihodList;
            }
        }
    }
}
