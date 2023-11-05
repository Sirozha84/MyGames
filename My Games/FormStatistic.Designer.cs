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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.scrollBar = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCS = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelZoom = new System.Windows.Forms.Label();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.checkSeeAll = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonGames
            // 
            this.radioButtonGames.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonGames.Location = new System.Drawing.Point(193, 3);
            this.radioButtonGames.Name = "radioButtonGames";
            this.radioButtonGames.Size = new System.Drawing.Size(184, 26);
            this.radioButtonGames.TabIndex = 0;
            this.radioButtonGames.Text = "Игр куплено";
            this.radioButtonGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonGames.UseVisualStyleBackColor = true;
            this.radioButtonGames.CheckedChanged += new System.EventHandler(this.Calc);
            // 
            // radioButtonMoney
            // 
            this.radioButtonMoney.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMoney.Location = new System.Drawing.Point(383, 3);
            this.radioButtonMoney.Name = "radioButtonMoney";
            this.radioButtonMoney.Size = new System.Drawing.Size(184, 26);
            this.radioButtonMoney.TabIndex = 1;
            this.radioButtonMoney.Text = "Денег потрачено";
            this.radioButtonMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMoney.UseVisualStyleBackColor = true;
            this.radioButtonMoney.CheckedChanged += new System.EventHandler(this.Calc);
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTime.Location = new System.Drawing.Point(573, 3);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(184, 26);
            this.radioButtonTime.TabIndex = 2;
            this.radioButtonTime.Text = "Времени наиграно";
            this.radioButtonTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTime.UseVisualStyleBackColor = true;
            this.radioButtonTime.CheckedChanged += new System.EventHandler(this.Calc);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(552, 444);
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
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonGames, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonTime, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonMoney, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 32);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // radioButtonCS
            // 
            this.radioButtonCS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCS.Checked = true;
            this.radioButtonCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCS.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCS.Name = "radioButtonCS";
            this.radioButtonCS.Size = new System.Drawing.Size(184, 26);
            this.radioButtonCS.TabIndex = 3;
            this.radioButtonCS.TabStop = true;
            this.radioButtonCS.Text = "Размер коллекции";
            this.radioButtonCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCS.UseVisualStyleBackColor = true;
            this.radioButtonCS.CheckedChanged += new System.EventHandler(this.Calc);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.labelZoom, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonZoomOut, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonZoomIn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkSeeAll, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 517);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 32);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelZoom.Location = new System.Drawing.Point(383, 0);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(184, 32);
            this.labelZoom.TabIndex = 3;
            this.labelZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZoomOut.Location = new System.Drawing.Point(3, 3);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(184, 26);
            this.buttonZoomOut.TabIndex = 4;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.ZoomOut);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonZoomIn.Location = new System.Drawing.Point(193, 3);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(184, 26);
            this.buttonZoomIn.TabIndex = 5;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.ZoomIn);
            // 
            // checkSeeAll
            // 
            this.checkSeeAll.AutoSize = true;
            this.checkSeeAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkSeeAll.Location = new System.Drawing.Point(573, 3);
            this.checkSeeAll.Name = "checkSeeAll";
            this.checkSeeAll.Size = new System.Drawing.Size(184, 26);
            this.checkSeeAll.TabIndex = 6;
            this.checkSeeAll.Text = "Учитывать скрытые";
            this.checkSeeAll.UseVisualStyleBackColor = true;
            this.checkSeeAll.Click += new System.EventHandler(this.Calc);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnValue});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(570, 50);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(202, 444);
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
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonGames;
        private System.Windows.Forms.RadioButton radioButtonMoney;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.HScrollBar scrollBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.RadioButton radioButtonCS;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.CheckBox checkSeeAll;
    }
}