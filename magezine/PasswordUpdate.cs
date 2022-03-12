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
    public partial class PasswordUpdate : MetroForm
    {
        public string login;
        public PasswordUpdate()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text=="")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                db_conect db = new db_conect();
                db.PersonalUpdate(metroTextBox1.Text, login);
                Close();
            }
        }
    }
}
