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
            this.labelRating = new System.Windows.Forms.Label();
            this.listViewVersions = new System.Windows.Forms.ListView();
            this.columnVerDate = new System.Windows.Forms.ColumnHeader();
            this.columnVerPlatform = new System.Windows.Forms.ColumnHeader();
            this.columnVerCarrier = new System.Windows.Forms.ColumnHeader();
            this.columnVerPrice = new System.Windows.Forms.ColumnHeader();
            this.columnVerComment = new System.Windows.Forms.ColumnHeader();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnEventDate = new System.Windows.Forms.ColumnHeader();
            this.columnEventPlatform = new System.Windows.Forms.ColumnHeader();
            this.columnEvent = new System.Windows.Forms.ColumnHeader();
            this.columnEventHours = new System.Windows.Forms.ColumnHeader();
            this.columnEventComment = new System.Windows.Forms.ColumnHeader();
            this.textComment = new System.Windows.Forms.TextBox();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.textPublisher = new System.Windows.Forms.TextBox();
            this.textDeveloper = new System.Windows.Forms.TextBox();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.linkGenre = new System.Windows.Forms.LinkLabel();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.comboRating = new System.Windows.Forms.ComboBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.labelCover = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьОбложкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.buttonChangeVersion = new System.Windows.Forms.Button();
            this.buttonDelVersion = new System.Windows.Forms.Button();
            this.buttonAddVersion = new System.Windows.Forms.Button();
            this.buttonDelEvent = new System.Windows.Forms.Button();
            this.buttonChangeEvent = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.groupComment = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.labelPlayed = new System.Windows.Forms.Label();
            this.labelDLCs = new System.Windows.Forms.Label();
            this.labelVersions = new System.Windows.Forms.Label();
            this.labelPlayedL = new System.Windows.Forms.Label();
            this.labelDLCsL = new System.Windows.Forms.Label();
            this.labelVersionsL = new System.Windows.Forms.Label();
            this.tabPagePurchases = new System.Windows.Forms.TabPage();
            this.panelDLCs = new System.Windows.Forms.Panel();
            this.groupBoxDLCs = new System.Windows.Forms.GroupBox();
            this.buttonAddDLC = new System.Windows.Forms.Button();
            this.buttonDelDLC = new System.Windows.Forms.Button();
            this.buttonChangeDLC = new System.Windows.Forms.Button();
            this.listViewDLCs = new System.Windows.Forms.ListView();
            this.columnDLCDate = new System.Windows.Forms.ColumnHeader();
            this.columnDLCPlatform = new System.Windows.Forms.ColumnHeader();
            this.columnDLCName = new System.Windows.Forms.ColumnHeader();
            this.columnDLCPrice = new System.Windows.Forms.ColumnHeader();
            this.columnDLCComment = new System.Windows.Forms.ColumnHeader();
            this.splitter = new System.Windows.Forms.Splitter();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.groupBoxVersion = new System.Windows.Forms.GroupBox();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.groupBoxNotes = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNoteAdd = new System.Windows.Forms.Button();
            this.textBoxNoteName = new System.Windows.Forms.TextBox();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.dateTimeNote = new System.Windows.Forms.DateTimePicker();
            this.buttonNoteDel = new System.Windows.Forms.Button();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.tabPageOthers = new System.Windows.Forms.TabPage();
            this.imageListTabs = new System.Windows.Forms.ImageList(this.components);
            this.labelSite = new System.Windows.Forms.Label();
            this.groupMain.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.groupComment.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupInfo.SuspendLayout();
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
            this.labelName.Location = new System.Drawing.Point(145, 60);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 45);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Игра:";
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(255, 57);
            this.textName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(673, 50);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // comboGenre
            // 
            this.comboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(255, 318);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(673, 53);
            this.comboGenre.TabIndex = 9;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(81, 190);
            this.labelPublisher.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(162, 45);
            this.labelPublisher.TabIndex = 4;
            this.labelPublisher.Text = "Издатель:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(47, 257);
            this.labelYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(196, 45);
            this.labelYear.TabIndex = 6;
            this.labelYear.Text = "Год выхода:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(1250, 1229);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(200, 57);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(1462, 1229);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 57);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(106, 387);
            this.labelRating.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(137, 45);
            this.labelRating.TabIndex = 10;
            this.labelRating.Text = "Оценка:";
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
            this.listViewVersions.Location = new System.Drawing.Point(13, 118);
            this.listViewVersions.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listViewVersions.MultiSelect = false;
            this.listViewVersions.Name = "listViewVersions";
            this.listViewVersions.Size = new System.Drawing.Size(1576, 432);
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
            this.columnEventHours,
            this.columnEventComment});
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.GridLines = true;
            this.listViewHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewHistory.Location = new System.Drawing.Point(13, 118);
            this.listViewHistory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(1573, 953);
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
            this.columnEventHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnEventHours.Width = 45;
            // 
            // columnEventComment
            // 
            this.columnEventComment.Text = "Комментарий";
            this.columnEventComment.Width = 400;
            // 
            // textComment
            // 
            this.textComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textComment.Location = new System.Drawing.Point(13, 57);
            this.textComment.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(1579, 265);
            this.textComment.TabIndex = 0;
            // 
            // groupMain
            // 
            this.groupMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMain.Controls.Add(this.labelName);
            this.groupMain.Controls.Add(this.textName);
            this.groupMain.Controls.Add(this.labelDeveloper);
            this.groupMain.Controls.Add(this.textDeveloper);
            this.groupMain.Controls.Add(this.labelPublisher);
            this.groupMain.Controls.Add(this.textPublisher);
            this.groupMain.Controls.Add(this.labelYear);
            this.groupMain.Controls.Add(this.textYear);
            this.groupMain.Controls.Add(this.linkGenre);
            this.groupMain.Controls.Add(this.comboGenre);
            this.groupMain.Controls.Add(this.labelRating);
            this.groupMain.Controls.Add(this.comboRating);
            this.groupMain.Controls.Add(this.labelSite);
            this.groupMain.Controls.Add(this.textBoxSite);
            this.groupMain.Location = new System.Drawing.Point(676, 15);
            this.groupMain.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupMain.Name = "groupMain";
            this.groupMain.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupMain.Size = new System.Drawing.Size(940, 517);
            this.groupMain.TabIndex = 1;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Общие сведения";
            // 
            // textPublisher
            // 
            this.textPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPublisher.Location = new System.Drawing.Point(255, 187);
            this.textPublisher.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Size = new System.Drawing.Size(673, 50);
            this.textPublisher.TabIndex = 5;
            // 
            // textDeveloper
            // 
            this.textDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDeveloper.Location = new System.Drawing.Point(255, 121);
            this.textDeveloper.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textDeveloper.Name = "textDeveloper";
            this.textDeveloper.Size = new System.Drawing.Size(673, 50);
            this.textDeveloper.TabIndex = 3;
            // 
            // textBoxSite
            // 
            this.textBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSite.Location = new System.Drawing.Point(255, 451);
            this.textBoxSite.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(673, 50);
            this.textBoxSite.TabIndex = 13;
            // 
            // linkGenre
            // 
            this.linkGenre.AutoSize = true;
            this.linkGenre.Location = new System.Drawing.Point(135, 321);
            this.linkGenre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkGenre.Name = "linkGenre";
            this.linkGenre.Size = new System.Drawing.Size(108, 45);
            this.linkGenre.TabIndex = 8;
            this.linkGenre.TabStop = true;
            this.linkGenre.Text = "Жанр:";
            this.linkGenre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(29, 124);
            this.labelDeveloper.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(214, 45);
            this.labelDeveloper.TabIndex = 2;
            this.labelDeveloper.Text = "Разработчик:";
            // 
            // comboRating
            // 
            this.comboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRating.FormattingEnabled = true;
            this.comboRating.Location = new System.Drawing.Point(255, 384);
            this.comboRating.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboRating.Name = "comboRating";
            this.comboRating.Size = new System.Drawing.Size(172, 53);
            this.comboRating.TabIndex = 11;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(255, 254);
            this.textYear.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(172, 50);
            this.textYear.TabIndex = 7;
            // 
            // labelCover
            // 
            this.labelCover.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCover.ContextMenuStrip = this.contextMenuStrip;
            this.labelCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCover.Location = new System.Drawing.Point(12, 258);
            this.labelCover.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(650, 201);
            this.labelCover.TabIndex = 0;
            this.labelCover.Text = "Нажмите здесь левой или правой кнопкой мыши\r\nили перетащите сюда файл изображения" +
    "";
            this.labelCover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCover.Click += new System.EventHandler(this.SelectCover);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьОбложкуToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(319, 84);
            // 
            // выбратьОбложкуToolStripMenuItem
            // 
            this.выбратьОбложкуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.выбратьОбложкуToolStripMenuItem.Name = "выбратьОбложкуToolStripMenuItem";
            this.выбратьОбложкуToolStripMenuItem.Size = new System.Drawing.Size(318, 40);
            this.выбратьОбложкуToolStripMenuItem.Text = "Выбрать обложку";
            this.выбратьОбложкуToolStripMenuItem.Click += new System.EventHandler(this.SelectCover);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::My_Games.Properties.Resources.remove;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(318, 40);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteCover);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxCover.ContextMenuStrip = this.contextMenuStrip;
            this.pictureBoxCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCover.Location = new System.Drawing.Point(12, 14);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(650, 647);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 19;
            this.pictureBoxCover.TabStop = false;
            this.pictureBoxCover.Click += new System.EventHandler(this.SelectCover);
            // 
            // buttonChangeVersion
            // 
            this.buttonChangeVersion.Enabled = false;
            this.buttonChangeVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeVersion.Image = global::My_Games.Properties.Resources.edit;
            this.buttonChangeVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeVersion.Location = new System.Drawing.Point(245, 47);
            this.buttonChangeVersion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonChangeVersion.Name = "buttonChangeVersion";
            this.buttonChangeVersion.Size = new System.Drawing.Size(220, 57);
            this.buttonChangeVersion.TabIndex = 1;
            this.buttonChangeVersion.Text = "Изменить";
            this.buttonChangeVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeVersion.UseVisualStyleBackColor = true;
            this.buttonChangeVersion.Click += new System.EventHandler(this.buttonChangeVersion_Click);
            // 
            // buttonDelVersion
            // 
            this.buttonDelVersion.Enabled = false;
            this.buttonDelVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelVersion.Image = global::My_Games.Properties.Resources.remove;
            this.buttonDelVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelVersion.Location = new System.Drawing.Point(477, 47);
            this.buttonDelVersion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonDelVersion.Name = "buttonDelVersion";
            this.buttonDelVersion.Size = new System.Drawing.Size(200, 57);
            this.buttonDelVersion.TabIndex = 2;
            this.buttonDelVersion.Text = "Удалить";
            this.buttonDelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelVersion.UseVisualStyleBackColor = true;
            this.buttonDelVersion.Click += new System.EventHandler(this.buttonDelVersion_Click);
            // 
            // buttonAddVersion
            // 
            this.buttonAddVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddVersion.Image = global::My_Games.Properties.Resources.add;
            this.buttonAddVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddVersion.Location = new System.Drawing.Point(13, 47);
            this.buttonAddVersion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonAddVersion.Name = "buttonAddVersion";
            this.buttonAddVersion.Size = new System.Drawing.Size(220, 57);
            this.buttonAddVersion.TabIndex = 0;
            this.buttonAddVersion.Text = "Добавить";
            this.buttonAddVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddVersion.UseVisualStyleBackColor = true;
            this.buttonAddVersion.Click += new System.EventHandler(this.buttonAddVersion_Click);
            // 
            // buttonDelEvent
            // 
            this.buttonDelEvent.Enabled = false;
            this.buttonDelEvent.Image = global::My_Games.Properties.Resources.remove;
            this.buttonDelEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelEvent.Location = new System.Drawing.Point(477, 47);
            this.buttonDelEvent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonDelEvent.Name = "buttonDelEvent";
            this.buttonDelEvent.Size = new System.Drawing.Size(200, 57);
            this.buttonDelEvent.TabIndex = 2;
            this.buttonDelEvent.Text = "Удалить";
            this.buttonDelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelEvent.UseVisualStyleBackColor = true;
            this.buttonDelEvent.Click += new System.EventHandler(this.buttonDelEvent_Click);
            // 
            // buttonChangeEvent
            // 
            this.buttonChangeEvent.Enabled = false;
            this.buttonChangeEvent.Image = global::My_Games.Properties.Resources.edit;
            this.buttonChangeEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeEvent.Location = new System.Drawing.Point(245, 47);
            this.buttonChangeEvent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonChangeEvent.Name = "buttonChangeEvent";
            this.buttonChangeEvent.Size = new System.Drawing.Size(220, 57);
            this.buttonChangeEvent.TabIndex = 1;
            this.buttonChangeEvent.Text = "Изменить";
            this.buttonChangeEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeEvent.UseVisualStyleBackColor = true;
            this.buttonChangeEvent.Click += new System.EventHandler(this.buttonChangeEvent_Click);
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Image = global::My_Games.Properties.Resources.add;
            this.buttonAddEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEvent.Location = new System.Drawing.Point(13, 47);
            this.buttonAddEvent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(220, 57);
            this.buttonAddEvent.TabIndex = 0;
            this.buttonAddEvent.Text = "Добавить";
            this.buttonAddEvent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // groupComment
            // 
            this.groupComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupComment.Controls.Add(this.textComment);
            this.groupComment.Location = new System.Drawing.Point(12, 769);
            this.groupComment.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupComment.Name = "groupComment";
            this.groupComment.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupComment.Size = new System.Drawing.Size(1604, 336);
            this.groupComment.TabIndex = 3;
            this.groupComment.TabStop = false;
            this.groupComment.Text = "Описание";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfo.Location = new System.Drawing.Point(89, 106);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 45);
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
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ImageList = this.imageListTabs;
            this.tabControl.ItemSize = new System.Drawing.Size(300, 64);
            this.tabControl.Location = new System.Drawing.Point(15, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1647, 1199);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabPageMain
            // 
            this.tabPageMain.AllowDrop = true;
            this.tabPageMain.Controls.Add(this.pictureBoxCover);
            this.tabPageMain.Controls.Add(this.labelCover);
            this.tabPageMain.Controls.Add(this.groupMain);
            this.tabPageMain.Controls.Add(this.groupInfo);
            this.tabPageMain.Controls.Add(this.groupComment);
            this.tabPageMain.Location = new System.Drawing.Point(8, 72);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageMain.Size = new System.Drawing.Size(1631, 1119);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Общие";
            this.tabPageMain.UseVisualStyleBackColor = true;
            this.tabPageMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.TabPageMain_DragDrop);
            this.tabPageMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.TabPageMain_DragEnter);
            // 
            // groupInfo
            // 
            this.groupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfo.Controls.Add(this.labelVersionsL);
            this.groupInfo.Controls.Add(this.labelVersions);
            this.groupInfo.Controls.Add(this.labelDLCsL);
            this.groupInfo.Controls.Add(this.labelDLCs);
            this.groupInfo.Controls.Add(this.labelPlayedL);
            this.groupInfo.Controls.Add(this.labelPlayed);
            this.groupInfo.Location = new System.Drawing.Point(676, 546);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupInfo.Size = new System.Drawing.Size(940, 209);
            this.groupInfo.TabIndex = 2;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Информация о коллекции";
            // 
            // labelPlayed
            // 
            this.labelPlayed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayed.Location = new System.Drawing.Point(255, 140);
            this.labelPlayed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlayed.Name = "labelPlayed";
            this.labelPlayed.Size = new System.Drawing.Size(673, 45);
            this.labelPlayed.TabIndex = 5;
            // 
            // labelDLCs
            // 
            this.labelDLCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDLCs.Location = new System.Drawing.Point(255, 95);
            this.labelDLCs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDLCs.Name = "labelDLCs";
            this.labelDLCs.Size = new System.Drawing.Size(673, 45);
            this.labelDLCs.TabIndex = 3;
            // 
            // labelVersions
            // 
            this.labelVersions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersions.Location = new System.Drawing.Point(255, 50);
            this.labelVersions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVersions.Name = "labelVersions";
            this.labelVersions.Size = new System.Drawing.Size(673, 45);
            this.labelVersions.TabIndex = 1;
            this.labelVersions.Text = "Тест";
            // 
            // labelPlayedL
            // 
            this.labelPlayedL.AutoSize = true;
            this.labelPlayedL.Location = new System.Drawing.Point(67, 140);
            this.labelPlayedL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlayedL.Name = "labelPlayedL";
            this.labelPlayedL.Size = new System.Drawing.Size(176, 45);
            this.labelPlayedL.TabIndex = 4;
            this.labelPlayedL.Text = "Пройдена:";
            // 
            // labelDLCsL
            // 
            this.labelDLCsL.AutoSize = true;
            this.labelDLCsL.Location = new System.Drawing.Point(83, 95);
            this.labelDLCsL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDLCsL.Name = "labelDLCsL";
            this.labelDLCsL.Size = new System.Drawing.Size(160, 45);
            this.labelDLCsL.TabIndex = 2;
            this.labelDLCsL.Text = "Доп. мат.:";
            // 
            // labelVersionsL
            // 
            this.labelVersionsL.AutoSize = true;
            this.labelVersionsL.Location = new System.Drawing.Point(109, 50);
            this.labelVersionsL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVersionsL.Name = "labelVersionsL";
            this.labelVersionsL.Size = new System.Drawing.Size(134, 45);
            this.labelVersionsL.TabIndex = 0;
            this.labelVersionsL.Text = "Версии:";
            // 
            // tabPagePurchases
            // 
            this.tabPagePurchases.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePurchases.Controls.Add(this.panelDLCs);
            this.tabPagePurchases.Controls.Add(this.splitter);
            this.tabPagePurchases.Controls.Add(this.panelVersion);
            this.tabPagePurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPagePurchases.ImageIndex = 0;
            this.tabPagePurchases.Location = new System.Drawing.Point(8, 72);
            this.tabPagePurchases.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPagePurchases.Name = "tabPagePurchases";
            this.tabPagePurchases.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPagePurchases.Size = new System.Drawing.Size(1631, 1119);
            this.tabPagePurchases.TabIndex = 1;
            this.tabPagePurchases.Text = "Покупки";
            this.tabPagePurchases.UseVisualStyleBackColor = true;
            this.tabPagePurchases.SizeChanged += new System.EventHandler(this.TabPageVersions_SizeChanged);
            // 
            // panelDLCs
            // 
            this.panelDLCs.Controls.Add(this.groupBoxDLCs);
            this.panelDLCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDLCs.Location = new System.Drawing.Point(6, 625);
            this.panelDLCs.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelDLCs.Name = "panelDLCs";
            this.panelDLCs.Size = new System.Drawing.Size(1619, 487);
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
            this.groupBoxDLCs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDLCs.Location = new System.Drawing.Point(6, 15);
            this.groupBoxDLCs.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxDLCs.Name = "groupBoxDLCs";
            this.groupBoxDLCs.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxDLCs.Size = new System.Drawing.Size(1606, 465);
            this.groupBoxDLCs.TabIndex = 14;
            this.groupBoxDLCs.TabStop = false;
            this.groupBoxDLCs.Text = "Дополнительные материалы";
            // 
            // buttonAddDLC
            // 
            this.buttonAddDLC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddDLC.Image = global::My_Games.Properties.Resources.add;
            this.buttonAddDLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDLC.Location = new System.Drawing.Point(13, 47);
            this.buttonAddDLC.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonAddDLC.Name = "buttonAddDLC";
            this.buttonAddDLC.Size = new System.Drawing.Size(220, 57);
            this.buttonAddDLC.TabIndex = 10;
            this.buttonAddDLC.Text = "Добавить";
            this.buttonAddDLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddDLC.UseVisualStyleBackColor = true;
            this.buttonAddDLC.Click += new System.EventHandler(this.buttonAddDLC_Click);
            // 
            // buttonDelDLC
            // 
            this.buttonDelDLC.Enabled = false;
            this.buttonDelDLC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelDLC.Image = global::My_Games.Properties.Resources.remove;
            this.buttonDelDLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelDLC.Location = new System.Drawing.Point(477, 47);
            this.buttonDelDLC.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonDelDLC.Name = "buttonDelDLC";
            this.buttonDelDLC.Size = new System.Drawing.Size(200, 57);
            this.buttonDelDLC.TabIndex = 12;
            this.buttonDelDLC.Text = "Удалить";
            this.buttonDelDLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelDLC.UseVisualStyleBackColor = true;
            this.buttonDelDLC.Click += new System.EventHandler(this.buttonDelDLC_Click);
            // 
            // buttonChangeDLC
            // 
            this.buttonChangeDLC.Enabled = false;
            this.buttonChangeDLC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangeDLC.Image = global::My_Games.Properties.Resources.edit;
            this.buttonChangeDLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeDLC.Location = new System.Drawing.Point(245, 47);
            this.buttonChangeDLC.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonChangeDLC.Name = "buttonChangeDLC";
            this.buttonChangeDLC.Size = new System.Drawing.Size(220, 57);
            this.buttonChangeDLC.TabIndex = 11;
            this.buttonChangeDLC.Text = "Изменить";
            this.buttonChangeDLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangeDLC.UseVisualStyleBackColor = true;
            this.buttonChangeDLC.Click += new System.EventHandler(this.buttonChangeDLC_Click);
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
            this.listViewDLCs.Location = new System.Drawing.Point(13, 118);
            this.listViewDLCs.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listViewDLCs.MultiSelect = false;
            this.listViewDLCs.Name = "listViewDLCs";
            this.listViewDLCs.Size = new System.Drawing.Size(1576, 326);
            this.listViewDLCs.TabIndex = 13;
            this.listViewDLCs.UseCompatibleStateImageBehavior = false;
            this.listViewDLCs.View = System.Windows.Forms.View.Details;
            this.listViewDLCs.SelectedIndexChanged += new System.EventHandler(this.ListViewDLCs_SelectedIndexChanged);
            this.listViewDLCs.DoubleClick += new System.EventHandler(this.ListViewDLCs_DoubleClick);
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
            this.splitter.Location = new System.Drawing.Point(6, 600);
            this.splitter.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1619, 25);
            this.splitter.TabIndex = 5;
            this.splitter.TabStop = false;
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.groupBoxVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVersion.Location = new System.Drawing.Point(6, 7);
            this.panelVersion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(1619, 593);
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
            this.groupBoxVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxVersion.Location = new System.Drawing.Point(6, 7);
            this.groupBoxVersion.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxVersion.Name = "groupBoxVersion";
            this.groupBoxVersion.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxVersion.Size = new System.Drawing.Size(1606, 571);
            this.groupBoxVersion.TabIndex = 4;
            this.groupBoxVersion.TabStop = false;
            this.groupBoxVersion.Text = "Версии";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.groupBoxHistory);
            this.tabPageHistory.ImageIndex = 1;
            this.tabPageHistory.Location = new System.Drawing.Point(8, 72);
            this.tabPageHistory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageHistory.Size = new System.Drawing.Size(1631, 1119);
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
            this.groupBoxHistory.Location = new System.Drawing.Point(13, 15);
            this.groupBoxHistory.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxHistory.Size = new System.Drawing.Size(1603, 1092);
            this.groupBoxHistory.TabIndex = 4;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "История прохождения";
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.Controls.Add(this.groupBoxNotes);
            this.tabPageNotes.ImageIndex = 2;
            this.tabPageNotes.Location = new System.Drawing.Point(8, 72);
            this.tabPageNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageNotes.Size = new System.Drawing.Size(1631, 1119);
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
            this.groupBoxNotes.Location = new System.Drawing.Point(13, 15);
            this.groupBoxNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxNotes.Name = "groupBoxNotes";
            this.groupBoxNotes.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBoxNotes.Size = new System.Drawing.Size(1603, 1093);
            this.groupBoxNotes.TabIndex = 11;
            this.groupBoxNotes.TabStop = false;
            this.groupBoxNotes.Text = "Заметки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(674, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 45);
            this.label10.TabIndex = 7;
            this.label10.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заголовок:";
            // 
            // buttonNoteAdd
            // 
            this.buttonNoteAdd.Image = global::My_Games.Properties.Resources.add;
            this.buttonNoteAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNoteAdd.Location = new System.Drawing.Point(13, 47);
            this.buttonNoteAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonNoteAdd.Name = "buttonNoteAdd";
            this.buttonNoteAdd.Size = new System.Drawing.Size(220, 57);
            this.buttonNoteAdd.TabIndex = 0;
            this.buttonNoteAdd.Text = "Добавить";
            this.buttonNoteAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNoteAdd.UseVisualStyleBackColor = true;
            this.buttonNoteAdd.Click += new System.EventHandler(this.ButtonNoteAdd_Click);
            // 
            // textBoxNoteName
            // 
            this.textBoxNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNoteName.Enabled = false;
            this.textBoxNoteName.Location = new System.Drawing.Point(780, 116);
            this.textBoxNoteName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxNoteName.Name = "textBoxNoteName";
            this.textBoxNoteName.Size = new System.Drawing.Size(805, 50);
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
            this.listViewNotes.Location = new System.Drawing.Point(13, 118);
            this.listViewNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.listViewNotes.MultiSelect = false;
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(559, 954);
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
            this.dateTimeNote.Location = new System.Drawing.Point(780, 57);
            this.dateTimeNote.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeNote.Name = "dateTimeNote";
            this.dateTimeNote.Size = new System.Drawing.Size(322, 50);
            this.dateTimeNote.TabIndex = 3;
            this.dateTimeNote.ValueChanged += new System.EventHandler(this.DateTimeNote_ValueChanged);
            // 
            // buttonNoteDel
            // 
            this.buttonNoteDel.Enabled = false;
            this.buttonNoteDel.Image = global::My_Games.Properties.Resources.remove;
            this.buttonNoteDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNoteDel.Location = new System.Drawing.Point(245, 47);
            this.buttonNoteDel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonNoteDel.Name = "buttonNoteDel";
            this.buttonNoteDel.Size = new System.Drawing.Size(200, 57);
            this.buttonNoteDel.TabIndex = 1;
            this.buttonNoteDel.Text = "Удалить";
            this.buttonNoteDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNoteDel.UseVisualStyleBackColor = true;
            this.buttonNoteDel.Click += new System.EventHandler(this.ButtonNoteDel_Click);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNote.Enabled = false;
            this.textBoxNote.Location = new System.Drawing.Point(584, 180);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(1001, 892);
            this.textBoxNote.TabIndex = 5;
            this.textBoxNote.TextChanged += new System.EventHandler(this.TextBoxNote_TextChanged);
            // 
            // tabPageOthers
            // 
            this.tabPageOthers.Controls.Add(this.labelInfo);
            this.tabPageOthers.Location = new System.Drawing.Point(8, 72);
            this.tabPageOthers.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageOthers.Name = "tabPageOthers";
            this.tabPageOthers.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tabPageOthers.Size = new System.Drawing.Size(1631, 1119);
            this.tabPageOthers.TabIndex = 5;
            this.tabPageOthers.Text = "Прочее";
            this.tabPageOthers.UseVisualStyleBackColor = true;
            // 
            // imageListTabs
            // 
            this.imageListTabs.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTabs.ImageStream")));
            this.imageListTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTabs.Images.SetKeyName(0, "purchase.png");
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(148, 454);
            this.labelSite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(95, 45);
            this.labelSite.TabIndex = 14;
            this.labelSite.Text = "Сайт:";
            // 
            // FormGame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1677, 1302);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimumSize = new System.Drawing.Size(1703, 1373);
            this.Name = "FormGame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.groupComment.ResumeLayout(false);
            this.groupComment.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
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
        private System.Windows.Forms.Label labelRating;
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
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.Button buttonAddVersion;
        private System.Windows.Forms.Button buttonDelEvent;
        private System.Windows.Forms.Button buttonChangeEvent;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.GroupBox groupComment;
        private System.Windows.Forms.Button buttonChangeVersion;
        private System.Windows.Forms.Button buttonDelVersion;
        private System.Windows.Forms.ColumnHeader columnEventHours;
        private System.Windows.Forms.ColumnHeader columnEventPlatform;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.ComboBox comboRating;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.LinkLabel linkGenre;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.ColumnHeader columnVerComment;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPagePurchases;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.TabPage tabPageOthers;
        private System.Windows.Forms.Label labelPlayed;
        private System.Windows.Forms.Label labelDLCs;
        private System.Windows.Forms.Label labelVersions;
        private System.Windows.Forms.Label labelPlayedL;
        private System.Windows.Forms.Label labelDLCsL;
        private System.Windows.Forms.Label labelVersionsL;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem выбратьОбложкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private Label labelSite;
    }
}