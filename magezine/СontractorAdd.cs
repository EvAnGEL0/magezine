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
   
    public partial class СontractorAdd : MetroForm
    {
        public СontractorAdd()
        {
            InitializeComponent();
        }
        db_conect db = new db_conect();
        private void metroOk_Click(object sender, EventArgs e)
        {
            if (metroTextName.Text =="" |maskedTextBox1.Text =="" | metroTextBoxAdres.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (db.dublirov("nameContractor", "contractor", "nameContractor", "'" + metroTextName.Text + "'"))
                {
                    db.PostavhikAdd(metroTextName.Text, maskedTextBox1.Text, metroTextBoxAdres.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("Такая запись уже есть!");
                }
            }
        }

        private void metroOff_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
