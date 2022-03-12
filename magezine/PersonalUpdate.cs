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
    
    public partial class PersonalUpdate : MetroForm
    {
        public string log;
        db_conect db_ = new db_conect();
        public PersonalUpdate()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string key = null;
            switch (metroDolzn.Text)
            {
                case "Директор":
                    key = "1";
                    break;
                case "Кассир":
                    key = "2";
                    break;
                case "Кладовщик ":
                    key = "3";
                    break;

            }
            if (metroSurname.Text ==""|metroName.Text ==""|metroPatronymic.Text == ""|metroDolzn.Text =="")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                db_.PersonalUpdate(metroPatronymic.Text,metroName.Text, metroSurname.Text, key, log);
                Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
