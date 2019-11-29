namespace My_Games
{
    partial class FormGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewVersions = new System.Windows.Forms.ListView();
            this.columnVerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerCarrier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDLCs = new System.Windows.Forms.ListView();
            this.columnDLCDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnEventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.linkLabelGenre = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDeveloper = new System.Windows.Forms.ComboBox();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChangeVersion = new System.Windows.Forms.Button();
            this.buttonDelVersion = new System.Windows.Forms.Button();
            this.buttonAddVersion = new System.Windows.Forms.Button();
            this.buttonDelDLC = new System.Windows.Forms.Button();
            this.buttonChangeDLC = new System.Windows.Forms.Button();
            this.buttonAddDLC = new System.Windows.Forms.Button();
            this.buttonDelEvent = new System.Windows.Forms.Button();
            this.buttonChangeEvent = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelDates = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageVersions = new System.Windows.Forms.TabPage();
            this.tabPageDLC = new System.Windows.Forms.TabPage();
            this.tabPageHystory = new System.Windows.Forms.TabPage();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelVers = new System.Windows.Forms.Label();
            this.labelDLCs = new System.Windows.Forms.Label();
            this.labelHis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageVersions.SuspendLayout();
            this.tabPageDLC.SuspendLayout();
            this.tabPageHystory.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название игры:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(104, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(324, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(104, 127);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(324, 21);
            this.comboBoxGenre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Издатель:";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(104, 74);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(324, 21);
            this.comboBoxPublisher.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год выхода:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(616, 526);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(697, 526);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Оценка:";
            // 
            // listViewVersions
            // 
            this.listViewVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewVersions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVerDate,
            this.columnVerPlatform,
            this.columnVerCarrier,
            this.columnVerPrice,
            this.columnVerComment});
            this.listViewVersions.FullRowSelect = true;
            this.listViewVersions.GridLines = true;
            this.listViewVersions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewVersions.HideSelection = false;
            this.listViewVersions.Location = new System.Drawing.Point(6, 35);
            this.listViewVersions.MultiSelect = false;
            this.listViewVersions.Name = "listViewVersions";
            this.listViewVersions.Size = new System.Drawing.Size(740, 441);
            this.listViewVersions.TabIndex = 3;
            this.listViewVersions.UseCompatibleStateImageBehavior = false;
            this.listViewVersions.View = System.Windows.Forms.View.Details;
            this.listViewVersions.SelectedIndexChanged += new System.EventHandler(this.listViewVersions_SelectedIndexChanged);
            this.listViewVersions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewVersions_MouseDoubleClick);
            // 
            // columnVerDate
            // 
            this.columnVerDate.Text = "Дата";
            this.columnVerDate.Width = 70;
            // 
            // columnVerPlatform
            // 
            this.columnVerPlatform.Text = "Платформа";
            this.columnVerPlatform.Width = 100;
            // 
            // columnVerCarrier
            // 
            this.columnVerCarrier.Text = "Носитель";
            this.columnVerCarrier.Width = 100;
            // 
            // columnVerPrice
            // 
            this.columnVerPrice.Text = "Цена";
            this.columnVerPrice.Width = 45;
            // 
            // columnVerComment
            // 
            this.columnVerComment.Text = "Комментарий";
            this.columnVerComment.Width = 400;
            // 
            // listViewDLCs
            // 
            this.listViewDLCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDLCs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDLCDate,
            this.columnDLCPlatform,
            this.columnDLCName,
            this.columnDLCPrice,
            this.columnDLCComment});
            this.listViewDLCs.FullRowSelect = true;
            this.listViewDLCs.GridLines = true;
            this.listViewDLCs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDLCs.HideSelection = false;
            this.listViewDLCs.Location = new System.Drawing.Point(6, 35);
            this.listViewDLCs.MultiSelect = false;
            this.listViewDLCs.Name = "listViewDLCs";
            this.listViewDLCs.Size = new System.Drawing.Size(740, 441);
            this.listViewDLCs.TabIndex = 3;
            this.listViewDLCs.UseCompatibleStateImageBehavior = false;
            this.listViewDLCs.View = System.Windows.Forms.View.Details;
            this.listViewDLCs.SelectedIndexChanged += new System.EventHandler(this.listViewDLCs_SelectedIndexChanged);
            this.listViewDLCs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDLCs_MouseDoubleClick);
            // 
            // columnDLCDate
            // 
            this.columnDLCDate.Text = "Дата";
            this.columnDLCDate.Width = 70;
            // 
            // columnDLCPlatform
            // 
            this.columnDLCPlatform.Text = "Платформа";
            this.columnDLCPlatform.Width = 100;
            // 
            // columnDLCName
            // 
            this.columnDLCName.Text = "Название";
            this.columnDLCName.Width = 100;
            // 
            // columnDLCPrice
            // 
            this.columnDLCPrice.Text = "Цена";
            this.columnDLCPrice.Width = 45;
            // 
            // columnDLCComment
            // 
            this.columnDLCComment.Text = "Комментарий";
            this.columnDLCComment.Width = 400;
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventDate,
            this.columnEventPlatform,
            this.columnEvent,
            this.columnEventHours,
            this.columnEventComment});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(6, 35);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(740, 441);
            this.listViewHistory.TabIndex = 3;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
            this.listViewHistory.DoubleClick += new System.EventHandler(this.listViewHistory_DoubleClick);
            // 
            // columnEventDate
            // 
            this.columnEventDate.Text = "Дата";
            this.columnEventDate.Width = 70;
            // 
            // columnEventPlatform
            // 
            this.columnEventPlatform.Text = "Платформа";
            this.columnEventPlatform.Width = 100;
            // 
            // columnEvent
            // 
            this.columnEvent.Text = "Событие";
            this.columnEvent.Width = 100;
            // 
            // columnEventHours
            // 
            this.columnEventHours.Text = "Часы";
            this.columnEventHours.Width = 45;
            // 
            // columnEventComment
            // 
            this.columnEventComment.Text = "Комментарий";
            this.columnEventComment.Width = 400;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(6, 19);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(728, 139);
            this.textBoxComment.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkLabelSite);
            this.groupBox1.Controls.Add(this.textBoxSite);
            this.groupBox1.Controls.Add(this.linkLabelGenre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxDeveloper);
            this.groupBox1.Controls.Add(this.comboBoxRate);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxGenre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxPublisher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(312, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие сведения";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(64, 184);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(34, 13);
            this.linkLabelSite.TabIndex = 7;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Сайт:";
            // 
            // textBoxSite
            // 
            this.textBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSite.Location = new System.Drawing.Point(104, 181);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(324, 20);
            this.textBoxSite.TabIndex = 8;
            // 
            // linkLabelGenre
            // 
            this.linkLabelGenre.AutoSize = true;
            this.linkLabelGenre.Location = new System.Drawing.Point(59, 131);
            this.linkLabelGenre.Name = "linkLabelGenre";
            this.linkLabelGenre.Size = new System.Drawing.Size(39, 13);
            this.linkLabelGenre.TabIndex = 4;
            this.linkLabelGenre.TabStop = true;
            this.linkLabelGenre.Text = "Жанр:";
            this.linkLabelGenre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Разработчик:";
            // 
            // comboBoxDeveloper
            // 
            this.comboBoxDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDeveloper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxDeveloper.FormattingEnabled = true;
            this.comboBoxDeveloper.Location = new System.Drawing.Point(104, 48);
            this.comboBoxDeveloper.Name = "comboBoxDeveloper";
            this.comboBoxDeveloper.Size = new System.Drawing.Size(324, 21);
            this.comboBoxDeveloper.TabIndex = 1;
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Location = new System.Drawing.Point(104, 154);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(58, 21);
            this.comboBoxRate.TabIndex = 6;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(104, 101);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(57, 20);
            this.textBoxYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(50, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Здесь когда-нибудь будет обложка игры";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // buttonChangeVersion
            // 
            this.buttonChangeVersion.Enabled = false;
            this.buttonChangeVersion.Location = new System.Drawing.Point(87, 6);
            this.buttonChangeVersion.Name = "buttonChangeVersion";
            this.buttonChangeVersion.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeVersion.TabIndex = 1;
            this.buttonChangeVersion.Text = "Изменить";
            this.buttonChangeVersion.UseVisualStyleBackColor = true;
            this.buttonChangeVersion.Click += new System.EventHandler(this.buttonChangeVersion_Click);
            // 
            // buttonDelVersion
            // 
            this.buttonDelVersion.Enabled = false;
            this.buttonDelVersion.Location = new System.Drawing.Point(168, 6);
            this.buttonDelVersion.Name = "buttonDelVersion";
            this.buttonDelVersion.Size = new System.Drawing.Size(75, 23);
            this.buttonDelVersion.TabIndex = 2;
            this.buttonDelVersion.Text = "Удалить";
            this.buttonDelVersion.UseVisualStyleBackColor = true;
            this.buttonDelVersion.Click += new System.EventHandler(this.buttonDelVersion_Click);
            // 
            // buttonAddVersion
            // 
            this.buttonAddVersion.Location = new System.Drawing.Point(6, 6);
            this.buttonAddVersion.Name = "buttonAddVersion";
            this.buttonAddVersion.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVersion.TabIndex = 0;
            this.buttonAddVersion.Text = "Добавить";
            this.buttonAddVersion.UseVisualStyleBackColor = true;
            this.buttonAddVersion.Click += new System.EventHandler(this.buttonAddVersion_Click);
            // 
            // buttonDelDLC
            // 
            this.buttonDelDLC.Enabled = false;
            this.buttonDelDLC.Location = new System.Drawing.Point(168, 6);
            this.buttonDelDLC.Name = "buttonDelDLC";
            this.buttonDelDLC.Size = new System.Drawing.Size(75, 23);
            this.buttonDelDLC.TabIndex = 2;
            this.buttonDelDLC.Text = "Удалить";
            this.buttonDelDLC.UseVisualStyleBackColor = true;
            this.buttonDelDLC.Click += new System.EventHandler(this.buttonDelDLC_Click);
            // 
            // buttonChangeDLC
            // 
            this.buttonChangeDLC.Enabled = false;
            this.buttonChangeDLC.Location = new System.Drawing.Point(87, 6);
            this.buttonChangeDLC.Name = "buttonChangeDLC";
            this.buttonChangeDLC.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeDLC.TabIndex = 1;
            this.buttonChangeDLC.Text = "Изменить";
            this.buttonChangeDLC.UseVisualStyleBackColor = true;
            this.buttonChangeDLC.Click += new System.EventHandler(this.buttonChangeDLC_Click);
            // 
            // buttonAddDLC
            // 
            this.buttonAddDLC.Location = new System.Drawing.Point(6, 6);
            this.buttonAddDLC.Name = "buttonAddDLC";
            this.buttonAddDLC.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDLC.TabIndex = 0;
            this.buttonAddDLC.Text = "Добавить";
            this.buttonAddDLC.UseVisualStyleBackColor = true;
            this.buttonAddDLC.Click += new System.EventHandler(this.buttonAddDLC_Click);
            // 
            // buttonDelEvent
            // 
            this.buttonDelEvent.Enabled = false;
            this.buttonDelEvent.Location = new System.Drawing.Point(168, 6);
            this.buttonDelEvent.Name = "buttonDelEvent";
            this.buttonDelEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonDelEvent.TabIndex = 2;
            this.buttonDelEvent.Text = "Удалить";
            this.buttonDelEvent.UseVisualStyleBackColor = true;
            this.buttonDelEvent.Click += new System.EventHandler(this.buttonDelEvent_Click);
            // 
            // buttonChangeEvent
            // 
            this.buttonChangeEvent.Enabled = false;
            this.buttonChangeEvent.Location = new System.Drawing.Point(87, 6);
            this.buttonChangeEvent.Name = "buttonChangeEvent";
            this.buttonChangeEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeEvent.TabIndex = 1;
            this.buttonChangeEvent.Text = "Изменить";
            this.buttonChangeEvent.UseVisualStyleBackColor = true;
            this.buttonChangeEvent.Click += new System.EventHandler(this.buttonChangeEvent_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Location = new System.Drawing.Point(6, 6);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 0;
            this.buttonAddEvent.Text = "Добавить";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.textBoxComment);
            this.groupBox5.Location = new System.Drawing.Point(6, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(740, 164);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Описание";
            // 
            // labelDates
            // 
            this.labelDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDates.AutoSize = true;
            this.labelDates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDates.Location = new System.Drawing.Point(6, 3);
            this.labelDates.Name = "labelDates";
            this.labelDates.Size = new System.Drawing.Size(33, 13);
            this.labelDates.TabIndex = 25;
            this.labelDates.Text = "Дата";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageVersions);
            this.tabControl.Controls.Add(this.tabPageDLC);
            this.tabControl.Controls.Add(this.tabPageHystory);
            this.tabControl.Controls.Add(this.tabPageNotes);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.ItemSize = new System.Drawing.Size(140, 18);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 508);
            this.tabControl.TabIndex = 26;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.groupBox2);
            this.tabPageMain.Controls.Add(this.groupBox1);
            this.tabPageMain.Controls.Add(this.label2);
            this.tabPageMain.Controls.Add(this.groupBox5);
            this.tabPageMain.Controls.Add(this.pictureBox1);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(752, 482);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Общие сведения";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageVersions
            // 
            this.tabPageVersions.Controls.Add(this.buttonChangeVersion);
            this.tabPageVersions.Controls.Add(this.buttonAddVersion);
            this.tabPageVersions.Controls.Add(this.buttonDelVersion);
            this.tabPageVersions.Controls.Add(this.listViewVersions);
            this.tabPageVersions.Location = new System.Drawing.Point(4, 22);
            this.tabPageVersions.Name = "tabPageVersions";
            this.tabPageVersions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVersions.Size = new System.Drawing.Size(752, 482);
            this.tabPageVersions.TabIndex = 1;
            this.tabPageVersions.Text = "Версии";
            this.tabPageVersions.UseVisualStyleBackColor = true;
            // 
            // tabPageDLC
            // 
            this.tabPageDLC.Controls.Add(this.buttonDelDLC);
            this.tabPageDLC.Controls.Add(this.buttonAddDLC);
            this.tabPageDLC.Controls.Add(this.listViewDLCs);
            this.tabPageDLC.Controls.Add(this.buttonChangeDLC);
            this.tabPageDLC.Location = new System.Drawing.Point(4, 22);
            this.tabPageDLC.Name = "tabPageDLC";
            this.tabPageDLC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDLC.Size = new System.Drawing.Size(752, 482);
            this.tabPageDLC.TabIndex = 2;
            this.tabPageDLC.Text = "Доп. материалы";
            this.tabPageDLC.UseVisualStyleBackColor = true;
            // 
            // tabPageHystory
            // 
            this.tabPageHystory.Controls.Add(this.buttonDelEvent);
            this.tabPageHystory.Controls.Add(this.buttonAddEvent);
            this.tabPageHystory.Controls.Add(this.buttonChangeEvent);
            this.tabPageHystory.Controls.Add(this.listViewHistory);
            this.tabPageHystory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHystory.Name = "tabPageHystory";
            this.tabPageHystory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHystory.Size = new System.Drawing.Size(752, 482);
            this.tabPageHystory.TabIndex = 3;
            this.tabPageHystory.Text = "История прохождения";
            this.tabPageHystory.UseVisualStyleBackColor = true;
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotes.Size = new System.Drawing.Size(752, 482);
            this.tabPageNotes.TabIndex = 4;
            this.tabPageNotes.Text = "Заметки";
            this.tabPageNotes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelHis);
            this.groupBox2.Controls.Add(this.labelDLCs);
            this.groupBox2.Controls.Add(this.labelVers);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(312, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 84);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о коллекции";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelDates);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 482);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Разное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Версии:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Доп. материалы:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Пройдена:";
            // 
            // labelVers
            // 
            this.labelVers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVers.Location = new System.Drawing.Point(106, 20);
            this.labelVers.Name = "labelVers";
            this.labelVers.Size = new System.Drawing.Size(322, 13);
            this.labelVers.TabIndex = 3;
            // 
            // labelDLCs
            // 
            this.labelDLCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDLCs.Location = new System.Drawing.Point(106, 38);
            this.labelDLCs.Name = "labelDLCs";
            this.labelDLCs.Size = new System.Drawing.Size(322, 13);
            this.labelDLCs.TabIndex = 4;
            // 
            // labelHis
            // 
            this.labelHis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHis.Location = new System.Drawing.Point(106, 56);
            this.labelHis.Name = "labelHis";
            this.labelHis.Size = new System.Drawing.Size(322, 13);
            this.labelHis.TabIndex = 5;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormGame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageVersions.ResumeLayout(false);
            this.tabPageDLC.ResumeLayout(false);
            this.tabPageHystory.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewVersions;
        private System.Windows.Forms.ColumnHeader columnVerDate;
        private System.Windows.Forms.ColumnHeader columnVerPlatform;
        private System.Windows.Forms.ColumnHeader columnVerCarrier;
        private System.Windows.Forms.ColumnHeader columnVerPrice;
        private System.Windows.Forms.ListView listViewDLCs;
        private System.Windows.Forms.ColumnHeader columnDLCDate;
        private System.Windows.Forms.ColumnHeader columnDLCPlatform;
        private System.Windows.Forms.ColumnHeader columnDLCName;
        private System.Windows.Forms.ColumnHeader columnDLCPrice;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnEventDate;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader columnEventComment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddVersion;
        private System.Windows.Forms.Button buttonDelDLC;
        private System.Windows.Forms.Button buttonChangeDLC;
        private System.Windows.Forms.Button buttonAddDLC;
        private System.Windows.Forms.Button buttonDelEvent;
        private System.Windows.Forms.Button buttonChangeEvent;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonChangeVersion;
        private System.Windows.Forms.Button buttonDelVersion;
        private System.Windows.Forms.ColumnHeader columnEventHours;
        private System.Windows.Forms.ColumnHeader columnEventPlatform;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDeveloper;
        private System.Windows.Forms.LinkLabel linkLabelGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDates;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.ColumnHeader columnVerComment;
        private System.Windows.Forms.ColumnHeader columnDLCComment;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageVersions;
        private System.Windows.Forms.TabPage tabPageDLC;
        private System.Windows.Forms.TabPage tabPageHystory;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelHis;
        private System.Windows.Forms.Label labelDLCs;
        private System.Windows.Forms.Label labelVers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}