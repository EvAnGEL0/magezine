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
    public partial class handbook_kategoriy : MetroForm
    {
        db_conect db = new db_conect();
        public handbook_kategoriy()
        {
            InitializeComponent();
        }

        private void handbook_kategoriy_Load(object sender, EventArgs e)
        {
            db.GetKategoriy();
            dataGridView1.DataSource = db.dtGetKategoriy;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                if (db.dublirov("CategoryTov", "categorytov", "CategoryTov", "'" + metroTextBox1.Text + "'"))
                {
                    db.HandbookAdd(metroTextBox1.Text, "categorytov");
                    db.GetKategoriy();
                    dataGridView1.DataSource = db.dtGetKategoriy;
                }
                else
                {
                    MessageBox.Show("Такая запись уже есть!");
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroButton1.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                if (metroTextBox1.Text == "")
                {
                    MessageBox.Show("Заполните поле!");
                }
                else
                {
                    if (db.dublirov("CategoryTov", "categorytov", "CategoryTov", "'" + metroTextBox1.Text + "'"))
                    {
                        db.HandbookUpdate("categorytov", "CategoryTov", metroTextBox1.Text, "keyCategoryTov", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                        db.GetKategoriy();
                        dataGridView1.DataSource = db.dtGetKategoriy;
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть!");
                    }
                }
                }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотитеудалить запись " + dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (db.relations("store", "keyCategoryTov", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()))
                {
                    db.HandbookDel("categorytov", "keyCategoryTov", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    db.GetKategoriy();
                    dataGridView1.DataSource = db.dtGetKategoriy;
                }
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroButton1.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                metroTextBox1.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                db.GetKategoriy();
                dataGridView1.DataSource = db.dtGetKategoriy;
            }
            }
    }
}
    