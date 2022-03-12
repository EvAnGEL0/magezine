namespace magezine
{
    partial class ChekAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.keyChek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxColum = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonDel = new MetroFramework.Controls.MetroButton();
            this.metroLabeItoge = new MetroFramework.Controls.MetroLabel();
            this.metroButtonChec = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyChek,
            this.nameTov,
            this.kolvo,
            this.cena});
            this.dataGridView.Location = new System.Drawing.Point(23, 176);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(500, 178);
            this.dataGridView.TabIndex = 1;
            // 
            // keyChek
            // 
            this.keyChek.DataPropertyName = "keyCheckList";
            this.keyChek.HeaderText = "код";
            this.keyChek.Name = "keyChek";
            this.keyChek.ReadOnly = true;
            this.keyChek.Visible = false;
            // 
            // nameTov
            // 
            this.nameTov.DataPropertyName = "nameTovar";
            this.nameTov.HeaderText = "Наименование товара";
            this.nameTov.Name = "nameTov";
            this.nameTov.ReadOnly = true;
            // 
            // kolvo
            // 
            this.kolvo.DataPropertyName = "kolvo";
            this.kolvo.HeaderText = "Количество";
            this.kolvo.Name = "kolvo";
            this.kolvo.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.DataPropertyName = "cena";
            this.cena.HeaderText = "Цена";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Товар";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(237, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Количество";
            // 
            // metroComboBox
            // 
            this.metroComboBox.FormattingEnabled = true;
            this.metroComboBox.ItemHeight = 23;
            this.metroComboBox.Location = new System.Drawing.Point(23, 130);
            this.metroComboBox.Name = "metroComboBox";
            this.metroComboBox.Size = new System.Drawing.Size(190, 29);
            this.metroComboBox.TabIndex = 4;
            // 
            // metroTextBoxColum
            // 
            this.metroTextBoxColum.Location = new System.Drawing.Point(237, 136);
            this.metroTextBoxColum.MaxLength = 9;
            this.metroTextBoxColum.Name = "metroTextBoxColum";
            this.metroTextBoxColum.Size = new System.Drawing.Size(115, 23);
            this.metroTextBoxColum.TabIndex = 5;
            this.metroTextBoxColum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(423, 107);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAdd.TabIndex = 6;
            this.metroButtonAdd.Text = "Добавить";
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonDel
            // 
            this.metroButtonDel.Location = new System.Drawing.Point(423, 136);
            this.metroButtonDel.Name = "metroButtonDel";
            this.metroButtonDel.Size = new System.Drawing.Size(75, 23);
            this.metroButtonDel.TabIndex = 7;
            this.metroButtonDel.Text = "Удалить";
            this.metroButtonDel.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabeItoge
            // 
            this.metroLabeItoge.AutoSize = true;
            this.metroLabeItoge.Location = new System.Drawing.Point(320, 357);
            this.metroLabeItoge.Name = "metroLabeItoge";
            this.metroLabeItoge.Size = new System.Drawing.Size(46, 19);
            this.metroLabeItoge.TabIndex = 8;
            this.metroLabeItoge.Text = "Всего:";
            // 
            // metroButtonChec
            // 
            this.metroButtonChec.Location = new System.Drawing.Point(399, 56);
            this.metroButtonChec.Name = "metroButtonChec";
            this.metroButtonChec.Size = new System.Drawing.Size(99, 23);
            this.metroButtonChec.TabIndex = 9;
            this.metroButtonChec.Text = "Тооварный чек";
            this.metroButtonChec.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // ChekAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 411);
            this.Controls.Add(this.metroButtonChec);
            this.Controls.Add(this.metroLabeItoge);
            this.Controls.Add(this.metroButtonDel);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroTextBoxColum);
            this.Controls.Add(this.metroComboBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "ChekAdd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Новый чек";
            this.Load += new System.EventHandler(this.ChekAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox;
        private MetroFramework.Controls.MetroTextBox metroTextBoxColum;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonDel;
        private MetroFramework.Controls.MetroLabel metroLabeItoge;
        private MetroFramework.Controls.MetroButton metroButtonChec;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyChek;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTov;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
    }
}