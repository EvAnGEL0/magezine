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
    public partial class StoreAdd : MetroForm
    {
        public StoreAdd()
        {
            InitializeComponent();
        }
        db_conect db_ = new db_conect();
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            if(metroTextname.Text ==""|metroTextKol_vo.Text ==""|metroComboCategor.Text ==""| metroComboEden.Text=="")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                db_.StoreAdd(metroTextname.Text,metroComboEden.Text,metroComboCategor.Text, metroTextKol_vo.Text);
                Close();
            }
        }

        private void Store_Load(object sender, EventArgs e)
        {
            db_.GetEdenIzmeren();
            metroComboEden.DataSource = db_.dtGetEdenIzmeren;
            metroComboEden.DisplayMember = "EdIzmeren";

            db_.GetKategoriy();
            metroComboCategor.DataSource = db_.dtGetKategoriy;
            metroComboCategor.DisplayMember = "CategoryTov";
           


        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTextKol_vo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }
    }
}
