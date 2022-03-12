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
    public partial class Kassir : MetroForm
    {
        public Kassir()
        {
            InitializeComponent();
        }
        db_conect db_ = new db_conect();
        private void Form2_Load(object sender, EventArgs e)
        {
            db_.GetKasirStore();
            dataGridView1.DataSource = db_.dtGetKasirStore;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChekAdd chek = new ChekAdd();
           chek.ShowDialog();
        }

        private void Kassir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void выходИзАкаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void metroTextPoisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString() == metroTextPoisk.Text)
                        dataGridView1.Rows[i].Cells[j].Selected = true;
                    else
                        dataGridView1.Rows[i].Cells[j].Selected = false;
        }
    }
}
