namespace My_Games
{
    partial class FormDict
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listViewCat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(15, 16);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(200, 57);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "Добавить";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(227, 16);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(200, 57);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDel.Enabled = false;
            this.buttonDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDel.Location = new System.Drawing.Point(439, 16);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(200, 57);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(559, 656);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(200, 57);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // listViewCat
            // 
            this.listViewCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewCat.FullRowSelect = true;
            this.listViewCat.GridLines = true;
            this.listViewCat.Location = new System.Drawing.Point(15, 87);
            this.listViewCat.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listViewCat.MultiSelect = false;
            this.listViewCat.Name = "listViewCat";
            this.listViewCat.Size = new System.Drawing.Size(744, 555);
            this.listViewCat.TabIndex = 0;
            this.listViewCat.UseCompatibleStateImageBehavior = false;
            this.listViewCat.View = System.Windows.Forms.View.Details;
            this.listViewCat.SelectedIndexChanged += new System.EventHandler(this.listViewCat_SelectedIndexChanged);
            this.listViewCat.DoubleClick += new System.EventHandler(this.listViewCat_DoubleClick);
            this.listViewCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewCat_KeyDown);
            // 
            // FormDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.listViewCat);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FormDict";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListView listViewCat;
    }
}