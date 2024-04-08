namespace My_Games
{
    partial class FormEvent
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
            this.components = new System.ComponentModel.Container();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.linkLabelPlatform = new System.Windows.Forms.LinkLabel();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.toolTipAll = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxHoursAll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(95, 145);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(64, 20);
            this.textBoxHours.TabIndex = 7;
            this.textBoxHours.Text = "0";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(275, 196);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(194, 196);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(95, 92);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(150, 21);
            this.comboBoxEvent.TabIndex = 5;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(95, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(120, 20);
            this.date.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Часы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Событие:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата:";
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(95, 65);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPlatform.TabIndex = 3;
            // 
            // linkLabelPlatform
            // 
            this.linkLabelPlatform.AutoSize = true;
            this.linkLabelPlatform.Location = new System.Drawing.Point(20, 68);
            this.linkLabelPlatform.Name = "linkLabelPlatform";
            this.linkLabelPlatform.Size = new System.Drawing.Size(69, 13);
            this.linkLabelPlatform.TabIndex = 2;
            this.linkLabelPlatform.TabStop = true;
            this.linkLabelPlatform.Text = "Платформа:";
            this.linkLabelPlatform.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPlatform_LinkClicked);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(95, 171);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(255, 19);
            this.textBoxComment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Комментарий:";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(251, 67);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(110, 17);
            this.checkBoxAll.TabIndex = 4;
            this.checkBoxAll.Text = "Показывать все";
            this.toolTipAll.SetToolTip(this.checkBoxAll, "Показать полный список платформ, иначе будут только те, версии игры для которых и" +
        "меются в коллекции");
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // textBoxHoursAll
            // 
            this.textBoxHoursAll.Location = new System.Drawing.Point(95, 119);
            this.textBoxHoursAll.Name = "textBoxHoursAll";
            this.textBoxHoursAll.Size = new System.Drawing.Size(64, 20);
            this.textBoxHoursAll.TabIndex = 6;
            this.textBoxHoursAll.Text = "0";
            this.textBoxHoursAll.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Счётчик:";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(47, 41);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(42, 13);
            this.labelMethod.TabIndex = 22;
            this.labelMethod.Text = "Метод:";
            // 
            // comboMethod
            // 
            this.comboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Location = new System.Drawing.Point(95, 38);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(150, 21);
            this.comboMethod.TabIndex = 1;
            this.comboMethod.SelectedIndexChanged += new System.EventHandler(this.comboMethod_SelectedIndexChanged);
            // 
            // FormEvent
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(367, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.comboMethod);
            this.Controls.Add(this.linkLabelPlatform);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxHoursAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 270);
            this.Name = "FormEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Событие в игре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.LinkLabel linkLabelPlatform;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.ToolTip toolTipAll;
        private System.Windows.Forms.TextBox textBoxHoursAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.ComboBox comboMethod;
    }
}