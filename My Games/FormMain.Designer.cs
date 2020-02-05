namespace My_Games
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddFast = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfoPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCol0 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCol1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCats = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlatforms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMediums = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanel = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.toolAddFast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFilter = new System.Windows.Forms.ToolStripButton();
            this.toolInfoPanel = new System.Windows.Forms.ToolStripButton();
            this.toolSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStat = new System.Windows.Forms.ToolStripButton();
            this.toolPurchases = new System.Windows.Forms.ToolStripButton();
            this.toolHistory = new System.Windows.Forms.ToolStripButton();
            this.toolReset = new System.Windows.Forms.ToolStripButton();
            this.toolSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelFind = new System.Windows.Forms.ToolStripLabel();
            this.listViewGames = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVersions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGoToSite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelC = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusShowed = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoView = new System.Windows.Forms.Panel();
            this.labelHistory = new System.Windows.Forms.Label();
            this.labelHistoryL = new System.Windows.Forms.Label();
            this.labelDLCs = new System.Windows.Forms.Label();
            this.labelDLCL = new System.Windows.Forms.Label();
            this.labelVersions = new System.Windows.Forms.Label();
            this.labelVersionsL = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelYearL = new System.Windows.Forms.Label();
            this.labelPublishers = new System.Windows.Forms.Label();
            this.labelPublishersL = new System.Windows.Forms.Label();
            this.labelDevelopers = new System.Windows.Forms.Label();
            this.labelDevelopersL = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStripPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.infoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuCats,
            this.menuService,
            this.menuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuAddFast,
            this.menuDel,
            this.menuSep1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuAdd
            // 
            this.menuAdd.Image = ((System.Drawing.Image)(resources.GetObject("menuAdd.Image")));
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuAdd.Size = new System.Drawing.Size(273, 22);
            this.menuAdd.Text = "Добавить игру";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuAddFast
            // 
            this.menuAddFast.Image = global::My_Games.Properties.Resources.add_fast;
            this.menuAddFast.Name = "menuAddFast";
            this.menuAddFast.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuAddFast.Size = new System.Drawing.Size(273, 22);
            this.menuAddFast.Text = "Добавить игру быстро";
            this.menuAddFast.Click += new System.EventHandler(this.menuAddFast_Click);
            // 
            // menuDel
            // 
            this.menuDel.Enabled = false;
            this.menuDel.Name = "menuDel";
            this.menuDel.Size = new System.Drawing.Size(273, 22);
            this.menuDel.Text = "Удалить";
            this.menuDel.Click += new System.EventHandler(this.menuDel_Click);
            // 
            // menuSep1
            // 
            this.menuSep1.Name = "menuSep1";
            this.menuSep1.Size = new System.Drawing.Size(270, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(273, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFilter,
            this.menuSearch,
            this.menuInfoPanel,
            this.menuSep2,
            this.menuCol0,
            this.menuCol1});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(39, 20);
            this.menuView.Text = "Вид";
            // 
            // menuFilter
            // 
            this.menuFilter.Image = global::My_Games.Properties.Resources.filter;
            this.menuFilter.Name = "menuFilter";
            this.menuFilter.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuFilter.Size = new System.Drawing.Size(247, 22);
            this.menuFilter.Text = "Фильтр";
            this.menuFilter.Click += new System.EventHandler(this.menuFilter_Click);
            // 
            // menuSearch
            // 
            this.menuSearch.Image = global::My_Games.Properties.Resources.search;
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuSearch.Size = new System.Drawing.Size(247, 22);
            this.menuSearch.Text = "Поиск";
            this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
            // 
            // menuInfoPanel
            // 
            this.menuInfoPanel.Image = global::My_Games.Properties.Resources.info;
            this.menuInfoPanel.Name = "menuInfoPanel";
            this.menuInfoPanel.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuInfoPanel.Size = new System.Drawing.Size(247, 22);
            this.menuInfoPanel.Text = "Панель информации";
            this.menuInfoPanel.Click += new System.EventHandler(this.menuInfoPanel_Click);
            // 
            // menuSep2
            // 
            this.menuSep2.Name = "menuSep2";
            this.menuSep2.Size = new System.Drawing.Size(244, 6);
            // 
            // menuCol0
            // 
            this.menuCol0.Name = "menuCol0";
            this.menuCol0.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuCol0.Size = new System.Drawing.Size(247, 22);
            this.menuCol0.Text = "Раскраска отключена";
            this.menuCol0.Click += new System.EventHandler(this.menuCol0_Click);
            // 
            // menuCol1
            // 
            this.menuCol1.Name = "menuCol1";
            this.menuCol1.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuCol1.Size = new System.Drawing.Size(247, 22);
            this.menuCol1.Text = "Раскраска по прохождению";
            this.menuCol1.Click += new System.EventHandler(this.menuCol1_Click);
            // 
            // menuCats
            // 
            this.menuCats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlatforms,
            this.menuMediums,
            this.menuGenres});
            this.menuCats.Name = "menuCats";
            this.menuCats.Size = new System.Drawing.Size(94, 20);
            this.menuCats.Text = "Справочники";
            // 
            // menuPlatforms
            // 
            this.menuPlatforms.Name = "menuPlatforms";
            this.menuPlatforms.Size = new System.Drawing.Size(142, 22);
            this.menuPlatforms.Text = "Платформы";
            this.menuPlatforms.Click += new System.EventHandler(this.menuPlatforms_Click);
            // 
            // menuMediums
            // 
            this.menuMediums.Name = "menuMediums";
            this.menuMediums.Size = new System.Drawing.Size(142, 22);
            this.menuMediums.Text = "Носители";
            this.menuMediums.ToolTipText = "Носители, электронные магазины, подписки";
            this.menuMediums.Click += new System.EventHandler(this.menuMediums_Click);
            // 
            // menuGenres
            // 
            this.menuGenres.Name = "menuGenres";
            this.menuGenres.Size = new System.Drawing.Size(142, 22);
            this.menuGenres.Text = "Жанры";
            this.menuGenres.Click += new System.EventHandler(this.menuGenres_Click);
            // 
            // menuService
            // 
            this.menuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStat,
            this.menuPurchases,
            this.menuHistory});
            this.menuService.Name = "menuService";
            this.menuService.Size = new System.Drawing.Size(59, 20);
            this.menuService.Text = "Сервис";
            // 
            // menuStat
            // 
            this.menuStat.Image = global::My_Games.Properties.Resources.stat;
            this.menuStat.Name = "menuStat";
            this.menuStat.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.menuStat.Size = new System.Drawing.Size(224, 22);
            this.menuStat.Text = "Статистика";
            this.menuStat.Click += new System.EventHandler(this.menuStat_Click);
            // 
            // menuPurchases
            // 
            this.menuPurchases.Image = global::My_Games.Properties.Resources.purchase;
            this.menuPurchases.Name = "menuPurchases";
            this.menuPurchases.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.menuPurchases.Size = new System.Drawing.Size(224, 22);
            this.menuPurchases.Text = "История покупок";
            this.menuPurchases.Click += new System.EventHandler(this.menuPurchases_Click);
            // 
            // menuHistory
            // 
            this.menuHistory.Image = global::My_Games.Properties.Resources.winner;
            this.menuHistory.Name = "menuHistory";
            this.menuHistory.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuHistory.Size = new System.Drawing.Size(224, 22);
            this.menuHistory.Text = "История прохождений";
            this.menuHistory.Click += new System.EventHandler(this.menuHistory_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPage,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuPage
            // 
            this.menuPage.Name = "menuPage";
            this.menuPage.Size = new System.Drawing.Size(196, 22);
            this.menuPage.Text = "Страница программы";
            this.menuPage.Click += new System.EventHandler(this.menuPage_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(196, 22);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolSep1,
            this.toolFilter,
            this.toolInfoPanel,
            this.toolSep2,
            this.toolStat,
            this.toolPurchases,
            this.toolHistory,
            this.toolReset,
            this.toolSearch,
            this.toolStripLabelFind});
            this.toolStripPanel.Location = new System.Drawing.Point(0, 24);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.Size = new System.Drawing.Size(784, 25);
            this.toolStripPanel.TabIndex = 1;
            this.toolStripPanel.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddFast});
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(32, 22);
            this.toolAdd.Text = "Добавить игру";
            this.toolAdd.ButtonClick += new System.EventHandler(this.toolAdd_ButtonClick);
            // 
            // toolAddFast
            // 
            this.toolAddFast.Image = global::My_Games.Properties.Resources.add_fast;
            this.toolAddFast.Name = "toolAddFast";
            this.toolAddFast.Size = new System.Drawing.Size(198, 22);
            this.toolAddFast.Text = "Добавить игру быстро";
            this.toolAddFast.Click += new System.EventHandler(this.toolAddFast_Click);
            // 
            // toolSep1
            // 
            this.toolSep1.Name = "toolSep1";
            this.toolSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolFilter
            // 
            this.toolFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFilter.Image = global::My_Games.Properties.Resources.filter;
            this.toolFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFilter.Name = "toolFilter";
            this.toolFilter.Size = new System.Drawing.Size(23, 22);
            this.toolFilter.Text = "Фильтр";
            this.toolFilter.Click += new System.EventHandler(this.toolFilter_Click);
            // 
            // toolInfoPanel
            // 
            this.toolInfoPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolInfoPanel.Image = global::My_Games.Properties.Resources.info;
            this.toolInfoPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInfoPanel.Name = "toolInfoPanel";
            this.toolInfoPanel.Size = new System.Drawing.Size(23, 22);
            this.toolInfoPanel.Text = "Панель информации";
            this.toolInfoPanel.Click += new System.EventHandler(this.toolInfoPanel_Click);
            // 
            // toolSep2
            // 
            this.toolSep2.Name = "toolSep2";
            this.toolSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStat
            // 
            this.toolStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStat.Image = global::My_Games.Properties.Resources.stat;
            this.toolStat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(23, 22);
            this.toolStat.Text = "Статистика";
            this.toolStat.Click += new System.EventHandler(this.toolStat_Click);
            // 
            // toolPurchases
            // 
            this.toolPurchases.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPurchases.Image = global::My_Games.Properties.Resources.purchase;
            this.toolPurchases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPurchases.Name = "toolPurchases";
            this.toolPurchases.Size = new System.Drawing.Size(23, 22);
            this.toolPurchases.Text = "История покупок";
            this.toolPurchases.Click += new System.EventHandler(this.toolPurchases_Click);
            // 
            // toolHistory
            // 
            this.toolHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHistory.Image = global::My_Games.Properties.Resources.winner;
            this.toolHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHistory.Name = "toolHistory";
            this.toolHistory.Size = new System.Drawing.Size(23, 22);
            this.toolHistory.Text = "История прохождений";
            this.toolHistory.Click += new System.EventHandler(this.toolHistory_Click);
            // 
            // toolReset
            // 
            this.toolReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReset.Enabled = false;
            this.toolReset.Image = global::My_Games.Properties.Resources.clear;
            this.toolReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReset.Name = "toolReset";
            this.toolReset.Size = new System.Drawing.Size(23, 22);
            this.toolReset.Text = "Сброс";
            this.toolReset.Click += new System.EventHandler(this.toolReset_Click);
            // 
            // toolSearch
            // 
            this.toolSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(160, 25);
            this.toolSearch.TextChanged += new System.EventHandler(this.toolSearch_TextChanged);
            // 
            // toolStripLabelFind
            // 
            this.toolStripLabelFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabelFind.Image = global::My_Games.Properties.Resources.search;
            this.toolStripLabelFind.Name = "toolStripLabelFind";
            this.toolStripLabelFind.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabelFind.Text = "Поиск";
            // 
            // listViewGames
            // 
            this.listViewGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderGame,
            this.columnHeaderGenre,
            this.columnHeaderRating,
            this.columnHeaderWin,
            this.columnHeaderHourse,
            this.columnHeaderVersions,
            this.columnHeaderPrice});
            this.listViewGames.ContextMenuStrip = this.contextMenu;
            this.listViewGames.FullRowSelect = true;
            this.listViewGames.GridLines = true;
            this.listViewGames.HideSelection = false;
            this.listViewGames.Location = new System.Drawing.Point(0, 52);
            this.listViewGames.Name = "listViewGames";
            this.listViewGames.Size = new System.Drawing.Size(579, 484);
            this.listViewGames.TabIndex = 2;
            this.listViewGames.UseCompatibleStateImageBehavior = false;
            this.listViewGames.View = System.Windows.Forms.View.Details;
            this.listViewGames.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewGames_ColumnClick);
            this.listViewGames.SelectedIndexChanged += new System.EventHandler(this.listViewGames_SelectedIndexChanged);
            this.listViewGames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewGames_KeyDown);
            this.listViewGames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewGames_MouseDoubleClick);
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата";
            this.columnHeaderDate.Width = 70;
            // 
            // columnHeaderGame
            // 
            this.columnHeaderGame.Text = "Игра";
            this.columnHeaderGame.Width = 180;
            // 
            // columnHeaderGenre
            // 
            this.columnHeaderGenre.Text = "Жанр";
            this.columnHeaderGenre.Width = 80;
            // 
            // columnHeaderRating
            // 
            this.columnHeaderRating.Text = "Оценка";
            // 
            // columnHeaderWin
            // 
            this.columnHeaderWin.Text = "Пройдена";
            this.columnHeaderWin.Width = 100;
            // 
            // columnHeaderHourse
            // 
            this.columnHeaderHourse.Text = "Часы";
            this.columnHeaderHourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeaderVersions
            // 
            this.columnHeaderVersions.Text = "Версии";
            this.columnHeaderVersions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Потрачено";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderPrice.Width = 80;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuGoToSite,
            this.menuDelC});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(165, 70);
            // 
            // menuOpen
            // 
            this.menuOpen.Enabled = false;
            this.menuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(164, 22);
            this.menuOpen.Text = "Открыть";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuGoToSite
            // 
            this.menuGoToSite.Enabled = false;
            this.menuGoToSite.Name = "menuGoToSite";
            this.menuGoToSite.Size = new System.Drawing.Size(164, 22);
            this.menuGoToSite.Text = "Перейти на сайт";
            this.menuGoToSite.Click += new System.EventHandler(this.menuGoToSite_Click);
            // 
            // menuDelC
            // 
            this.menuDelC.Enabled = false;
            this.menuDelC.Name = "menuDelC";
            this.menuDelC.Size = new System.Drawing.Size(164, 22);
            this.menuDelC.Text = "Удалить";
            this.menuDelC.Click += new System.EventHandler(this.menuDelC_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAll,
            this.statusShowed,
            this.statusSelected});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusAll
            // 
            this.statusAll.AutoSize = false;
            this.statusAll.Name = "statusAll";
            this.statusAll.Size = new System.Drawing.Size(150, 17);
            this.statusAll.Text = "All";
            this.statusAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusShowed
            // 
            this.statusShowed.AutoSize = false;
            this.statusShowed.Name = "statusShowed";
            this.statusShowed.Size = new System.Drawing.Size(150, 17);
            this.statusShowed.Text = "Showed";
            this.statusShowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusSelected
            // 
            this.statusSelected.AutoSize = false;
            this.statusSelected.Name = "statusSelected";
            this.statusSelected.Size = new System.Drawing.Size(150, 17);
            this.statusSelected.Text = "Selected";
            this.statusSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoView
            // 
            this.infoView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoView.Controls.Add(this.labelHistory);
            this.infoView.Controls.Add(this.labelHistoryL);
            this.infoView.Controls.Add(this.labelDLCs);
            this.infoView.Controls.Add(this.labelDLCL);
            this.infoView.Controls.Add(this.labelVersions);
            this.infoView.Controls.Add(this.labelVersionsL);
            this.infoView.Controls.Add(this.pictureBoxCover);
            this.infoView.Controls.Add(this.labelYear);
            this.infoView.Controls.Add(this.labelYearL);
            this.infoView.Controls.Add(this.labelPublishers);
            this.infoView.Controls.Add(this.labelPublishersL);
            this.infoView.Controls.Add(this.labelDevelopers);
            this.infoView.Controls.Add(this.labelDevelopersL);
            this.infoView.Controls.Add(this.labelName);
            this.infoView.Location = new System.Drawing.Point(585, 52);
            this.infoView.Name = "infoView";
            this.infoView.Size = new System.Drawing.Size(199, 484);
            this.infoView.TabIndex = 4;
            // 
            // labelHistory
            // 
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHistory.Location = new System.Drawing.Point(3, 439);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(190, 30);
            this.labelHistory.TabIndex = 14;
            // 
            // labelHistoryL
            // 
            this.labelHistoryL.AutoSize = true;
            this.labelHistoryL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelHistoryL.Location = new System.Drawing.Point(3, 426);
            this.labelHistoryL.Name = "labelHistoryL";
            this.labelHistoryL.Size = new System.Drawing.Size(60, 13);
            this.labelHistoryL.TabIndex = 13;
            this.labelHistoryL.Text = "Пройдена:";
            // 
            // labelDLCs
            // 
            this.labelDLCs.Location = new System.Drawing.Point(3, 396);
            this.labelDLCs.Name = "labelDLCs";
            this.labelDLCs.Size = new System.Drawing.Size(190, 30);
            this.labelDLCs.TabIndex = 12;
            // 
            // labelDLCL
            // 
            this.labelDLCL.AutoSize = true;
            this.labelDLCL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDLCL.Location = new System.Drawing.Point(3, 383);
            this.labelDLCL.Name = "labelDLCL";
            this.labelDLCL.Size = new System.Drawing.Size(158, 13);
            this.labelDLCL.TabIndex = 11;
            this.labelDLCL.Text = "Дополнительные материалы:";
            // 
            // labelVersions
            // 
            this.labelVersions.Location = new System.Drawing.Point(3, 353);
            this.labelVersions.Name = "labelVersions";
            this.labelVersions.Size = new System.Drawing.Size(190, 30);
            this.labelVersions.TabIndex = 10;
            // 
            // labelVersionsL
            // 
            this.labelVersionsL.AutoSize = true;
            this.labelVersionsL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelVersionsL.Location = new System.Drawing.Point(3, 340);
            this.labelVersionsL.Name = "labelVersionsL";
            this.labelVersionsL.Size = new System.Drawing.Size(47, 13);
            this.labelVersionsL.TabIndex = 9;
            this.labelVersionsL.Text = "Версии:";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 8;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelYear
            // 
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.Location = new System.Drawing.Point(2, 320);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(191, 20);
            this.labelYear.TabIndex = 7;
            // 
            // labelYearL
            // 
            this.labelYearL.AutoSize = true;
            this.labelYearL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelYearL.Location = new System.Drawing.Point(3, 307);
            this.labelYearL.Name = "labelYearL";
            this.labelYearL.Size = new System.Drawing.Size(68, 13);
            this.labelYearL.TabIndex = 6;
            this.labelYearL.Text = "Год выхода:";
            // 
            // labelPublishers
            // 
            this.labelPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPublishers.Location = new System.Drawing.Point(2, 287);
            this.labelPublishers.Name = "labelPublishers";
            this.labelPublishers.Size = new System.Drawing.Size(191, 20);
            this.labelPublishers.TabIndex = 5;
            // 
            // labelPublishersL
            // 
            this.labelPublishersL.AutoSize = true;
            this.labelPublishersL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPublishersL.Location = new System.Drawing.Point(3, 274);
            this.labelPublishersL.Name = "labelPublishersL";
            this.labelPublishersL.Size = new System.Drawing.Size(59, 13);
            this.labelPublishersL.TabIndex = 4;
            this.labelPublishersL.Text = "Издатель:";
            // 
            // labelDevelopers
            // 
            this.labelDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDevelopers.Location = new System.Drawing.Point(2, 254);
            this.labelDevelopers.Name = "labelDevelopers";
            this.labelDevelopers.Size = new System.Drawing.Size(191, 20);
            this.labelDevelopers.TabIndex = 3;
            // 
            // labelDevelopersL
            // 
            this.labelDevelopersL.AutoSize = true;
            this.labelDevelopersL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDevelopersL.Location = new System.Drawing.Point(3, 241);
            this.labelDevelopersL.Name = "labelDevelopersL";
            this.labelDevelopersL.Size = new System.Drawing.Size(75, 13);
            this.labelDevelopersL.TabIndex = 2;
            this.labelDevelopersL.Text = "Разработчик:";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(3, 196);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(190, 45);
            this.labelName.TabIndex = 1;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.infoView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listViewGames);
            this.Controls.Add(this.toolStripPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "My Games";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.infoView.ResumeLayout(false);
            this.infoView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStripPanel;
        private System.Windows.Forms.ListView listViewGames;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderGame;
        private System.Windows.Forms.ToolStripTextBox toolSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFind;
        private System.Windows.Forms.ToolStripButton toolReset;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ColumnHeader columnHeaderVersions;
        private System.Windows.Forms.ColumnHeader columnHeaderHourse;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderGenre;
        private System.Windows.Forms.ColumnHeader columnHeaderRating;
        private System.Windows.Forms.ColumnHeader columnHeaderWin;
        private System.Windows.Forms.ToolStripMenuItem menuCats;
        private System.Windows.Forms.ToolStripMenuItem menuPlatforms;
        private System.Windows.Forms.ToolStripMenuItem menuMediums;
        private System.Windows.Forms.ToolStripMenuItem menuGenres;
        private System.Windows.Forms.ToolStripMenuItem menuAddFast;
        private System.Windows.Forms.ToolStripMenuItem menuDel;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuDelC;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuInfoPanel;
        private System.Windows.Forms.Panel infoView;
        private System.Windows.Forms.ToolStripMenuItem menuService;
        private System.Windows.Forms.ToolStripMenuItem menuStat;
        private System.Windows.Forms.ToolStripButton toolStat;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYearL;
        private System.Windows.Forms.Label labelPublishers;
        private System.Windows.Forms.Label labelPublishersL;
        private System.Windows.Forms.Label labelDevelopers;
        private System.Windows.Forms.Label labelDevelopersL;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.ToolStripStatusLabel statusAll;
        private System.Windows.Forms.ToolStripMenuItem menuPurchases;
        private System.Windows.Forms.ToolStripMenuItem menuGoToSite;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuPage;
        private System.Windows.Forms.ToolStripButton toolPurchases;
        private System.Windows.Forms.ToolStripMenuItem menuHistory;
        private System.Windows.Forms.ToolStripButton toolHistory;
        private System.Windows.Forms.ToolStripMenuItem menuCol0;
        private System.Windows.Forms.ToolStripMenuItem menuCol1;
        private System.Windows.Forms.ToolStripSeparator menuSep2;
        private System.Windows.Forms.ToolStripMenuItem menuFilter;
        private System.Windows.Forms.ToolStripButton toolFilter;
        private System.Windows.Forms.ToolStripSeparator toolSep1;
        private System.Windows.Forms.ToolStripSeparator toolSep2;
        private System.Windows.Forms.ToolStripButton toolInfoPanel;
        private System.Windows.Forms.ToolStripStatusLabel statusShowed;
        private System.Windows.Forms.ToolStripStatusLabel statusSelected;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.ToolStripSplitButton toolAdd;
        private System.Windows.Forms.ToolStripMenuItem toolAddFast;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.Label labelVersions;
        private System.Windows.Forms.Label labelVersionsL;
        private System.Windows.Forms.Label labelDLCs;
        private System.Windows.Forms.Label labelDLCL;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Label labelHistoryL;
    }
}

