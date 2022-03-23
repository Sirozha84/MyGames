namespace My_Games
{
    partial class FormFilter
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxPlatform = new System.Windows.Forms.CheckBox();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.comboBoxMedium = new System.Windows.Forms.ComboBox();
            this.checkBoxMedium = new System.Windows.Forms.CheckBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.checkBoxGenre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(425, 364);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 57);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(213, 364);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(200, 57);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxStart.Location = new System.Drawing.Point(37, 34);
            this.checkBoxStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(160, 49);
            this.checkBoxStart.TabIndex = 9;
            this.checkBoxStart.Text = "Дата от";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeStart.Location = new System.Drawing.Point(263, 30);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(360, 50);
            this.dateTimeStart.TabIndex = 10;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeEnd.Location = new System.Drawing.Point(263, 94);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(360, 50);
            this.dateTimeEnd.TabIndex = 12;
            this.dateTimeEnd.ValueChanged += new System.EventHandler(this.dateTimeEnd_ValueChanged);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEnd.Location = new System.Drawing.Point(37, 98);
            this.checkBoxEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(165, 49);
            this.checkBoxEnd.TabIndex = 11;
            this.checkBoxEnd.Text = "Дата до";
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlatform
            // 
            this.checkBoxPlatform.AutoSize = true;
            this.checkBoxPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPlatform.Location = new System.Drawing.Point(37, 160);
            this.checkBoxPlatform.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBoxPlatform.Name = "checkBoxPlatform";
            this.checkBoxPlatform.Size = new System.Drawing.Size(219, 49);
            this.checkBoxPlatform.TabIndex = 13;
            this.checkBoxPlatform.Text = "Платформа";
            this.checkBoxPlatform.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(263, 158);
            this.comboBoxPlatform.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(360, 53);
            this.comboBoxPlatform.TabIndex = 14;
            this.comboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlatform_SelectedIndexChanged);
            // 
            // comboBoxMedium
            // 
            this.comboBoxMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMedium.FormattingEnabled = true;
            this.comboBoxMedium.Location = new System.Drawing.Point(263, 225);
            this.comboBoxMedium.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxMedium.Name = "comboBoxMedium";
            this.comboBoxMedium.Size = new System.Drawing.Size(360, 53);
            this.comboBoxMedium.TabIndex = 16;
            this.comboBoxMedium.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedium_SelectedIndexChanged);
            // 
            // checkBoxMedium
            // 
            this.checkBoxMedium.AutoSize = true;
            this.checkBoxMedium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMedium.Location = new System.Drawing.Point(37, 227);
            this.checkBoxMedium.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBoxMedium.Name = "checkBoxMedium";
            this.checkBoxMedium.Size = new System.Drawing.Size(191, 49);
            this.checkBoxMedium.TabIndex = 15;
            this.checkBoxMedium.Text = "Носитель";
            this.checkBoxMedium.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(263, 292);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(360, 53);
            this.comboBoxGenre.TabIndex = 18;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // checkBoxGenre
            // 
            this.checkBoxGenre.AutoSize = true;
            this.checkBoxGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxGenre.Location = new System.Drawing.Point(37, 294);
            this.checkBoxGenre.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkBoxGenre.Name = "checkBoxGenre";
            this.checkBoxGenre.Size = new System.Drawing.Size(133, 49);
            this.checkBoxGenre.TabIndex = 17;
            this.checkBoxGenre.Text = "Жанр";
            this.checkBoxGenre.UseVisualStyleBackColor = true;
            // 
            // FormFilter
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(640, 437);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.checkBoxGenre);
            this.Controls.Add(this.comboBoxMedium);
            this.Controls.Add(this.checkBoxMedium);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.checkBoxPlatform);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.checkBoxEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.checkBoxStart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFilter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка фильтра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.CheckBox checkBoxEnd;
        private System.Windows.Forms.CheckBox checkBoxPlatform;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.ComboBox comboBoxMedium;
        private System.Windows.Forms.CheckBox checkBoxMedium;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.CheckBox checkBoxGenre;
    }
}