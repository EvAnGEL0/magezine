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
    public partial class PriseListAdd : MetroForm
    {
        public PriseListAdd()
        {
            InitializeComponent();
        }
        db_conect db_ = new db_conect();
        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "")
            {
                DateTime date = new DateTime();
                date = DateTime.Now;
                db_.PriseListeAdd(metroComboBox1.Text, date.ToString("yyyy-MM-dd"), metroTextBox1.Text);
                Close();
            }
            else
                MessageBox.Show("Заполняете поле!");
            }

        private void PriseListAdd_Load(object sender, EventArgs e)
        {
            db_.GetStore();
            metroComboBox1.DataSource = db_.dtGetStore;
            metroComboBox1.DisplayMember = "nameTovar";
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }
    }
}
