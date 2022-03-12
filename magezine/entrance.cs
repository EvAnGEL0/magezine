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
    public partial class Form1 : MetroForm
    {
        db_conect conect = new db_conect();
        public Form1()
        {
            InitializeComponent();
            Logotipe logotipe = new Logotipe();
            logotipe.ShowDialog();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db_conect conect = new db_conect();
            conect.Connect  ();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            conect.Authorization(login.Text, password.Text);

            switch (db_conect.Role)
            {
                case null:
                    System.Windows.Forms.MessageBox.Show("Неверные данные!");
                    break;
                //admin
                case "1":
                    this.Hide();
                    director director = new director();
                    director.Show();
                    break;
                case "2":
                    this.Hide();
                    Kassir kassir = new Kassir();
                    kassir.Show();
                    //Допиши код менеджера

                    break;
                case "3":
                    this.Hide();
                    Kladovhik kladovhik = new Kladovhik();
                    kladovhik.Show();
                    break;

            }
            login.Text = "";
            password.Text = "";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.Show();
        }
    }
}
