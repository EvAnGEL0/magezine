namespace magezine
{
    partial class СontractorAdd
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
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroTextName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTelephon = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAdres = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAdres = new MetroFramework.Controls.MetroTextBox();
            this.metroOff = new MetroFramework.Controls.MetroButton();
            this.metroOk = new MetroFramework.Controls.MetroButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.Location = new System.Drawing.Point(23, 75);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(174, 19);
            this.metroLabelName.TabIndex = 0;
            this.metroLabelName.Text = "Наименование поставзика";
            // 
            // metroTextName
            // 
            this.metroTextName.Location = new System.Drawing.Point(23, 97);
            this.metroTextName.Name = "metroTextName";
            this.metroTextName.Size = new System.Drawing.Size(314, 23);
            this.metroTextName.TabIndex = 1;
            // 
            // metroLabelTelephon
            // 
            this.metroLabelTelephon.AutoSize = true;
            this.metroLabelTelephon.Location = new System.Drawing.Point(23, 123);
            this.metroLabelTelephon.Name = "metroLabelTelephon";
            this.metroLabelTelephon.Size = new System.Drawing.Size(62, 19);
            this.metroLabelTelephon.TabIndex = 2;
            this.metroLabelTelephon.Text = "Телефон";
            // 
            // metroLabelAdres
            // 
            this.metroLabelAdres.AutoSize = true;
            this.metroLabelAdres.Location = new System.Drawing.Point(23, 171);
            this.metroLabelAdres.Name = "metroLabelAdres";
            this.metroLabelAdres.Size = new System.Drawing.Size(46, 19);
            this.metroLabelAdres.TabIndex = 4;
            this.metroLabelAdres.Text = "Адрес";
            // 
            // metroTextBoxAdres
            // 
            this.metroTextBoxAdres.Location = new System.Drawing.Point(23, 193);
            this.metroTextBoxAdres.Name = "metroTextBoxAdres";
            this.metroTextBoxAdres.Size = new System.Drawing.Size(314, 23);
            this.metroTextBoxAdres.TabIndex = 5;
            // 
            // metroOff
            // 
            this.metroOff.Location = new System.Drawing.Point(23, 232);
            this.metroOff.Name = "metroOff";
            this.metroOff.Size = new System.Drawing.Size(75, 23);
            this.metroOff.TabIndex = 6;
            this.metroOff.Text = "Закрыть";
            this.metroOff.Click += new System.EventHandler(this.metroOff_Click);
            // 
            // metroOk
            // 
            this.metroOk.Location = new System.Drawing.Point(262, 232);
            this.metroOk.Name = "metroOk";
            this.metroOk.Size = new System.Drawing.Size(75, 23);
            this.metroOk.TabIndex = 7;
            this.metroOk.Text = "Добавить";
            this.metroOk.Click += new System.EventHandler(this.metroOk_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 145);
            this.maskedTextBox1.Mask = "+9(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(314, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // СontractorAdd
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
            this.Name = "СontractorAdd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Новый поставщик";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroTextBox metroTextName;
        private MetroFramework.Controls.MetroLabel metroLabelTelephon;
        private MetroFramework.Controls.MetroLabel metroLabelAdres;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdres;
        private MetroFramework.Controls.MetroButton metroOff;
        private MetroFramework.Controls.MetroButton metroOk;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}