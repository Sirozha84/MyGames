namespace My_Games
{
    partial class FormPurchases
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPlatform = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnDate = new System.Windows.Forms.ColumnHeader();
            this.columnGame = new System.Windows.Forms.ColumnHeader();
            this.columnBuy = new System.Windows.Forms.ColumnHeader();
            this.columnPlatform = new System.Windows.Forms.ColumnHeader();
            this.columnMedia = new System.Windows.Forms.ColumnHeader();
            this.columnGenre = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMedium = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpent = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(188, 16);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(150, 53);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Покупка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(350, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Платформа:";
            // 
            // comboBoxPlatform
            // 
            this.comboBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPlatform.FormattingEnabled = true;
            this.comboBoxPlatform.Location = new System.Drawing.Point(556, 16);
            this.comboBoxPlatform.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxPlatform.Name = "comboBoxPlatform";
            this.comboBoxPlatform.Size = new System.Drawing.Size(300, 53);
            this.comboBoxPlatform.TabIndex = 2;
            this.comboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatform_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1358, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(1468, 16);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(300, 53);
            this.comboBoxGenre.TabIndex = 4;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGenre_SelectedIndexChanged);
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnGame,
            this.columnBuy,
            this.columnPlatform,
            this.columnMedia,
            this.columnGenre,
            this.columnPrice});
            this.listViewHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.Location = new System.Drawing.Point(0, 83);
            this.listViewHistory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(2092, 940);
            this.listViewHistory.TabIndex = 6;
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
            this.columnGame.Width = 200;
            // 
            // columnBuy
            // 
            this.columnBuy.Text = "Покупка";
            // 
            // columnPlatform
            // 
            this.columnPlatform.Text = "Платформа";
            this.columnPlatform.Width = 160;
            // 
            // columnMedia
            // 
            this.columnMedia.Text = "Носитель";
            this.columnMedia.Width = 160;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Жанр";
            this.columnGenre.Width = 160;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnPrice.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(868, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Носитель:";
            // 
            // comboBoxMedium
            // 
            this.comboBoxMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMedium.FormattingEnabled = true;
            this.comboBoxMedium.Location = new System.Drawing.Point(1046, 16);
            this.comboBoxMedium.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxMedium.Name = "comboBoxMedium";
            this.comboBoxMedium.Size = new System.Drawing.Size(300, 53);
            this.comboBoxMedium.TabIndex = 7;
            this.comboBoxMedium.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMedium_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Image = global::My_Games.Properties.Resources.reset;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(1780, 13);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(175, 57);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabelSpent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1018);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2092, 38);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.AutoSize = false;
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(300, 28);
            this.toolStripStatusLabelCount.Text = "Количество";
            this.toolStripStatusLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelSpent
            // 
            this.toolStripStatusLabelSpent.AutoSize = false;
            this.toolStripStatusLabelSpent.Name = "toolStripStatusLabelSpent";
            this.toolStripStatusLabelSpent.Size = new System.Drawing.Size(300, 28);
            this.toolStripStatusLabelSpent.Text = "Потрачено";
            this.toolStripStatusLabelSpent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2092, 1056);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMedium);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPlatform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimizeBox = false;
            this.Name = "FormPurchases";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История покупок";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPlatform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnBuy;
        private System.Windows.Forms.ColumnHeader columnGame;
        private System.Windows.Forms.ColumnHeader columnPlatform;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMedium;
        private System.Windows.Forms.ColumnHeader columnMedia;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpent;
    }
}