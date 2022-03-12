namespace magezine
{
    partial class Kassir
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameTov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edIzmeren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзАкаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTextPoisk = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameTov,
            this.categorit,
            this.edIzmeren,
            this.kolvo,
            this.cena});
            this.dataGridView1.Location = new System.Drawing.Point(23, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameTov
            // 
            this.nameTov.DataPropertyName = "nameTovar";
            this.nameTov.HeaderText = "Название товара";
            this.nameTov.Name = "nameTov";
            this.nameTov.ReadOnly = true;
            // 
            // categorit
            // 
            this.categorit.DataPropertyName = "CategoryTov";
            this.categorit.HeaderText = "Категория товара";
            this.categorit.Name = "categorit";
            this.categorit.ReadOnly = true;
            // 
            // edIzmeren
            // 
            this.edIzmeren.DataPropertyName = "EdIzmeren";
            this.edIzmeren.HeaderText = "Единица измерения";
            this.edIzmeren.Name = "edIzmeren";
            this.edIzmeren.ReadOnly = true;
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(506, 116);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 26);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Новый  чек";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзАкаунтаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходИзАкаунтаToolStripMenuItem
            // 
            this.выходИзАкаунтаToolStripMenuItem.Name = "выходИзАкаунтаToolStripMenuItem";
            this.выходИзАкаунтаToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.выходИзАкаунтаToolStripMenuItem.Text = "Выход из акаунта";
            this.выходИзАкаунтаToolStripMenuItem.Click += new System.EventHandler(this.выходИзАкаунтаToolStripMenuItem_Click);
            // 
            // metroTextPoisk
            // 
            this.metroTextPoisk.CustomBackground = true;
            this.metroTextPoisk.CustomForeColor = true;
            this.metroTextPoisk.Location = new System.Drawing.Point(187, 119);
            this.metroTextPoisk.Name = "metroTextPoisk";
            this.metroTextPoisk.Size = new System.Drawing.Size(190, 23);
            this.metroTextPoisk.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextPoisk.TabIndex = 3;
            this.metroTextPoisk.UseStyleColors = true;
            this.metroTextPoisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextPoisk_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Поиск товара на складе:";
            // 
            // Kassir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 424);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextPoisk);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Kassir";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Кассир";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kassir_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзАкаунтаToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox metroTextPoisk;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTov;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorit;
        private System.Windows.Forms.DataGridViewTextBoxColumn edIzmeren;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
    }
}