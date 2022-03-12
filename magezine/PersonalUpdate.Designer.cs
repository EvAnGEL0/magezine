namespace magezine
{
    partial class PersonalUpdate
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
            this.metroDolzn = new MetroFramework.Controls.MetroComboBox();
            this.metroPatronymic = new MetroFramework.Controls.MetroTextBox();
            this.metroName = new MetroFramework.Controls.MetroTextBox();
            this.metroSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroDolzn
            // 
            this.metroDolzn.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroDolzn.FormattingEnabled = true;
            this.metroDolzn.ItemHeight = 19;
            this.metroDolzn.Items.AddRange(new object[] {
            "Директор",
            "Кассир",
            "Кладовщик "});
            this.metroDolzn.Location = new System.Drawing.Point(45, 242);
            this.metroDolzn.Name = "metroDolzn";
            this.metroDolzn.Size = new System.Drawing.Size(268, 25);
            this.metroDolzn.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDolzn.TabIndex = 19;
            // 
            // metroPatronymic
            // 
            this.metroPatronymic.Location = new System.Drawing.Point(45, 194);
            this.metroPatronymic.Name = "metroPatronymic";
            this.metroPatronymic.Size = new System.Drawing.Size(268, 23);
            this.metroPatronymic.TabIndex = 18;
            // 
            // metroName
            // 
            this.metroName.Location = new System.Drawing.Point(45, 151);
            this.metroName.Name = "metroName";
            this.metroName.Size = new System.Drawing.Size(268, 23);
            this.metroName.TabIndex = 17;
            // 
            // metroSurname
            // 
            this.metroSurname.Location = new System.Drawing.Point(45, 108);
            this.metroSurname.Name = "metroSurname";
            this.metroSurname.Size = new System.Drawing.Size(268, 23);
            this.metroSurname.TabIndex = 16;
            this.metroSurname.Text = " ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(43, 220);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Должность";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(45, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Отчество";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Имя";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Фамилия";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(45, 293);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Закрыть";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(238, 293);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Text = "Изменить";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // PersonalUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 335);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroDolzn);
            this.Controls.Add(this.metroPatronymic);
            this.Controls.Add(this.metroName);
            this.Controls.Add(this.metroSurname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "PersonalUpdate";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Редактирование профиля";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroComboBox metroDolzn;
        public MetroFramework.Controls.MetroTextBox metroPatronymic;
        public MetroFramework.Controls.MetroTextBox metroName;
        public MetroFramework.Controls.MetroTextBox metroSurname;
    }
}