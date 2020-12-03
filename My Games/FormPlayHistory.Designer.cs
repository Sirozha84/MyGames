namespace My_Games
{
    partial class FormPlayHistory
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.columnHeaderComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel1.Text = "Количество";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel2.Text = "Часы";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(466, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(73, 21);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderGame,
            this.columnHeaderPlatform,
            this.columnHeaderGenre,
            this.columnHeaderEvent,
            this.columnHeaderTime,
            this.columnHeaderComment});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(12, 39);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(920, 503);
            this.listViewHistory.TabIndex = 17;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата";
            this.columnHeaderDate.Width = 80;
            // 
            // columnHeaderGame
            // 
            this.columnHeaderGame.Text = "Игра";
            this.columnHeaderGame.Width = 200;
            // 
            // columnHeaderPlatform
            // 
            this.columnHeaderPlatform.Text = "Платформа";
            this.columnHeaderPlatform.Width = 150;
            // 
            // columnHeaderGenre
            // 
            this.columnHeaderGenre.Text = "Жанр";
            this.columnHeaderGenre.Width = 100;
            // 
            // columnHeaderEvent
            // 
            this.columnHeaderEvent.Text = "Событие";
            this.columnHeaderEvent.Width = 100;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Жанр:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(300, 12);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(160, 21);
            this.comboBoxGenre.TabIndex = 15;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGenre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Платформа:";
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(84, 12);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPlatform.TabIndex = 13;
            this.comboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatform_SelectedIndexChanged);
            // 
            // columnHeaderComment
            // 
            this.columnHeaderComment.Text = "Комментарий";
            this.columnHeaderComment.Width = 200;
            // 
            // FormPlayHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPlatform);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "FormPlayHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История прохождений";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderGame;
        private System.Windows.Forms.ColumnHeader columnHeaderPlatform;
        private System.Windows.Forms.ColumnHeader columnHeaderEvent;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.ColumnHeader columnHeaderGenre;
        private System.Windows.Forms.ColumnHeader columnHeaderComment;
    }
}