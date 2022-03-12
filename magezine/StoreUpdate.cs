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
    public partial class StoreUpdate : MetroForm
    {
        public StoreUpdate()
        {
            InitializeComponent();
        }
        db_conect db_ = new db_conect();
        public string key;
        private void StoreUpdate_Load(object sender, EventArgs e)
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

        private void metroButtonUpdate_Click(object sender, EventArgs e)
        {
            if (metroTextname.Text == "" | metroTextKol_vo.Text == "" | metroComboCategor.Text == "" | metroComboEden.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                db_.StoreUpdate(key, metroTextname.Text, metroComboEden.Text, metroComboCategor.Text, metroTextKol_vo.Text);
                Close();
            }
        }
    }
}
