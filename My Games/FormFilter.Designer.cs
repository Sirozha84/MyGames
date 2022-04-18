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
            this.buttonCancel.Location = new System.Drawing.Point(173, 154);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(92, 154);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(17, 14);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(66, 17);
            this.checkBoxStart.TabIndex = 9;
            this.checkBoxStart.Text = "Дата от";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(108, 12);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(140, 20);
            this.dateTimeStart.TabIndex = 10;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(108, 38);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(140, 20);
            this.dateTimeEnd.TabIndex = 12;
            this.dateTimeEnd.ValueChanged += new System.EventHandler(this.dateTimeEnd_ValueChanged);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Location = new System.Drawing.Point(17, 40);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(67, 17);
            this.checkBoxEnd.TabIndex = 11;
            this.checkBoxEnd.Text = "Дата до";
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlatform
            // 
            this.checkBoxPlatform.AutoSize = true;
            this.checkBoxPlatform.Location = new System.Drawing.Point(17, 66);
            this.checkBoxPlatform.Name = "checkBoxPlatform";
            this.checkBoxPlatform.Size = new System.Drawing.Size(85, 17);
            this.checkBoxPlatform.TabIndex = 13;
            this.checkBoxPlatform.Text = "Платформа";
            this.checkBoxPlatform.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(108, 64);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPlatform.TabIndex = 14;
            this.comboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlatform_SelectedIndexChanged);
            // 
            // comboBoxMedium
            // 
            this.comboBoxMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedium.FormattingEnabled = true;
            this.comboBoxMedium.Location = new System.Drawing.Point(108, 91);
            this.comboBoxMedium.Name = "comboBoxMedium";
            this.comboBoxMedium.Size = new System.Drawing.Size(140, 21);
            this.comboBoxMedium.TabIndex = 16;
            this.comboBoxMedium.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedium_SelectedIndexChanged);
            // 
            // checkBoxMedium
            // 
            this.checkBoxMedium.AutoSize = true;
            this.checkBoxMedium.Location = new System.Drawing.Point(17, 93);
            this.checkBoxMedium.Name = "checkBoxMedium";
            this.checkBoxMedium.Size = new System.Drawing.Size(75, 17);
            this.checkBoxMedium.TabIndex = 15;
            this.checkBoxMedium.Text = "Носитель";
            this.checkBoxMedium.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(108, 118);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(140, 21);
            this.comboBoxGenre.TabIndex = 18;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // checkBoxGenre
            // 
            this.checkBoxGenre.AutoSize = true;
            this.checkBoxGenre.Location = new System.Drawing.Point(17, 120);
            this.checkBoxGenre.Name = "checkBoxGenre";
            this.checkBoxGenre.Size = new System.Drawing.Size(55, 17);
            this.checkBoxGenre.TabIndex = 17;
            this.checkBoxGenre.Text = "Жанр";
            this.checkBoxGenre.UseVisualStyleBackColor = true;
            // 
            // FormFilter
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(260, 189);
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