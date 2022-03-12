namespace magezine
{
    partial class StoreAdd
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
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextname = new MetroFramework.Controls.MetroTextBox();
            this.metroTextKol_vo = new MetroFramework.Controls.MetroTextBox();
            this.metroComboCategor = new MetroFramework.Controls.MetroComboBox();
            this.metroComboEden = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(262, 317);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.metroButtonAdd.TabIndex = 0;
            this.metroButtonAdd.Text = "Добавить";
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroButtonClose
            // 
            this.metroButtonClose.Location = new System.Drawing.Point(23, 317);
            this.metroButtonClose.Name = "metroButtonClose";
            this.metroButtonClose.Size = new System.Drawing.Size(75, 23);
            this.metroButtonClose.TabIndex = 1;
            this.metroButtonClose.Text = "Закрыть";
            this.metroButtonClose.Click += new System.EventHandler(this.metroButtonClose_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Название товара";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(134, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Единица измерения";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(117, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Категория товара";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 239);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Количество товара";
            // 
            // metroTextname
            // 
            this.metroTextname.CustomBackground = true;
            this.metroTextname.CustomForeColor = true;
            this.metroTextname.Location = new System.Drawing.Point(23, 105);
            this.metroTextname.Name = "metroTextname";
            this.metroTextname.Size = new System.Drawing.Size(314, 23);
            this.metroTextname.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextname.TabIndex = 6;
            this.metroTextname.UseStyleColors = true;
            // 
            // metroTextKol_vo
            // 
            this.metroTextKol_vo.CustomBackground = true;
            this.metroTextKol_vo.CustomForeColor = true;
            this.metroTextKol_vo.Location = new System.Drawing.Point(23, 268);
            this.metroTextKol_vo.MaxLength = 9;
            this.metroTextKol_vo.Name = "metroTextKol_vo";
            this.metroTextKol_vo.Size = new System.Drawing.Size(314, 23);
            this.metroTextKol_vo.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextKol_vo.TabIndex = 7;
            this.metroTextKol_vo.UseStyleColors = true;
            this.metroTextKol_vo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextKol_vo_KeyPress);
            // 
            // metroComboCategor
            // 
            this.metroComboCategor.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboCategor.FormattingEnabled = true;
            this.metroComboCategor.ItemHeight = 19;
            this.metroComboCategor.Location = new System.Drawing.Point(23, 207);
            this.metroComboCategor.Name = "metroComboCategor";
            this.metroComboCategor.Size = new System.Drawing.Size(314, 25);
            this.metroComboCategor.TabIndex = 9;
            // 
            // metroComboEden
            // 
            this.metroComboEden.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboEden.FormattingEnabled = true;
            this.metroComboEden.ItemHeight = 19;
            this.metroComboEden.Location = new System.Drawing.Point(23, 157);
            this.metroComboEden.Name = "metroComboEden";
            this.metroComboEden.Size = new System.Drawing.Size(314, 25);
            this.metroComboEden.TabIndex = 10;
            // 
            // StoreAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 350);
            this.Controls.Add(this.metroComboEden);
            this.Controls.Add(this.metroComboCategor);
            this.Controls.Add(this.metroTextKol_vo);
            this.Controls.Add(this.metroTextname);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonClose);
            this.Controls.Add(this.metroButtonAdd);
            this.MaximizeBox = false;
            this.Name = "StoreAdd";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Новый товар";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Store_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroButton metroButtonClose;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextname;
        private MetroFramework.Controls.MetroTextBox metroTextKol_vo;
        private MetroFramework.Controls.MetroComboBox metroComboCategor;
        private MetroFramework.Controls.MetroComboBox metroComboEden;
    }
}