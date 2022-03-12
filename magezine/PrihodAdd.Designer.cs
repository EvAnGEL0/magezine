namespace magezine
{
    partial class PrihodAdd
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
            this.groupPrihod = new System.Windows.Forms.GroupBox();
            this.metroClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPostavshik = new MetroFramework.Controls.MetroLabel();
            this.metroBNext = new MetroFramework.Controls.MetroButton();
            this.metronum = new MetroFramework.Controls.MetroLabel();
            this.metroTextNum = new MetroFramework.Controls.MetroTextBox();
            this.datePrihod = new System.Windows.Forms.DateTimePicker();
            this.metroComboContraktor = new MetroFramework.Controls.MetroComboBox();
            this.groupPriseList = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButtonNewTow = new MetroFramework.Controls.MetroButton();
            this.metroButtonSave = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridVPrihodList = new System.Windows.Forms.DataGridView();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextCena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelCena = new MetroFramework.Controls.MetroLabel();
            this.metroTextKol_vo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelKol_vo = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTov = new MetroFramework.Controls.MetroLabel();
            this.metroComboTov = new MetroFramework.Controls.MetroComboBox();
            this.groupPrihod.SuspendLayout();
            this.groupPriseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVPrihodList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPrihod
            // 
            this.groupPrihod.Controls.Add(this.metroClose);
            this.groupPrihod.Controls.Add(this.metroLabel1);
            this.groupPrihod.Controls.Add(this.metroPostavshik);
            this.groupPrihod.Controls.Add(this.metroBNext);
            this.groupPrihod.Controls.Add(this.metronum);
            this.groupPrihod.Controls.Add(this.metroTextNum);
            this.groupPrihod.Controls.Add(this.datePrihod);
            this.groupPrihod.Controls.Add(this.metroComboContraktor);
            this.groupPrihod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPrihod.Location = new System.Drawing.Point(20, 60);
            this.groupPrihod.Name = "groupPrihod";
            this.groupPrihod.Size = new System.Drawing.Size(539, 370);
            this.groupPrihod.TabIndex = 0;
            this.groupPrihod.TabStop = false;
            // 
            // metroClose
            // 
            this.metroClose.Location = new System.Drawing.Point(374, 328);
            this.metroClose.Name = "metroClose";
            this.metroClose.Size = new System.Drawing.Size(75, 23);
            this.metroClose.TabIndex = 7;
            this.metroClose.Text = "Закрыть";
            this.metroClose.Click += new System.EventHandler(this.metroClose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(89, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Дата поставки:";
            // 
            // metroPostavshik
            // 
            this.metroPostavshik.AutoSize = true;
            this.metroPostavshik.Location = new System.Drawing.Point(109, 103);
            this.metroPostavshik.Name = "metroPostavshik";
            this.metroPostavshik.Size = new System.Drawing.Size(80, 19);
            this.metroPostavshik.TabIndex = 5;
            this.metroPostavshik.Text = "Поставщик:";
            // 
            // metroBNext
            // 
            this.metroBNext.Location = new System.Drawing.Point(455, 328);
            this.metroBNext.Name = "metroBNext";
            this.metroBNext.Size = new System.Drawing.Size(75, 23);
            this.metroBNext.TabIndex = 4;
            this.metroBNext.Text = "Далее";
            this.metroBNext.Click += new System.EventHandler(this.metroBNext_Click);
            // 
            // metronum
            // 
            this.metronum.AutoSize = true;
            this.metronum.Location = new System.Drawing.Point(20, 50);
            this.metronum.Name = "metronum";
            this.metronum.Size = new System.Drawing.Size(168, 19);
            this.metronum.TabIndex = 3;
            this.metronum.Text = "Номер приходного листа:";
            // 
            // metroTextNum
            // 
            this.metroTextNum.CustomBackground = true;
            this.metroTextNum.CustomForeColor = true;
            this.metroTextNum.Location = new System.Drawing.Point(207, 50);
            this.metroTextNum.MaxLength = 12;
            this.metroTextNum.Name = "metroTextNum";
            this.metroTextNum.Size = new System.Drawing.Size(307, 23);
            this.metroTextNum.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextNum.TabIndex = 2;
            this.metroTextNum.UseStyleColors = true;
            this.metroTextNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextNum_KeyPress);
            // 
            // datePrihod
            // 
            this.datePrihod.Location = new System.Drawing.Point(207, 153);
            this.datePrihod.Name = "datePrihod";
            this.datePrihod.Size = new System.Drawing.Size(118, 20);
            this.datePrihod.TabIndex = 1;
            // 
            // metroComboContraktor
            // 
            this.metroComboContraktor.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboContraktor.FormattingEnabled = true;
            this.metroComboContraktor.ItemHeight = 19;
            this.metroComboContraktor.Location = new System.Drawing.Point(207, 103);
            this.metroComboContraktor.Name = "metroComboContraktor";
            this.metroComboContraktor.Size = new System.Drawing.Size(307, 25);
            this.metroComboContraktor.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboContraktor.TabIndex = 0;
            // 
            // groupPriseList
            // 
            this.groupPriseList.Controls.Add(this.metroButton1);
            this.groupPriseList.Controls.Add(this.metroButtonNewTow);
            this.groupPriseList.Controls.Add(this.metroButtonSave);
            this.groupPriseList.Controls.Add(this.metroButtonAdd);
            this.groupPriseList.Controls.Add(this.dataGridVPrihodList);
            this.groupPriseList.Controls.Add(this.metroTextCena);
            this.groupPriseList.Controls.Add(this.metroLabelCena);
            this.groupPriseList.Controls.Add(this.metroTextKol_vo);
            this.groupPriseList.Controls.Add(this.metroLabelKol_vo);
            this.groupPriseList.Controls.Add(this.metroLabelTov);
            this.groupPriseList.Controls.Add(this.metroComboTov);
            this.groupPriseList.Location = new System.Drawing.Point(415, 41);
            this.groupPriseList.Name = "groupPriseList";
            this.groupPriseList.Size = new System.Drawing.Size(538, 370);
            this.groupPriseList.TabIndex = 1;
            this.groupPriseList.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(341, 127);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Удалить";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButtonNewTow
            // 
            this.metroButtonNewTow.Location = new System.Drawing.Point(315, 40);
            this.metroButtonNewTow.Name = "metroButtonNewTow";
            this.metroButtonNewTow.Size = new System.Drawing.Size(101, 23);
            this.metroButtonNewTow.TabIndex = 11;
            this.metroButtonNewTow.Text = "Новый товар";
            this.metroButtonNewTow.Click += new System.EventHandler(this.metroButtonNewTow_Click);
            // 
            // metroButtonSave
            // 
            this.metroButtonSave.Location = new System.Drawing.Point(374, 341);
            this.metroButtonSave.Name = "metroButtonSave";
            this.metroButtonSave.Size = new System.Drawing.Size(156, 23);
            this.metroButtonSave.TabIndex = 10;
            this.metroButtonSave.Text = "Закрыть";
            this.metroButtonSave.Click += new System.EventHandler(this.metroButtonSave_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(341, 98);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAdd.TabIndex = 7;
            this.metroButtonAdd.Text = "Добавить";
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // dataGridVPrihodList
            // 
            this.dataGridVPrihodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVPrihodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.nametov,
            this.kolvo,
            this.cen});
            this.dataGridVPrihodList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridVPrihodList.Location = new System.Drawing.Point(3, 164);
            this.dataGridVPrihodList.Name = "dataGridVPrihodList";
            this.dataGridVPrihodList.ReadOnly = true;
            this.dataGridVPrihodList.Size = new System.Drawing.Size(532, 203);
            this.dataGridVPrihodList.TabIndex = 6;
            // 
            // key
            // 
            this.key.DataPropertyName = "keyPrihodList";
            this.key.HeaderText = "код";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Visible = false;
            // 
            // nametov
            // 
            this.nametov.DataPropertyName = "nameTovar";
            this.nametov.HeaderText = "Наименование товара";
            this.nametov.Name = "nametov";
            this.nametov.ReadOnly = true;
            // 
            // kolvo
            // 
            this.kolvo.DataPropertyName = "kolvo";
            this.kolvo.HeaderText = "Количество";
            this.kolvo.Name = "kolvo";
            this.kolvo.ReadOnly = true;
            // 
            // cen
            // 
            this.cen.DataPropertyName = "cena";
            this.cen.HeaderText = "Цена";
            this.cen.Name = "cen";
            this.cen.ReadOnly = true;
            // 
            // metroTextCena
            // 
            this.metroTextCena.Location = new System.Drawing.Point(123, 120);
            this.metroTextCena.Name = "metroTextCena";
            this.metroTextCena.Size = new System.Drawing.Size(186, 23);
            this.metroTextCena.TabIndex = 5;
            // 
            // metroLabelCena
            // 
            this.metroLabelCena.AutoSize = true;
            this.metroLabelCena.Location = new System.Drawing.Point(6, 120);
            this.metroLabelCena.Name = "metroLabelCena";
            this.metroLabelCena.Size = new System.Drawing.Size(117, 19);
            this.metroLabelCena.TabIndex = 4;
            this.metroLabelCena.Text = "Цена за шт. (руб.)";
            // 
            // metroTextKol_vo
            // 
            this.metroTextKol_vo.CustomBackground = true;
            this.metroTextKol_vo.CustomForeColor = true;
            this.metroTextKol_vo.Location = new System.Drawing.Point(123, 81);
            this.metroTextKol_vo.MaxLength = 9;
            this.metroTextKol_vo.Name = "metroTextKol_vo";
            this.metroTextKol_vo.Size = new System.Drawing.Size(186, 23);
            this.metroTextKol_vo.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextKol_vo.TabIndex = 3;
            this.metroTextKol_vo.UseStyleColors = true;
            // 
            // metroLabelKol_vo
            // 
            this.metroLabelKol_vo.AutoSize = true;
            this.metroLabelKol_vo.Location = new System.Drawing.Point(38, 81);
            this.metroLabelKol_vo.Name = "metroLabelKol_vo";
            this.metroLabelKol_vo.Size = new System.Drawing.Size(85, 19);
            this.metroLabelKol_vo.TabIndex = 2;
            this.metroLabelKol_vo.Text = "Кольичество";
            this.metroLabelKol_vo.Click += new System.EventHandler(this.metroLabelKol_vo_Click);
            // 
            // metroLabelTov
            // 
            this.metroLabelTov.AutoSize = true;
            this.metroLabelTov.Location = new System.Drawing.Point(77, 40);
            this.metroLabelTov.Name = "metroLabelTov";
            this.metroLabelTov.Size = new System.Drawing.Size(46, 19);
            this.metroLabelTov.TabIndex = 1;
            this.metroLabelTov.Text = "Товар";
            // 
            // metroComboTov
            // 
            this.metroComboTov.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboTov.FormattingEnabled = true;
            this.metroComboTov.ItemHeight = 19;
            this.metroComboTov.Location = new System.Drawing.Point(123, 40);
            this.metroComboTov.Name = "metroComboTov";
            this.metroComboTov.Size = new System.Drawing.Size(186, 25);
            this.metroComboTov.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboTov.TabIndex = 0;
            // 
            // PrihodAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.groupPriseList);
            this.Controls.Add(this.groupPrihod);
            this.MaximizeBox = false;
            this.Name = "PrihodAdd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Новая поставка";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.PrihodAdd_Load);
            this.groupPrihod.ResumeLayout(false);
            this.groupPrihod.PerformLayout();
            this.groupPriseList.ResumeLayout(false);
            this.groupPriseList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVPrihodList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPrihod;
        private MetroFramework.Controls.MetroTextBox metroTextNum;
        private System.Windows.Forms.DateTimePicker datePrihod;
        private MetroFramework.Controls.MetroComboBox metroComboContraktor;
        private MetroFramework.Controls.MetroLabel metronum;
        private MetroFramework.Controls.MetroButton metroBNext;
        private MetroFramework.Controls.MetroLabel metroPostavshik;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroClose;
        private System.Windows.Forms.GroupBox groupPriseList;
        private MetroFramework.Controls.MetroLabel metroLabelTov;
        private MetroFramework.Controls.MetroComboBox metroComboTov;
        private MetroFramework.Controls.MetroTextBox metroTextKol_vo;
        private MetroFramework.Controls.MetroLabel metroLabelKol_vo;
        private MetroFramework.Controls.MetroTextBox metroTextCena;
        private MetroFramework.Controls.MetroLabel metroLabelCena;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private System.Windows.Forms.DataGridView dataGridVPrihodList;
        private MetroFramework.Controls.MetroButton metroButtonSave;
        private MetroFramework.Controls.MetroButton metroButtonNewTow;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametov;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cen;
    }
}