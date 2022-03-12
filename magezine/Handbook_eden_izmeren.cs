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
    public partial class Handbook_eden_izmeren : MetroForm
    {
        db_conect db = new db_conect();
        public Handbook_eden_izmeren()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                if (db.dublirov("EdIzmeren", "edizmeren", "EdIzmeren", "'" + metroTextBox1.Text + "'"))
                {
                    db.HandbookAdd(metroTextBox1.Text, "edizmeren");
                    db.GetEdenIzmeren();
                    dataGridView1.DataSource = db.dtGetEdenIzmeren;
                }
                else
                {
                    MessageBox.Show("Такая запись уже есть!");
                }
            }
        }

        private void Handbook_eden_izmeren_Load(object sender, EventArgs e)
        {
            db.GetEdenIzmeren();
            dataGridView1.DataSource = db.dtGetEdenIzmeren;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                if (db.dublirov("EdIzmeren", "edizmeren", "EdIzmeren", "'" + metroTextBox1.Text + "'"))
                {
                    db.HandbookUpdate("edizmeren", "EdIzmeren", metroTextBox1.Text, "keyEdIzmeren", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    db.GetEdenIzmeren();
                    dataGridView1.DataSource = db.dtGetEdenIzmeren;
                }
                else
                {
                    MessageBox.Show("Такая запись уже есть!");
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить запись "+ dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString() + "", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (db.relations("store", "keyEdIzmeren", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()))
                {

                    db.HandbookDel("edizmeren", "keyEdIzmeren", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    db.GetEdenIzmeren();
                    dataGridView1.DataSource = db.dtGetEdenIzmeren;
                }
            }
        }
    }
}
