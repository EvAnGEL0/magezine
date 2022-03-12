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
    public partial class director : MetroForm
    {
        db_conect db_ = new db_conect();
        public director()
        {
            InitializeComponent();
        }

        private void director_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }



        private void metroButton4_Click(object sender, EventArgs e)
        {
            PersonalAdd add = new PersonalAdd();

            add.FormClosing += new FormClosingEventHandler(ClouuseUpdqteUsers);
            add.ShowDialog();
        }

        private void ClouuseUpdqteUsers(object sendber, FormClosingEventArgs e)
        {
            getUsers();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            metroLabel1.BackColor = Color.LimeGreen;
            metroLabel2.BackColor = Color.White;
            metroLabel3.BackColor = Color.White;
            PriseList.Visible = true;
            Users.Visible = false;
            Postavhiki.Visible = false;
            getPriseList();
        }
        private void getPriseList()
        {
            db_.GetPriseList();
            dataGridPrise.DataSource = db_.dtGetPriseList;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            metroLabel1.BackColor = Color.White;
            metroLabel3.BackColor = Color.White;
            metroLabel2.BackColor = Color.LimeGreen;
            Users.Visible = true;
            PriseList.Visible = false;
            Postavhiki.Visible = false;
            getUsers();

        }
        private void getUsers()
        {
            db_.GetUsers();
            dataGridUsers.DataSource = db_.dtGetUsers;
        }

        private void director_Load(object sender, EventArgs e)
        {
            PriseList.Visible = true;
            Users.Visible = false;
            Postavhiki.Visible = false;
            Users.Dock = DockStyle.Fill;
            PriseList.Dock = DockStyle.Fill;
            Postavhiki.Dock = DockStyle.Fill;
            getUsers();
            getPriseList();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            PersonalUpdate pUpdate = new PersonalUpdate();
            pUpdate.FormClosing += new FormClosingEventHandler(ClouuseUpdqteUsers);
            pUpdate.metroSurname.Text = dataGridUsers[0, dataGridUsers.CurrentCell.RowIndex].Value.ToString();
            pUpdate.metroName.Text = dataGridUsers[1, dataGridUsers.CurrentCell.RowIndex].Value.ToString();
            pUpdate.metroPatronymic.Text = dataGridUsers[2, dataGridUsers.CurrentCell.RowIndex].Value.ToString();
            pUpdate.metroDolzn.Text = dataGridUsers[3, dataGridUsers.CurrentCell.RowIndex].Value.ToString();
            pUpdate.log = dataGridUsers[4, dataGridUsers.CurrentCell.RowIndex].Value.ToString();
            pUpdate.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите уволить пользователя с логином " + dataGridUsers[4, dataGridUsers.CurrentCell.RowIndex].Value.ToString() + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                db_.PersonalDismissal(dataGridUsers[4, dataGridUsers.CurrentCell.RowIndex].Value.ToString());
                getPriseList();

            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            PasswordUpdate password = new PasswordUpdate();
            password.login = dataGridUsers[4, dataGridUsers.CurrentCell.RowIndex].Value.ToString();
            password.ShowDialog();
        }

        private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handbook_kategoriy handbook1 = new handbook_kategoriy();
            handbook1.ShowDialog();
        }

        private void еденициИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Handbook_eden_izmeren handbook = new Handbook_eden_izmeren();
            handbook.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            metroLabel1.BackColor = Color.White;
            metroLabel2.BackColor = Color.White;
            metroLabel3.BackColor = Color.LimeGreen;
            Users.Visible = false;
            PriseList.Visible = false;
            Postavhiki.Visible = true;

            getContraktor();
        }

        private void getContraktor()
        {
            db_.GetPostavhik();
            dataGridContractor.DataSource = db_.dtGetPostavhik;
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            СontractorAdd сontractorAdd = new СontractorAdd();
            сontractorAdd.FormClosing += new FormClosingEventHandler(contraktorUpdate);
            сontractorAdd.ShowDialog();

        }
        private void contraktorUpdate(object sendber, FormClosingEventArgs e)
        {
            getContraktor();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            ContraktorUpdate cont = new ContraktorUpdate();
            cont.FormClosing += new FormClosingEventHandler(contraktorUpdate);
            cont.metroTextName.Text = dataGridContractor[1, dataGridContractor.CurrentCell.RowIndex].Value.ToString();
            cont.name = dataGridContractor[1, dataGridContractor.CurrentCell.RowIndex].Value.ToString();
            cont.maskedTextBox1.Text = dataGridContractor[3, dataGridContractor.CurrentCell.RowIndex].Value.ToString();
            cont.metroTextBoxAdres.Text = dataGridContractor[2, dataGridContractor.CurrentCell.RowIndex].Value.ToString();
            cont.ShowDialog();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить поставщика " + dataGridContractor[1, dataGridContractor.CurrentCell.RowIndex].Value.ToString() + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (db_.relations("prihod", "keyContractor", dataGridContractor[0, dataGridContractor.CurrentCell.RowIndex].Value.ToString()))
                {
                    db_.HandbookDel("contractor", "nameContractor", "'" + dataGridContractor[1, dataGridContractor.CurrentCell.RowIndex].Value.ToString() + "'");
                    getContraktor();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PriseListAdd add = new PriseListAdd();
            add.FormClosing += new FormClosingEventHandler(PriseListGet);
            add.ShowDialog();

        }
        public void PriseListGet(object sendber, FormClosingEventArgs e)
        {
            getPriseList();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите удалить цену созданную " + dataGridPrise[1, dataGridPrise.CurrentCell.RowIndex].Value.ToString() + " ?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (db_.relations("checklist", "keyPriseLost", dataGridPrise[0, dataGridPrise.CurrentCell.RowIndex].Value.ToString()))
                {
                    db_.HandbookDel("priselost", "keyPriseLost", dataGridPrise[0, dataGridPrise.CurrentCell.RowIndex].Value.ToString());
                    getPriseList();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridContractor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
