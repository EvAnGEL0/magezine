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
    public partial class ContraktorUpdate : MetroForm
    {
        public ContraktorUpdate()
        {
            InitializeComponent();
        }
        public string name;

        private void metroOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroOk_Click(object sender, EventArgs e)
        {
            if (metroTextName.Text == "" | maskedTextBox1.Text == "" | metroTextBoxAdres.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                db_conect db = new db_conect();
                db.PostavhikUpdate(metroTextName.Text, maskedTextBox1.Text, metroTextBoxAdres.Text, name);
                Close();
            }
        }
    }
}
