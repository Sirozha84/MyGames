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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.linkSite = new System.Windows.Forms.LinkLabel();
            this.labelSite = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.tabHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Controls.Add(this.tabHistory);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 208);
            this.tabControl.TabIndex = 1;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.pictureLogo);
            this.tabAbout.Controls.Add(this.labelName);
            this.tabAbout.Controls.Add(this.labelVersion);
            this.tabAbout.Controls.Add(this.labelAutor);
            this.tabAbout.Controls.Add(this.labelSite);
            this.tabAbout.Controls.Add(this.linkSite);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(452, 182);
            this.tabAbout.TabIndex = 0;
            this.tabAbout.Text = "О программе";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // linkSite
            // 
            this.linkSite.AutoSize = true;
            this.linkSite.Location = new System.Drawing.Point(182, 144);
            this.linkSite.Name = "linkSite";
            this.linkSite.Size = new System.Drawing.Size(73, 13);
            this.linkSite.TabIndex = 6;
            this.linkSite.TabStop = true;
            this.linkSite.Text = "sg-software.ru";
            this.linkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GotoSite);
            // 
            // labelSite
            // 
            this.labelSite.Location = new System.Drawing.Point(182, 118);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(226, 30);
            this.labelSite.TabIndex = 5;
            this.labelSite.Text = "Новую версию этой и других моих программ Вы можете загрузить на сайте";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(182, 92);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(124, 13);
            this.labelAutor.TabIndex = 4;
            this.labelAutor.Text = "Автор: Сергей Гордеев";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(182, 67);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(44, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Версия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(180, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(115, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "My Games";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::My_Games.Properties.Resources.logo;
            this.pictureLogo.Location = new System.Drawing.Point(32, 32);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(128, 128);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.history);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(452, 182);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "История версий";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.Location = new System.Drawing.Point(3, 3);
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(446, 176);
            this.history.TabIndex = 0;
            this.history.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(397, 226);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.tabControl.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.tabHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkSite;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.RichTextBox history;
    }
}