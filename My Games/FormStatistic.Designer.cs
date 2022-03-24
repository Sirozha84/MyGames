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
            this.radioButtonCS = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader = new System.Windows.Forms.ColumnHeader();
            this.columnValue = new System.Windows.Forms.ColumnHeader();
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
            this.radioButtonGames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGames.Location = new System.Drawing.Point(6, 7);
            this.radioButtonGames.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonGames.Name = "radioButtonGames";
            this.radioButtonGames.Size = new System.Drawing.Size(453, 65);
            this.radioButtonGames.TabIndex = 0;
            this.radioButtonGames.TabStop = true;
            this.radioButtonGames.Text = "Игр куплено";
            this.radioButtonGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGames.UseVisualStyleBackColor = true;
            this.radioButtonGames.CheckedChanged += new System.EventHandler(this.CalcGames);
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMoney.Location = new System.Drawing.Point(471, 7);
            this.radioButtonMoney.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(453, 65);
            this.radioButtonMoney.TabIndex = 1;
            this.radioButtonMoney.Text = "Денег потрачено";
            this.radioButtonMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            this.radioButtonMoney.CheckedChanged += new System.EventHandler(this.CalcMoney);
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTime.Location = new System.Drawing.Point(936, 7);
            this.radioButtonTime.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(453, 65);
            this.radioButtonTime.TabIndex = 2;
            this.radioButtonTime.Text = "Времени наиграно";
            this.radioButtonTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTime.UseVisualStyleBackColor = true;
            this.radioButtonTime.CheckedChanged += new System.EventHandler(this.CalcTime);
            // 
            // radioButtonMounts
            // 
            this.radioButtonMounts.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMounts.Location = new System.Drawing.Point(6, 7);
            this.radioButtonMounts.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonMounts.Name = "radioButtonMounts";
            this.radioButtonMounts.Size = new System.Drawing.Size(608, 65);
            this.radioButtonMounts.TabIndex = 0;
            this.radioButtonMounts.Text = "Месяцы";
            this.radioButtonMounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMounts.UseVisualStyleBackColor = true;
            this.radioButtonMounts.CheckedChanged += new System.EventHandler(this.ScaleMonths);
            // 
            // radioButtonEverytime
            // 
            this.radioButtonEverytime.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEverytime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonEverytime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonEverytime.Location = new System.Drawing.Point(1246, 7);
            this.radioButtonEverytime.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonEverytime.Name = "radioButtonEverytime";
            this.radioButtonEverytime.Size = new System.Drawing.Size(610, 65);
            this.radioButtonEverytime.TabIndex = 2;
            this.radioButtonEverytime.Text = "За всё время";
            this.radioButtonEverytime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonEverytime.UseVisualStyleBackColor = true;
            this.radioButtonEverytime.CheckedChanged += new System.EventHandler(this.ScaleAll);
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonYears.Checked = true;
            this.radioButtonYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonYears.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonYears.Location = new System.Drawing.Point(626, 7);
            this.radioButtonYears.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(608, 65);
            this.radioButtonYears.TabIndex = 1;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Годы";
            this.radioButtonYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonYears.UseVisualStyleBackColor = true;
            this.radioButtonYears.CheckedChanged += new System.EventHandler(this.ScaleYears);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(15, 102);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1389, 877);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // scrollBar
            // 
            this.scrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBar.Location = new System.Drawing.Point(15, 986);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(1868, 46);
            this.scrollBar.TabIndex = 6;
            this.scrollBar.ValueChanged += new System.EventHandler(this.Scrolling);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCS, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonGames, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMoney, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1862, 79);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // radioButtonCS
            // 
            this.radioButtonCS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCS.Location = new System.Drawing.Point(1401, 7);
            this.radioButtonCS.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.radioButtonCS.Name = "radioButtonCS";
            this.radioButtonCS.Size = new System.Drawing.Size(455, 65);
            this.radioButtonCS.TabIndex = 3;
            this.radioButtonCS.Text = "Размер коллекции";
            this.radioButtonCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCS.UseVisualStyleBackColor = true;
            this.radioButtonCS.CheckedChanged += new System.EventHandler(this.CalcColCount);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 1039);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1862, 79);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnValue});
            this.listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(1416, 102);
            this.listView.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(461, 877);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.LegendChange);
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Платформа";
            this.columnHeader.Width = 120;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Значение";
            this.columnValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 1134);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.scrollBar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.RadioButton radioButtonCS;
    }
}