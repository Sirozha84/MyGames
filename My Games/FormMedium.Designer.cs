namespace My_Games
{
    partial class FormMedium
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonPh = new System.Windows.Forms.RadioButton();
            this.radioButtonEl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 99;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(116, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 98;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Наименование:";
            // 
            // radioButtonPh
            // 
            this.radioButtonPh.AutoSize = true;
            this.radioButtonPh.Location = new System.Drawing.Point(106, 38);
            this.radioButtonPh.Name = "radioButtonPh";
            this.radioButtonPh.Size = new System.Drawing.Size(139, 17);
            this.radioButtonPh.TabIndex = 100;
            this.radioButtonPh.TabStop = true;
            this.radioButtonPh.Text = "Физический носитель";
            this.radioButtonPh.UseVisualStyleBackColor = true;
            // 
            // radioButtonEl
            // 
            this.radioButtonEl.AutoSize = true;
            this.radioButtonEl.Location = new System.Drawing.Point(106, 61);
            this.radioButtonEl.Name = "radioButtonEl";
            this.radioButtonEl.Size = new System.Drawing.Size(139, 17);
            this.radioButtonEl.TabIndex = 101;
            this.radioButtonEl.TabStop = true;
            this.radioButtonEl.Text = "Электронный магазин";
            this.radioButtonEl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Тип носителя:";
            // 
            // radioButtonSb
            // 
            this.radioButtonSb.AutoSize = true;
            this.radioButtonSb.Location = new System.Drawing.Point(106, 84);
            this.radioButtonSb.Name = "radioButtonSb";
            this.radioButtonSb.Size = new System.Drawing.Size(75, 17);
            this.radioButtonSb.TabIndex = 103;
            this.radioButtonSb.TabStop = true;
            this.radioButtonSb.Text = "Подписка";
            this.radioButtonSb.UseVisualStyleBackColor = true;
            // 
            // FormMedium
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.radioButtonSb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonEl);
            this.Controls.Add(this.radioButtonPh);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "FormMedium";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Носитель / электронный магазин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonPh;
        private System.Windows.Forms.RadioButton radioButtonEl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSb;
    }
}