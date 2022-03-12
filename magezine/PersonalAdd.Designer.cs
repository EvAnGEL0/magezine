namespace magezine
{
    partial class PersonalAdd
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroName = new MetroFramework.Controls.MetroTextBox();
            this.metroPatronymic = new MetroFramework.Controls.MetroTextBox();
            this.metroLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroPasswd = new MetroFramework.Controls.MetroTextBox();
            this.metroDolzn = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Фамилия";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Имя";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 177);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Отчество";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 310);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Пароль";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(41, 267);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Логин";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(41, 222);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Должность";
            // 
            // metroSurname
            // 
            this.metroSurname.Location = new System.Drawing.Point(43, 110);
            this.metroSurname.Name = "metroSurname";
            this.metroSurname.Size = new System.Drawing.Size(268, 23);
            this.metroSurname.TabIndex = 6;
            // 
            // metroName
            // 
            this.metroName.Location = new System.Drawing.Point(43, 153);
            this.metroName.Name = "metroName";
            this.metroName.Size = new System.Drawing.Size(268, 23);
            this.metroName.TabIndex = 7;
            // 
            // metroPatronymic
            // 
            this.metroPatronymic.Location = new System.Drawing.Point(43, 196);
            this.metroPatronymic.Name = "metroPatronymic";
            this.metroPatronymic.Size = new System.Drawing.Size(268, 23);
            this.metroPatronymic.TabIndex = 8;
            // 
            // metroLogin
            // 
            this.metroLogin.Location = new System.Drawing.Point(43, 285);
            this.metroLogin.Name = "metroLogin";
            this.metroLogin.Size = new System.Drawing.Size(268, 23);
            this.metroLogin.TabIndex = 9;
            // 
            // metroPasswd
            // 
            this.metroPasswd.Location = new System.Drawing.Point(43, 330);
            this.metroPasswd.Name = "metroPasswd";
            this.metroPasswd.PasswordChar = '*';
            this.metroPasswd.Size = new System.Drawing.Size(268, 23);
            this.metroPasswd.TabIndex = 10;
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
            this.metroDolzn.Location = new System.Drawing.Point(43, 244);
            this.metroDolzn.Name = "metroDolzn";
            this.metroDolzn.Size = new System.Drawing.Size(268, 25);
            this.metroDolzn.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroDolzn.TabIndex = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(236, 380);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(43, 380);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Закрыть";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // PersonalAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(360, 419);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroDolzn);
            this.Controls.Add(this.metroPasswd);
            this.Controls.Add(this.metroLogin);
            this.Controls.Add(this.metroPatronymic);
            this.Controls.Add(this.metroName);
            this.Controls.Add(this.metroSurname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "PersonalAdd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Новый работник";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.PersonalAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroSurname;
        private MetroFramework.Controls.MetroTextBox metroName;
        private MetroFramework.Controls.MetroTextBox metroPatronymic;
        private MetroFramework.Controls.MetroTextBox metroLogin;
        private MetroFramework.Controls.MetroTextBox metroPasswd;
        private MetroFramework.Controls.MetroComboBox metroDolzn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}