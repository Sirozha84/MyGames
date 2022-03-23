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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(286, 34);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(360, 50);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(459, 366);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 57);
            this.buttonCancel.TabIndex = 99;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(247, 366);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(200, 57);
            this.buttonOK.TabIndex = 98;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 45);
            this.label4.TabIndex = 17;
            this.label4.Text = "Наименование:";
            // 
            // radioButtonPh
            // 
            this.radioButtonPh.AutoSize = true;
            this.radioButtonPh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPh.Location = new System.Drawing.Point(286, 98);
            this.radioButtonPh.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonPh.Name = "radioButtonPh";
            this.radioButtonPh.Size = new System.Drawing.Size(373, 49);
            this.radioButtonPh.TabIndex = 100;
            this.radioButtonPh.TabStop = true;
            this.radioButtonPh.Text = "Физический носитель";
            this.radioButtonPh.UseVisualStyleBackColor = true;
            // 
            // radioButtonEl
            // 
            this.radioButtonEl.AutoSize = true;
            this.radioButtonEl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonEl.Location = new System.Drawing.Point(283, 161);
            this.radioButtonEl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonEl.Name = "radioButtonEl";
            this.radioButtonEl.Size = new System.Drawing.Size(376, 49);
            this.radioButtonEl.TabIndex = 101;
            this.radioButtonEl.TabStop = true;
            this.radioButtonEl.Text = "Электронный магазин";
            this.radioButtonEl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 45);
            this.label1.TabIndex = 102;
            this.label1.Text = "Тип носителя:";
            // 
            // radioButtonSb
            // 
            this.radioButtonSb.AutoSize = true;
            this.radioButtonSb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSb.Location = new System.Drawing.Point(283, 224);
            this.radioButtonSb.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonSb.Name = "radioButtonSb";
            this.radioButtonSb.Size = new System.Drawing.Size(195, 49);
            this.radioButtonSb.TabIndex = 103;
            this.radioButtonSb.TabStop = true;
            this.radioButtonSb.Text = "Подписка";
            this.radioButtonSb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 45);
            this.label3.TabIndex = 105;
            this.label3.Text = "Цвет:";
            // 
            // buttonCol
            // 
            this.buttonCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCol.Location = new System.Drawing.Point(286, 287);
            this.buttonCol.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonCol.Name = "buttonCol";
            this.buttonCol.Size = new System.Drawing.Size(50, 50);
            this.buttonCol.TabIndex = 104;
            this.buttonCol.UseVisualStyleBackColor = true;
            this.buttonCol.Click += new System.EventHandler(this.buttonCol_Click);
            // 
            // FormMedium
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(674, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCol);
            this.Controls.Add(this.radioButtonSb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonEl);
            this.Controls.Add(this.radioButtonPh);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 510);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCol;
    }
}