namespace magezine
{
    partial class ContraktorUpdate
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.metroOk = new MetroFramework.Controls.MetroButton();
            this.metroOff = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxAdres = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelAdres = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTelephon = new MetroFramework.Controls.MetroLabel();
            this.metroTextName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 144);
            this.maskedTextBox1.Mask = "+9(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(314, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // metroOk
            // 
            this.metroOk.Location = new System.Drawing.Point(262, 231);
            this.metroOk.Name = "metroOk";
            this.metroOk.Size = new System.Drawing.Size(75, 23);
            this.metroOk.TabIndex = 15;
            this.metroOk.Text = "Изменить";
            this.metroOk.Click += new System.EventHandler(this.metroOk_Click);
            // 
            // metroOff
            // 
            this.metroOff.Location = new System.Drawing.Point(23, 231);
            this.metroOff.Name = "metroOff";
            this.metroOff.Size = new System.Drawing.Size(75, 23);
            this.metroOff.TabIndex = 14;
            this.metroOff.Text = "Закрыть";
            this.metroOff.Click += new System.EventHandler(this.metroOff_Click);
            // 
            // metroTextBoxAdres
            // 
            this.metroTextBoxAdres.Location = new System.Drawing.Point(23, 192);
            this.metroTextBoxAdres.Name = "metroTextBoxAdres";
            this.metroTextBoxAdres.Size = new System.Drawing.Size(314, 23);
            this.metroTextBoxAdres.TabIndex = 13;
            // 
            // metroLabelAdres
            // 
            this.metroLabelAdres.AutoSize = true;
            this.metroLabelAdres.Location = new System.Drawing.Point(23, 170);
            this.metroLabelAdres.Name = "metroLabelAdres";
            this.metroLabelAdres.Size = new System.Drawing.Size(46, 19);
            this.metroLabelAdres.TabIndex = 12;
            this.metroLabelAdres.Text = "Адрес";
            // 
            // metroLabelTelephon
            // 
            this.metroLabelTelephon.AutoSize = true;
            this.metroLabelTelephon.Location = new System.Drawing.Point(23, 122);
            this.metroLabelTelephon.Name = "metroLabelTelephon";
            this.metroLabelTelephon.Size = new System.Drawing.Size(62, 19);
            this.metroLabelTelephon.TabIndex = 11;
            this.metroLabelTelephon.Text = "Телефон";
            // 
            // metroTextName
            // 
            this.metroTextName.Location = new System.Drawing.Point(23, 96);
            this.metroTextName.Name = "metroTextName";
            this.metroTextName.Size = new System.Drawing.Size(314, 23);
            this.metroTextName.TabIndex = 10;
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(23, 74);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(179, 19);
            this.metroLabelName.TabIndex = 9;
            this.metroLabelName.Text = "Наименование поставщика";
            // 
            // ContraktorUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.metroOk);
            this.Controls.Add(this.metroOff);
            this.Controls.Add(this.metroTextBoxAdres);
            this.Controls.Add(this.metroLabelAdres);
            this.Controls.Add(this.metroLabelTelephon);
            this.Controls.Add(this.metroTextName);
            this.Controls.Add(this.metroLabelName);
            this.MaximizeBox = false;
            this.Name = "ContraktorUpdate";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Редактирование";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroOk;
        private MetroFramework.Controls.MetroButton metroOff;
        private MetroFramework.Controls.MetroLabel metroLabelAdres;
        private MetroFramework.Controls.MetroLabel metroLabelTelephon;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public MetroFramework.Controls.MetroTextBox metroTextBoxAdres;
        public MetroFramework.Controls.MetroTextBox metroTextName;
    }
}