namespace My_Games
{
    partial class FormHistory
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
            this.columnDate = new System.Windows.Forms.ColumnHeader();
            this.columnGame = new System.Windows.Forms.ColumnHeader();
            this.columnPlatform = new System.Windows.Forms.ColumnHeader();
            this.columnGenre = new System.Windows.Forms.ColumnHeader();
            this.columnEvent = new System.Windows.Forms.ColumnHeader();
            this.columnHours = new System.Windows.Forms.ColumnHeader();
            this.columnComment = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 822);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 42, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1663, 38);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 28);
            this.toolStripStatusLabel1.Text = "Количество";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(300, 28);
            this.toolStripStatusLabel2.Text = "Часы";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReset
            // 
            this.buttonReset.Image = global::My_Games.Properties.Resources.reset;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(1315, 16);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(175, 57);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnGame,
            this.columnPlatform,
            this.columnGenre,
            this.columnEvent,
            this.columnHours,
            this.columnComment});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.Location = new System.Drawing.Point(0, 92);
            this.listViewHistory.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(1663, 728);
            this.listViewHistory.TabIndex = 17;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата";
            this.columnDate.Width = 80;
            // 
            // columnGame
            // 
            this.columnGame.Text = "Игра";
            this.columnGame.Width = 160;
            // 
            // columnPlatform
            // 
            this.columnPlatform.Text = "Платформа";
            this.columnPlatform.Width = 160;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Жанр";
            this.columnGenre.Width = 160;
            // 
            // columnEvent
            // 
            this.columnEvent.Text = "Событие";
            this.columnEvent.Width = 100;
            // 
            // columnHours
            // 
            this.columnHours.Text = "Часы";
            this.columnHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Комментарий";
            this.columnComment.Width = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 45);
            this.label3.TabIndex = 16;
            this.label3.Text = "Жанр:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(827, 19);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(472, 53);
            this.comboBoxGenre.TabIndex = 15;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGenre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Платформа:";
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(215, 19);
            this.comboBoxPlatform.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(472, 53);
            this.comboBoxPlatform.TabIndex = 13;
            this.comboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatform_SelectedIndexChanged);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 860);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPlatform);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.MinimizeBox = false;
            this.Name = "FormHistory";
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
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnGame;
        private System.Windows.Forms.ColumnHeader columnPlatform;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader columnHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnComment;
    }
}