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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRate = new System.Windows.Forms.Label();
            this.listViewVersions = new System.Windows.Forms.ListView();
            this.columnVerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerCarrier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnEventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHoursAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.textDeveloper = new System.Windows.Forms.TextBox();
            this.textPublisher = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.linkGenre = new System.Windows.Forms.LinkLabel();
            this.comboRate = new System.Windows.Forms.ComboBox();
            this.linkSite = new System.Windows.Forms.LinkLabel();
            this.textSite = new System.Windows.Forms.TextBox();
            this.linkSF = new System.Windows.Forms.LinkLabel();
            this.textSF = new System.Windows.Forms.TextBox();
            this.buttonBrowseSF = new System.Windows.Forms.Button();
            this.labelCover = new System.Windows.Forms.Label();
            this.cmCover = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmSelectCover = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRemoveCover = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelEvent = new System.Windows.Forms.Button();
            this.buttonChangeEvent = new System.Windows.Forms.Button();
            this.groupBoxComment = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelHis = new System.Windows.Forms.Label();
            this.labelDLCs = new System.Windows.Forms.Label();
            this.labelVers = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.tabPagePurchases = new System.Windows.Forms.TabPage();
            this.panelDLCs = new System.Windows.Forms.Panel();
            this.groupBoxDLCs = new System.Windows.Forms.GroupBox();
            this.buttonAddDLC = new System.Windows.Forms.Button();
            this.buttonDelDLC = new System.Windows.Forms.Button();
            this.buttonChangeDLC = new System.Windows.Forms.Button();
            this.listViewDLCs = new System.Windows.Forms.ListView();
            this.columnDLCDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDLCComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter = new System.Windows.Forms.Splitter();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.groupBoxVersion = new System.Windows.Forms.GroupBox();
            this.buttonAddVersion = new System.Windows.Forms.Button();
            this.buttonDelVersion = new System.Windows.Forms.Button();
            this.buttonChangeVersion = new System.Windows.Forms.Button();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.groupBoxNotes = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNoteAdd = new System.Windows.Forms.Button();
            this.textBoxNoteName = new System.Windows.Forms.TextBox();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimeNote = new System.Windows.Forms.DateTimePicker();
            this.buttonNoteDel = new System.Windows.Forms.Button();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.checkHidden = new System.Windows.Forms.CheckBox();
            this.groupBoxMain.SuspendLayout();
            this.cmCover.SuspendLayout();
            this.groupBoxComment.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabPagePurchases.SuspendLayout();
            this.panelDLCs.SuspendLayout();
            this.groupBoxDLCs.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.groupBoxVersion.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.groupBoxHistory.SuspendLayout();
            this.tabPageNotes.SuspendLayout();
            this.groupBoxNotes.SuspendLayout();
            this.tabPageOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(48, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Игра:";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(89, 20);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(339, 20);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // comboGenre
            // 
            this.comboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(89, 125);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(339, 21);
            this.comboGenre.TabIndex = 9;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(24, 75);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(59, 13);
            this.labelPublisher.TabIndex = 4;
            this.labelPublisher.Text = "Издатель:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(15, 102);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(68, 13);
            this.labelYear.TabIndex = 6;
            this.labelYear.Text = "Год выхода:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(616, 526);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.OK);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(697, 526);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(35, 155);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(48, 13);
            this.labelRate.TabIndex = 10;
            this.labelRate.Text = "Оценка:";
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
            this.listViewVersions.Location = new System.Drawing.Point(6, 48);
            this.listViewVersions.MultiSelect = false;
            this.listViewVersions.Name = "listViewVersions";
            this.listViewVersions.Size = new System.Drawing.Size(728, 178);
            this.listViewVersions.TabIndex = 3;
            this.listViewVersions.UseCompatibleStateImageBehavior = false;
            this.listViewVersions.View = System.Windows.Forms.View.Details;
            this.listViewVersions.SelectedIndexChanged += new System.EventHandler(this.listViewVersions_SelectedIndexChanged);
            this.listViewVersions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EditVersion);
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
            this.columnVerPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnVerPrice.Width = 45;
            // 
            // columnVerComment
            // 
            this.columnVerComment.Text = "Комментарий";
            this.columnVerComment.Width = 400;
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
            this.columnEventHoursAll,
            this.columnEventHours,
            this.columnEventComment});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(6, 48);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(728, 416);
            this.listViewHistory.TabIndex = 3;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.listViewHistory_SelectedIndexChanged);
            this.listViewHistory.DoubleClick += new System.EventHandler(this.EditEvent);
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
            // columnEventHoursAll
            // 
            this.columnEventHoursAll.Text = "Счётчик";
            this.columnEventHoursAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnEventHours
            // 
            this.columnEventHours.Text = "Часы";
            this.columnEventHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnEventHours.Width = 45;
            // 
            // columnEventComment
            // 
            this.columnEventComment.Text = "Комментарий";
            this.columnEventComment.Width = 340;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(6, 19);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(728, 113);
            this.textBoxComment.TabIndex = 0;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.labelName);
            this.groupBoxMain.Controls.Add(this.textName);
            this.groupBoxMain.Controls.Add(this.labelDeveloper);
            this.groupBoxMain.Controls.Add(this.textDeveloper);
            this.groupBoxMain.Controls.Add(this.labelPublisher);
            this.groupBoxMain.Controls.Add(this.textPublisher);
            this.groupBoxMain.Controls.Add(this.labelYear);
            this.groupBoxMain.Controls.Add(this.textYear);
            this.groupBoxMain.Controls.Add(this.linkGenre);
            this.groupBoxMain.Controls.Add(this.comboGenre);
            this.groupBoxMain.Controls.Add(this.labelRate);
            this.groupBoxMain.Controls.Add(this.comboRate);
            this.groupBoxMain.Controls.Add(this.linkSite);
            this.groupBoxMain.Controls.Add(this.textSite);
            this.groupBoxMain.Controls.Add(this.linkSF);
            this.groupBoxMain.Controls.Add(this.textSF);
            this.groupBoxMain.Controls.Add(this.buttonBrowseSF);
            this.groupBoxMain.Location = new System.Drawing.Point(312, 6);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(434, 236);
            this.groupBoxMain.TabIndex = 1;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Общие сведения";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(8, 48);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(75, 13);
            this.labelDeveloper.TabIndex = 2;
            this.labelDeveloper.Text = "Разработчик:";
            // 
            // textDeveloper
            // 
            this.textDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDeveloper.Location = new System.Drawing.Point(89, 45);
            this.textDeveloper.Name = "textDeveloper";
            this.textDeveloper.Size = new System.Drawing.Size(339, 20);
            this.textDeveloper.TabIndex = 3;
            // 
            // textPublisher
            // 
            this.textPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPublisher.Location = new System.Drawing.Point(89, 72);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Size = new System.Drawing.Size(339, 20);
            this.textPublisher.TabIndex = 5;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(89, 99);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(57, 20);
            this.textYear.TabIndex = 7;
            // 
            // linkGenre
            // 
            this.linkGenre.AutoSize = true;
            this.linkGenre.Location = new System.Drawing.Point(44, 129);
            this.linkGenre.Name = "linkGenre";
            this.linkGenre.Size = new System.Drawing.Size(39, 13);
            this.linkGenre.TabIndex = 8;
            this.linkGenre.TabStop = true;
            this.linkGenre.Text = "Жанр:";
            this.linkGenre.Click += new System.EventHandler(this.GenreCat);
            // 
            // comboRate
            // 
            this.comboRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRate.FormattingEnabled = true;
            this.comboRate.Location = new System.Drawing.Point(89, 152);
            this.comboRate.Name = "comboRate";
            this.comboRate.Size = new System.Drawing.Size(58, 21);
            this.comboRate.TabIndex = 11;
            // 
            // linkSite
            // 
            this.linkSite.AutoSize = true;
            this.linkSite.Location = new System.Drawing.Point(49, 182);
            this.linkSite.Name = "linkSite";
            this.linkSite.Size = new System.Drawing.Size(34, 13);
            this.linkSite.TabIndex = 12;
            this.linkSite.TabStop = true;
            this.linkSite.Text = "Сайт:";
            this.linkSite.Click += new System.EventHandler(this.GotoWebsite);
            // 
            // textSite
            // 
            this.textSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSite.Location = new System.Drawing.Point(89, 179);
            this.textSite.Name = "textSite";
            this.textSite.Size = new System.Drawing.Size(339, 20);
            this.textSite.TabIndex = 13;
            // 
            // linkSF
            // 
            this.linkSF.AutoSize = true;
            this.linkSF.Location = new System.Drawing.Point(15, 208);
            this.linkSF.Name = "linkSF";
            this.linkSF.Size = new System.Drawing.Size(68, 13);
            this.linkSF.TabIndex = 14;
            this.linkSF.TabStop = true;
            this.linkSF.Text = "Скриншоты:";
            this.linkSF.Click += new System.EventHandler(this.OpenScrFolder);
            // 
            // textSF
            // 
            this.textSF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSF.Location = new System.Drawing.Point(89, 205);
            this.textSF.Name = "textSF";
            this.textSF.Size = new System.Drawing.Size(274, 20);
            this.textSF.TabIndex = 15;
            // 
            // buttonBrowseSF
            // 
            this.buttonBrowseSF.Location = new System.Drawing.Point(369, 205);
            this.buttonBrowseSF.Name = "buttonBrowseSF";
            this.buttonBrowseSF.Size = new System.Drawing.Size(59, 20);
            this.buttonBrowseSF.TabIndex = 16;
            this.buttonBrowseSF.Text = "Обзор";
            this.buttonBrowseSF.UseVisualStyleBackColor = true;
            this.buttonBrowseSF.Click += new System.EventHandler(this.BrowseScrFolder);
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCover.ContextMenuStrip = this.cmCover;
            this.labelCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCover.Location = new System.Drawing.Point(29, 140);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(258, 26);
            this.labelCover.TabIndex = 0;
            this.labelCover.Text = "Нажмите здесь левой или правой кнопкой мыши\r\nили перетащите сюда файл изображения" +
    "";
            this.labelCover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCover.Click += new System.EventHandler(this.SelectCover);
            // 
            // cmCover
            // 
            this.cmCover.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmCover.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmSelectCover,
            this.cmRemoveCover});
            this.cmCover.Name = "contextMenuStrip";
            this.cmCover.Size = new System.Drawing.Size(179, 48);
            // 
            // cmSelectCover
            // 
            this.cmSelectCover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmSelectCover.Name = "cmSelectCover";
            this.cmSelectCover.Size = new System.Drawing.Size(178, 22);
            this.cmSelectCover.Text = "Выбрать обложку";
            this.cmSelectCover.Click += new System.EventHandler(this.SelectCover);
            // 
            // cmRemoveCover
            // 
            this.cmRemoveCover.Name = "cmRemoveCover";
            this.cmRemoveCover.Size = new System.Drawing.Size(178, 22);
            this.cmRemoveCover.Text = "Удалить";
            this.cmRemoveCover.Click += new System.EventHandler(this.RemoveCover);
            // 
            // buttonDelEvent
            // 
            this.buttonDelEvent.Enabled = false;
            this.buttonDelEvent.Image = global::My_Games.Properties.Resources.remove;
            this.buttonDelEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelEvent.Location = new System.Drawing.Point(178, 19);
            this.buttonDelEvent.Name = "buttonDelEvent";
            this.buttonDelEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonDelEvent.TabIndex = 2;
            this.buttonDelEvent.Text = "Удалить";
            this.buttonDelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelEvent.UseVisualStyleBackColor = true;
            this.buttonDelEvent.Click += new System.EventHandler(this.RemoveEvent);
            // 
            // buttonChangeEvent
            // 
            this.buttonChangeEvent.Enabled = false;
            this.buttonChangeEvent.Image = global::My_Games.Properties.Resources.edit;
            this.buttonChangeEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeEvent.Location = new System.Drawing.Point(92, 19);
            this.buttonChangeEvent.Name = "buttonChangeEvent";
            this.buttonChangeEvent.Size = new System.Drawing.Size(80, 23);
            this.buttonChangeEvent.TabIndex = 1;
            this.buttonChangeEvent.Text = "Изменить";
            this.buttonChangeEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeEvent.UseVisualStyleBackColor = true;
            this.buttonChangeEvent.Click += new System.EventHandler(this.EditEvent);
            // 
            // groupBoxComment
            // 
            this.groupBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxComment.Controls.Add(this.textBoxComment);
            this.groupBoxComment.Location = new System.Drawing.Point(6, 338);
            this.groupBoxComment.Name = "groupBoxComment";
            this.groupBoxComment.Size = new System.Drawing.Size(740, 138);
            this.groupBoxComment.TabIndex = 3;
            this.groupBoxComment.TabStop = false;
            this.groupBoxComment.Text = "Описание";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfo.Location = new System.Drawing.Point(41, 43);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 25;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPagePurchases);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Controls.Add(this.tabPageNotes);
            this.tabControl.Controls.Add(this.tabPageOthers);
            this.tabControl.ImageList = this.imageListTabs;
            this.tabControl.ItemSize = new System.Drawing.Size(120, 24);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 508);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabPageMain
            // 
            this.tabPageMain.AllowDrop = true;
            this.tabPageMain.Controls.Add(this.groupBoxInfo);
            this.tabPageMain.Controls.Add(this.groupBoxMain);
            this.tabPageMain.Controls.Add(this.labelCover);
            this.tabPageMain.Controls.Add(this.groupBoxComment);
            this.tabPageMain.Controls.Add(this.pictureBoxCover);
            this.tabPageMain.Location = new System.Drawing.Point(4, 28);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(752, 476);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Общие";
            this.tabPageMain.UseVisualStyleBackColor = true;
            this.tabPageMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.TabPageMain_DragDrop);
            this.tabPageMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.TabPageMain_DragEnter);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.Controls.Add(this.labelHis);
            this.groupBoxInfo.Controls.Add(this.labelDLCs);
            this.groupBoxInfo.Controls.Add(this.labelVers);
            this.groupBoxInfo.Controls.Add(this.label9);
            this.groupBoxInfo.Controls.Add(this.label8);
            this.groupBoxInfo.Controls.Add(this.label7);
            this.groupBoxInfo.Location = new System.Drawing.Point(312, 248);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(434, 84);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация о коллекции";
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
            // labelDLCs
            // 
            this.labelDLCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDLCs.Location = new System.Drawing.Point(106, 38);
            this.labelDLCs.Name = "labelDLCs";
            this.labelDLCs.Size = new System.Drawing.Size(322, 13);
            this.labelDLCs.TabIndex = 3;
            // 
            // labelVers
            // 
            this.labelVers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVers.Location = new System.Drawing.Point(106, 20);
            this.labelVers.Name = "labelVers";
            this.labelVers.Size = new System.Drawing.Size(322, 13);
            this.labelVers.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Пройдена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Доп. материалы:";
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
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxCover.ContextMenuStrip = this.cmCover;
            this.pictureBoxCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCover.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 19;
            this.pictureBoxCover.TabStop = false;
            this.pictureBoxCover.Click += new System.EventHandler(this.SelectCover);
            // 
            // tabPagePurchases
            // 
            this.tabPagePurchases.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePurchases.Controls.Add(this.panelDLCs);
            this.tabPagePurchases.Controls.Add(this.splitter);
            this.tabPagePurchases.Controls.Add(this.panelVersion);
            this.tabPagePurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPagePurchases.ImageIndex = 0;
            this.tabPagePurchases.Location = new System.Drawing.Point(4, 28);
            this.tabPagePurchases.Name = "tabPagePurchases";
            this.tabPagePurchases.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchases.Size = new System.Drawing.Size(752, 476);
            this.tabPagePurchases.TabIndex = 1;
            this.tabPagePurchases.Text = "Покупки";
            this.tabPagePurchases.UseVisualStyleBackColor = true;
            this.tabPagePurchases.SizeChanged += new System.EventHandler(this.TabPageVersions_SizeChanged);
            // 
            // panelDLCs
            // 
            this.panelDLCs.Controls.Add(this.groupBoxDLCs);
            this.panelDLCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDLCs.Location = new System.Drawing.Point(3, 254);
            this.panelDLCs.Name = "panelDLCs";
            this.panelDLCs.Size = new System.Drawing.Size(746, 219);
            this.panelDLCs.TabIndex = 6;
            // 
            // groupBoxDLCs
            // 
            this.groupBoxDLCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDLCs.Controls.Add(this.buttonAddDLC);
            this.groupBoxDLCs.Controls.Add(this.buttonDelDLC);
            this.groupBoxDLCs.Controls.Add(this.buttonChangeDLC);
            this.groupBoxDLCs.Controls.Add(this.listViewDLCs);
            this.groupBoxDLCs.Location = new System.Drawing.Point(3, 6);
            this.groupBoxDLCs.Name = "groupBoxDLCs";
            this.groupBoxDLCs.Size = new System.Drawing.Size(740, 211);
            this.groupBoxDLCs.TabIndex = 14;
            this.groupBoxDLCs.TabStop = false;
            this.groupBoxDLCs.Text = "Дополнительные материалы";
            // 
            // buttonAddDLC
            // 
            this.buttonAddDLC.Image = global::My_Games.Properties.Resources.add;
            this.buttonAddDLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDLC.Location = new System.Drawing.Point(6, 19);
            this.buttonAddDLC.Name = "buttonAddDLC";
            this.buttonAddDLC.Size = new System.Drawing.Size(80, 23);
            this.buttonAddDLC.TabIndex = 10;
            this.buttonAddDLC.Text = "Добавить";
            this.buttonAddDLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddDLC.UseVisualStyleBackColor = true;
            this.buttonAddDLC.Click += new System.EventHandler(this.AddDLC);
            // 
            // buttonDelDLC
            // 
            this.buttonDelDLC.Enabled = false;
            this.buttonDelDLC.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelDLC.Image")));
            this.buttonDelDLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelDLC.Location = new System.Drawing.Point(178, 19);
            this.buttonDelDLC.Name = "buttonDelDLC";
            this.buttonDelDLC.Size = new System.Drawing.Size(75, 23);
            this.buttonDelDLC.TabIndex = 12;
            this.buttonDelDLC.Text = "Удалить";
            this.buttonDelDLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelDLC.UseVisualStyleBackColor = true;
            this.buttonDelDLC.Click += new System.EventHandler(this.RemoveDLC);
            // 
            // buttonChangeDLC
            // 
            this.buttonChangeDLC.Enabled = false;
            this.buttonChangeDLC.Image = ((System.Drawing.Image)(resources.GetObject("buttonChangeDLC.Image")));
            this.buttonChangeDLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeDLC.Location = new System.Drawing.Point(92, 19);
            this.buttonChangeDLC.Name = "buttonChangeDLC";
            this.buttonChangeDLC.Size = new System.Drawing.Size(80, 23);
            this.buttonChangeDLC.TabIndex = 11;
            this.buttonChangeDLC.Text = "Изменить";
            this.buttonChangeDLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeDLC.UseVisualStyleBackColor = true;
            this.buttonChangeDLC.Click += new System.EventHandler(this.EditDLC);
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
            this.listViewDLCs.Location = new System.Drawing.Point(6, 48);
            this.listViewDLCs.MultiSelect = false;
            this.listViewDLCs.Name = "listViewDLCs";
            this.listViewDLCs.Size = new System.Drawing.Size(728, 156);
            this.listViewDLCs.TabIndex = 13;
            this.listViewDLCs.UseCompatibleStateImageBehavior = false;
            this.listViewDLCs.View = System.Windows.Forms.View.Details;
            this.listViewDLCs.SelectedIndexChanged += new System.EventHandler(this.ListViewDLCs_SelectedIndexChanged);
            this.listViewDLCs.DoubleClick += new System.EventHandler(this.EditDLC);
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
            this.columnDLCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnDLCPrice.Width = 45;
            // 
            // columnDLCComment
            // 
            this.columnDLCComment.Text = "Комментарий";
            this.columnDLCComment.Width = 400;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(3, 244);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(746, 10);
            this.splitter.TabIndex = 5;
            this.splitter.TabStop = false;
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.groupBoxVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVersion.Location = new System.Drawing.Point(3, 3);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(746, 241);
            this.panelVersion.TabIndex = 4;
            // 
            // groupBoxVersion
            // 
            this.groupBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVersion.Controls.Add(this.buttonAddVersion);
            this.groupBoxVersion.Controls.Add(this.buttonDelVersion);
            this.groupBoxVersion.Controls.Add(this.listViewVersions);
            this.groupBoxVersion.Controls.Add(this.buttonChangeVersion);
            this.groupBoxVersion.Location = new System.Drawing.Point(3, 3);
            this.groupBoxVersion.Name = "groupBoxVersion";
            this.groupBoxVersion.Size = new System.Drawing.Size(740, 232);
            this.groupBoxVersion.TabIndex = 4;
            this.groupBoxVersion.TabStop = false;
            this.groupBoxVersion.Text = "Версии";
            // 
            // buttonAddVersion
            // 
            this.buttonAddVersion.Image = global::My_Games.Properties.Resources.add;
            this.buttonAddVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddVersion.Location = new System.Drawing.Point(6, 19);
            this.buttonAddVersion.Name = "buttonAddVersion";
            this.buttonAddVersion.Size = new System.Drawing.Size(80, 23);
            this.buttonAddVersion.TabIndex = 0;
            this.buttonAddVersion.Text = "Добавить";
            this.buttonAddVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddVersion.UseVisualStyleBackColor = true;
            this.buttonAddVersion.Click += new System.EventHandler(this.AddVersion);
            // 
            // buttonDelVersion
            // 
            this.buttonDelVersion.Enabled = false;
            this.buttonDelVersion.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelVersion.Image")));
            this.buttonDelVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelVersion.Location = new System.Drawing.Point(178, 19);
            this.buttonDelVersion.Name = "buttonDelVersion";
            this.buttonDelVersion.Size = new System.Drawing.Size(75, 23);
            this.buttonDelVersion.TabIndex = 2;
            this.buttonDelVersion.Text = "Удалить";
            this.buttonDelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelVersion.UseVisualStyleBackColor = true;
            this.buttonDelVersion.Click += new System.EventHandler(this.removeVersion);
            // 
            // buttonChangeVersion
            // 
            this.buttonChangeVersion.Enabled = false;
            this.buttonChangeVersion.Image = ((System.Drawing.Image)(resources.GetObject("buttonChangeVersion.Image")));
            this.buttonChangeVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeVersion.Location = new System.Drawing.Point(92, 19);
            this.buttonChangeVersion.Name = "buttonChangeVersion";
            this.buttonChangeVersion.Size = new System.Drawing.Size(80, 23);
            this.buttonChangeVersion.TabIndex = 1;
            this.buttonChangeVersion.Text = "Изменить";
            this.buttonChangeVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeVersion.UseVisualStyleBackColor = true;
            this.buttonChangeVersion.Click += new System.EventHandler(this.EditVersion);
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.groupBoxHistory);
            this.tabPageHistory.ImageIndex = 1;
            this.tabPageHistory.Location = new System.Drawing.Point(4, 28);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(752, 476);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "История";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHistory.Controls.Add(this.buttonAddEvent);
            this.groupBoxHistory.Controls.Add(this.buttonDelEvent);
            this.groupBoxHistory.Controls.Add(this.listViewHistory);
            this.groupBoxHistory.Controls.Add(this.buttonChangeEvent);
            this.groupBoxHistory.Location = new System.Drawing.Point(6, 6);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(740, 470);
            this.groupBoxHistory.TabIndex = 4;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "История прохождения";
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Image = global::My_Games.Properties.Resources.add;
            this.buttonAddEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEvent.Location = new System.Drawing.Point(6, 19);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(80, 23);
            this.buttonAddEvent.TabIndex = 0;
            this.buttonAddEvent.Text = "Добавить";
            this.buttonAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.AddEvent);
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.Controls.Add(this.groupBoxNotes);
            this.tabPageNotes.ImageIndex = 2;
            this.tabPageNotes.Location = new System.Drawing.Point(4, 28);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotes.Size = new System.Drawing.Size(752, 476);
            this.tabPageNotes.TabIndex = 4;
            this.tabPageNotes.Text = "Заметки";
            this.tabPageNotes.UseVisualStyleBackColor = true;
            // 
            // groupBoxNotes
            // 
            this.groupBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNotes.Controls.Add(this.label10);
            this.groupBoxNotes.Controls.Add(this.label2);
            this.groupBoxNotes.Controls.Add(this.buttonNoteAdd);
            this.groupBoxNotes.Controls.Add(this.textBoxNoteName);
            this.groupBoxNotes.Controls.Add(this.listViewNotes);
            this.groupBoxNotes.Controls.Add(this.dateTimeNote);
            this.groupBoxNotes.Controls.Add(this.buttonNoteDel);
            this.groupBoxNotes.Controls.Add(this.textBoxNote);
            this.groupBoxNotes.Location = new System.Drawing.Point(6, 6);
            this.groupBoxNotes.Name = "groupBoxNotes";
            this.groupBoxNotes.Size = new System.Drawing.Size(740, 464);
            this.groupBoxNotes.TabIndex = 11;
            this.groupBoxNotes.TabStop = false;
            this.groupBoxNotes.Text = "Заметки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заголовок:";
            // 
            // buttonNoteAdd
            // 
            this.buttonNoteAdd.Image = global::My_Games.Properties.Resources.add;
            this.buttonNoteAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNoteAdd.Location = new System.Drawing.Point(6, 19);
            this.buttonNoteAdd.Name = "buttonNoteAdd";
            this.buttonNoteAdd.Size = new System.Drawing.Size(80, 23);
            this.buttonNoteAdd.TabIndex = 0;
            this.buttonNoteAdd.Text = "Добавить";
            this.buttonNoteAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNoteAdd.UseVisualStyleBackColor = true;
            this.buttonNoteAdd.Click += new System.EventHandler(this.AddNote);
            // 
            // textBoxNoteName
            // 
            this.textBoxNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNoteName.Enabled = false;
            this.textBoxNoteName.Location = new System.Drawing.Point(339, 47);
            this.textBoxNoteName.Name = "textBoxNoteName";
            this.textBoxNoteName.Size = new System.Drawing.Size(395, 20);
            this.textBoxNoteName.TabIndex = 4;
            this.textBoxNoteName.TextChanged += new System.EventHandler(this.TextBoxNoteName_TextChanged);
            // 
            // listViewNotes
            // 
            this.listViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewNotes.FullRowSelect = true;
            this.listViewNotes.GridLines = true;
            this.listViewNotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewNotes.HideSelection = false;
            this.listViewNotes.Location = new System.Drawing.Point(6, 48);
            this.listViewNotes.MultiSelect = false;
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(260, 410);
            this.listViewNotes.TabIndex = 2;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            this.listViewNotes.View = System.Windows.Forms.View.Details;
            this.listViewNotes.SelectedIndexChanged += new System.EventHandler(this.ListViewNotes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Заметка";
            this.columnHeader2.Width = 160;
            // 
            // dateTimeNote
            // 
            this.dateTimeNote.Enabled = false;
            this.dateTimeNote.Location = new System.Drawing.Point(339, 21);
            this.dateTimeNote.Name = "dateTimeNote";
            this.dateTimeNote.Size = new System.Drawing.Size(140, 20);
            this.dateTimeNote.TabIndex = 3;
            this.dateTimeNote.ValueChanged += new System.EventHandler(this.DateTimeNote_ValueChanged);
            // 
            // buttonNoteDel
            // 
            this.buttonNoteDel.Enabled = false;
            this.buttonNoteDel.Image = global::My_Games.Properties.Resources.remove;
            this.buttonNoteDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNoteDel.Location = new System.Drawing.Point(92, 19);
            this.buttonNoteDel.Name = "buttonNoteDel";
            this.buttonNoteDel.Size = new System.Drawing.Size(75, 23);
            this.buttonNoteDel.TabIndex = 1;
            this.buttonNoteDel.Text = "Удалить";
            this.buttonNoteDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNoteDel.UseVisualStyleBackColor = true;
            this.buttonNoteDel.Click += new System.EventHandler(this.RemoveNote);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNote.Enabled = false;
            this.textBoxNote.Location = new System.Drawing.Point(272, 76);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(462, 382);
            this.textBoxNote.TabIndex = 5;
            this.textBoxNote.TextChanged += new System.EventHandler(this.TextBoxNote_TextChanged);
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.Controls.Add(this.labelInfo);
            this.tabPageOthers.Controls.Add(this.checkHidden);
            this.tabPageOthers.Location = new System.Drawing.Point(4, 28);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOthers.Size = new System.Drawing.Size(752, 476);
            this.tabPageOthers.TabIndex = 5;
            this.tabPageOthers.Text = "Прочее";
            this.tabPageOthers.UseVisualStyleBackColor = true;
            // 
            // imageListTabs
            // 
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "purchase.png");
            this.imageListTabs.Images.SetKeyName(1, "winner.png");
            this.imageListTabs.Images.SetKeyName(2, "notes.png");
            // 
            // checkHidden
            // 
            this.checkHidden.AutoSize = true;
            this.checkHidden.Location = new System.Drawing.Point(44, 283);
            this.checkHidden.Name = "checkHidden";
            this.checkHidden.Size = new System.Drawing.Size(89, 17);
            this.checkHidden.TabIndex = 26;
            this.checkHidden.Text = "Скрыть игру";
            this.checkHidden.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AllowDrop = true;
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
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.cmCover.ResumeLayout(false);
            this.groupBoxComment.ResumeLayout(false);
            this.groupBoxComment.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabPagePurchases.ResumeLayout(false);
            this.panelDLCs.ResumeLayout(false);
            this.groupBoxDLCs.ResumeLayout(false);
            this.panelVersion.ResumeLayout(false);
            this.groupBoxVersion.ResumeLayout(false);
            this.tabPageHistory.ResumeLayout(false);
            this.groupBoxHistory.ResumeLayout(false);
            this.tabPageNotes.ResumeLayout(false);
            this.groupBoxNotes.ResumeLayout(false);
            this.groupBoxNotes.PerformLayout();
            this.tabPageOthers.ResumeLayout(false);
            this.tabPageOthers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.ListView listViewVersions;
        private System.Windows.Forms.ColumnHeader columnVerDate;
        private System.Windows.Forms.ColumnHeader columnVerPlatform;
        private System.Windows.Forms.ColumnHeader columnVerCarrier;
        private System.Windows.Forms.ColumnHeader columnVerPrice;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnEventDate;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader columnEventComment;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonAddVersion;
        private System.Windows.Forms.Button buttonDelEvent;
        private System.Windows.Forms.Button buttonChangeEvent;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.GroupBox groupBoxComment;
        private System.Windows.Forms.Button buttonChangeVersion;
        private System.Windows.Forms.Button buttonDelVersion;
        private System.Windows.Forms.ColumnHeader columnEventHours;
        private System.Windows.Forms.ColumnHeader columnEventPlatform;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.ComboBox comboRate;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.LinkLabel linkGenre;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textSite;
        private System.Windows.Forms.LinkLabel linkSite;
        private System.Windows.Forms.ColumnHeader columnVerComment;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPagePurchases;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.Label labelHis;
        private System.Windows.Forms.Label labelDLCs;
        private System.Windows.Forms.Label labelVers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonNoteDel;
        private System.Windows.Forms.Button buttonNoteAdd;
        private System.Windows.Forms.ListView listViewNotes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxNoteName;
        private System.Windows.Forms.DateTimePicker dateTimeNote;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Panel panelDLCs;
        private System.Windows.Forms.Button buttonDelDLC;
        private System.Windows.Forms.Button buttonAddDLC;
        private System.Windows.Forms.ListView listViewDLCs;
        private System.Windows.Forms.ColumnHeader columnDLCDate;
        private System.Windows.Forms.ColumnHeader columnDLCPlatform;
        private System.Windows.Forms.ColumnHeader columnDLCName;
        private System.Windows.Forms.ColumnHeader columnDLCPrice;
        private System.Windows.Forms.ColumnHeader columnDLCComment;
        private System.Windows.Forms.Button buttonChangeDLC;
        private System.Windows.Forms.GroupBox groupBoxDLCs;
        private System.Windows.Forms.GroupBox groupBoxVersion;
        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.GroupBox groupBoxNotes;
        private System.Windows.Forms.TextBox textPublisher;
        private System.Windows.Forms.TextBox textDeveloper;
        private System.Windows.Forms.ImageList imageListTabs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmCover;
        private System.Windows.Forms.ToolStripMenuItem cmSelectCover;
        private System.Windows.Forms.ToolStripMenuItem cmRemoveCover;
        private System.Windows.Forms.ColumnHeader columnEventHoursAll;
        private System.Windows.Forms.Button buttonBrowseSF;
        private System.Windows.Forms.LinkLabel linkSF;
        private System.Windows.Forms.TextBox textSF;
        private System.Windows.Forms.CheckBox checkHidden;
    }
}