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
            this.textHours = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.linkPlatform = new System.Windows.Forms.LinkLabel();
            this.textComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.toolTipAll = new System.Windows.Forms.ToolTip(this.components);
            this.textHoursAll = new System.Windows.Forms.TextBox();
            this.labelHoursAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textHours
            // 
            this.textHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textHours.Location = new System.Drawing.Point(256, 237);
            this.textHours.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textHours.Name = "textHours";
            this.textHours.Size = new System.Drawing.Size(134, 50);
            this.textHours.TabIndex = 3;
            this.textHours.Text = "0";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(699, 456);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 56);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(487, 456);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(200, 56);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(256, 168);
            this.comboBoxEvent.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(360, 53);
            this.comboBoxEvent.TabIndex = 2;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(256, 33);
            this.date.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(360, 50);
            this.date.TabIndex = 0;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHours.Location = new System.Drawing.Point(142, 240);
            this.labelHours.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(102, 45);
            this.labelHours.TabIndex = 11;
            this.labelHours.Text = "Часы:";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEvent.Location = new System.Drawing.Point(87, 171);
            this.labelEvent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(157, 45);
            this.labelEvent.TabIndex = 9;
            this.labelEvent.Text = "Событие:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(150, 34);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 45);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Дата:";
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(256, 99);
            this.comboBoxPlatform.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(360, 53);
            this.comboBoxPlatform.TabIndex = 1;
            // 
            // linkPlatform
            // 
            this.linkPlatform.AutoSize = true;
            this.linkPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkPlatform.Location = new System.Drawing.Point(50, 102);
            this.linkPlatform.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkPlatform.Name = "linkPlatform";
            this.linkPlatform.Size = new System.Drawing.Size(194, 45);
            this.linkPlatform.TabIndex = 7;
            this.linkPlatform.TabStop = true;
            this.linkPlatform.Text = "Платформа:";
            this.linkPlatform.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPlatform_LinkClicked);
            // 
            // textComment
            // 
            this.textComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textComment.Location = new System.Drawing.Point(256, 303);
            this.textComment.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(643, 137);
            this.textComment.TabIndex = 4;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComment.Location = new System.Drawing.Point(14, 306);
            this.labelComment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(230, 45);
            this.labelComment.TabIndex = 16;
            this.labelComment.Text = "Комментарий:";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAll.Location = new System.Drawing.Point(628, 101);
            this.checkBoxAll.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(283, 49);
            this.checkBoxAll.TabIndex = 18;
            this.checkBoxAll.Text = "Показывать все";
            this.toolTipAll.SetToolTip(this.checkBoxAll, "Показать полный список платформ, иначе будут только те, версии игры для которых и" +
        "меются в коллекции");
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // textHoursAll
            // 
            this.textHoursAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textHoursAll.Location = new System.Drawing.Point(623, 237);
            this.textHoursAll.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textHoursAll.Name = "textHoursAll";
            this.textHoursAll.Size = new System.Drawing.Size(134, 50);
            this.textHoursAll.TabIndex = 19;
            this.textHoursAll.Text = "0";
            this.textHoursAll.TextChanged += new System.EventHandler(this.textHoursAll_TextChanged);
            // 
            // labelHoursAll
            // 
            this.labelHoursAll.AutoSize = true;
            this.labelHoursAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHoursAll.Location = new System.Drawing.Point(402, 240);
            this.labelHoursAll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHoursAll.Name = "labelHoursAll";
            this.labelHoursAll.Size = new System.Drawing.Size(209, 45);
            this.labelHoursAll.TabIndex = 20;
            this.labelHoursAll.Text = "По счётчику:";
            // 
            // FormEvent
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.linkPlatform);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.textHours);
            this.Controls.Add(this.labelHoursAll);
            this.Controls.Add(this.textHoursAll);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textComment);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 500);
            this.Name = "FormEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Событие в игре";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textHours;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.LinkLabel linkPlatform;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.ToolTip toolTipAll;
        private TextBox textHoursAll;
        private Label labelHoursAll;
    }
}