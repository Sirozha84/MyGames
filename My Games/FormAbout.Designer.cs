namespace My_Games
{
    partial class FormAbout
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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linлSite = new System.Windows.Forms.LinkLabel();
            this.labelNew = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::My_Games.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(69, 79);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(256, 256);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(15, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 526);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.linлSite);
            this.tabPageAbout.Controls.Add(this.labelNew);
            this.tabPageAbout.Controls.Add(this.labelAutor);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelName);
            this.tabPageAbout.Controls.Add(this.pictureLogo);
            this.tabPageAbout.Location = new System.Drawing.Point(8, 59);
            this.tabPageAbout.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageAbout.Size = new System.Drawing.Size(928, 459);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "   О программе   ";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // linлSite
            // 
            this.linлSite.AutoSize = true;
            this.linлSite.Location = new System.Drawing.Point(394, 365);
            this.linлSite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linлSite.Name = "linлSite";
            this.linлSite.Size = new System.Drawing.Size(299, 45);
            this.linлSite.TabIndex = 6;
            this.linлSite.TabStop = true;
            this.linлSite.Text = "www.sg-software.ru";
            this.linлSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // labelNew
            // 
            this.labelNew.Location = new System.Drawing.Point(394, 233);
            this.labelNew.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(490, 144);
            this.labelNew.TabIndex = 5;
            this.labelNew.Text = "Новую версию этой и других моих программ Вы можете загрузить на сайте";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(394, 166);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(360, 45);
            this.labelAutor.TabIndex = 4;
            this.labelAutor.Text = "Автор: Сергей Гордеев";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(394, 121);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(124, 45);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Версия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(394, 70);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(238, 51);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "My Games";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.history);
            this.tabPageHistory.Location = new System.Drawing.Point(8, 59);
            this.tabPageHistory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageHistory.Size = new System.Drawing.Size(928, 459);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "   История версий   ";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.history.Location = new System.Drawing.Point(6, 7);
            this.history.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(916, 445);
            this.history.TabIndex = 0;
            this.history.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(759, 556);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(200, 57);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(974, 629);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.tabPageHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linлSite;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.RichTextBox history;
    }
}