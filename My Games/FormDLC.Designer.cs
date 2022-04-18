namespace My_Games
{
    partial class FormDLC
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.linkLabelPlatform = new System.Windows.Forms.LinkLabel();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.toolTipAll = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(190, 175);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(124, 31);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.Text = "0";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(550, 362);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(388, 362);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 44);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(190, 73);
            this.comboBoxPlatform.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(296, 33);
            this.comboBoxPlatform.TabIndex = 1;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(190, 23);
            this.date.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 31);
            this.date.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(190, 125);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 31);
            this.textBoxName.TabIndex = 2;
            // 
            // linkLabelPlatform
            // 
            this.linkLabelPlatform.AutoSize = true;
            this.linkLabelPlatform.Location = new System.Drawing.Point(40, 79);
            this.linkLabelPlatform.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabelPlatform.Name = "linkLabelPlatform";
            this.linkLabelPlatform.Size = new System.Drawing.Size(135, 25);
            this.linkLabelPlatform.TabIndex = 14;
            this.linkLabelPlatform.TabStop = true;
            this.linkLabelPlatform.Text = "Платформа:";
            this.linkLabelPlatform.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPlatform_LinkClicked);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(190, 225);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(506, 121);
            this.textBoxComment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Комментарий:";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(502, 77);
            this.checkBoxAll.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(204, 29);
            this.checkBoxAll.TabIndex = 17;
            this.checkBoxAll.Text = "Показывать все";
            this.toolTipAll.SetToolTip(this.checkBoxAll, "Показать полный список платформ, иначе будут только те, версии игры для которых и" +
        "меются в коллекции");
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // FormDLC
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(724, 429);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelPlatform);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 420);
            this.Name = "FormDLC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дополнительный материал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.LinkLabel linkLabelPlatform;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.ToolTip toolTipAll;
    }
}