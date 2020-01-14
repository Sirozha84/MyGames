namespace My_Games
{
    partial class FormStatistic
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
            this.radioButtonGames = new System.Windows.Forms.RadioButton();
            this.radioButtonMoney = new System.Windows.Forms.RadioButton();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.radioButtonMounts = new System.Windows.Forms.RadioButton();
            this.radioButtonEverytime = new System.Windows.Forms.RadioButton();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonGames
            // 
            this.radioButtonGames.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGames.Checked = true;
            this.radioButtonGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonGames.Location = new System.Drawing.Point(3, 3);
            this.radioButtonGames.Name = "radioButtonGames";
            this.radioButtonGames.Size = new System.Drawing.Size(247, 26);
            this.radioButtonGames.TabIndex = 0;
            this.radioButtonGames.TabStop = true;
            this.radioButtonGames.Text = "Игр куплено";
            this.radioButtonGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGames.UseVisualStyleBackColor = true;
            this.radioButtonGames.Click += new System.EventHandler(this.RadioButtonGames_Click);
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMoney.Location = new System.Drawing.Point(256, 3);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(247, 26);
            this.radioButtonMoney.TabIndex = 1;
            this.radioButtonMoney.Text = "Денег потрачено";
            this.radioButtonMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            this.radioButtonMoney.CheckedChanged += new System.EventHandler(this.RadioButtonMoney_CheckedChanged);
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTime.Location = new System.Drawing.Point(509, 3);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(248, 26);
            this.radioButtonTime.TabIndex = 2;
            this.radioButtonTime.Text = "Времени наиграно";
            this.radioButtonTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTime.UseVisualStyleBackColor = true;
            this.radioButtonTime.CheckedChanged += new System.EventHandler(this.RadioButtonTime_CheckedChanged);
            // 
            // radioButtonMounts
            // 
            this.radioButtonMounts.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMounts.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMounts.Name = "radioButtonMounts";
            this.radioButtonMounts.Size = new System.Drawing.Size(247, 26);
            this.radioButtonMounts.TabIndex = 0;
            this.radioButtonMounts.Text = "Месяцы";
            this.radioButtonMounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMounts.UseVisualStyleBackColor = true;
            this.radioButtonMounts.CheckedChanged += new System.EventHandler(this.RadioButtonMounts_CheckedChanged);
            // 
            // radioButtonEverytime
            // 
            this.radioButtonEverytime.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEverytime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonEverytime.Location = new System.Drawing.Point(509, 3);
            this.radioButtonEverytime.Name = "radioButtonEverytime";
            this.radioButtonEverytime.Size = new System.Drawing.Size(248, 26);
            this.radioButtonEverytime.TabIndex = 2;
            this.radioButtonEverytime.Text = "За всё время";
            this.radioButtonEverytime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonEverytime.UseVisualStyleBackColor = true;
            this.radioButtonEverytime.CheckedChanged += new System.EventHandler(this.RadioButtonEverytime_CheckedChanged);
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonYears.Checked = true;
            this.radioButtonYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonYears.Location = new System.Drawing.Point(256, 3);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(247, 26);
            this.radioButtonYears.TabIndex = 1;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Годы";
            this.radioButtonYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonYears.UseVisualStyleBackColor = true;
            this.radioButtonYears.CheckedChanged += new System.EventHandler(this.RadioButtonYears_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(15, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(549, 444);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // scrollBar
            // 
            this.scrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBar.Location = new System.Drawing.Point(12, 497);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(760, 17);
            this.scrollBar.TabIndex = 6;
            this.scrollBar.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonGames, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMoney, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 32);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonEverytime, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonMounts, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonYears, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 517);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 32);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(570, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(199, 444);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Платформа";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormStatistic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика по коллекции";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormStatistic_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonGames;
        private System.Windows.Forms.RadioButton radioButtonMoney;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.RadioButton radioButtonMounts;
        private System.Windows.Forms.RadioButton radioButtonEverytime;
        private System.Windows.Forms.RadioButton radioButtonYears;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}