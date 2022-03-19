namespace My_Games
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFilter = new System.Windows.Forms.ToolStripButton();
            this.toolInfo = new System.Windows.Forms.ToolStripButton();
            this.toolColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolColNone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolColWin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDictionary = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolDictPlatforms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDictMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDictGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStat = new System.Windows.Forms.ToolStripButton();
            this.toolPurchase = new System.Windows.Forms.ToolStripButton();
            this.toolHistory = new System.Windows.Forms.ToolStripButton();
            this.toolSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.toolReset = new System.Windows.Forms.ToolStripButton();
            this.toolSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusShowed = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.listGames = new System.Windows.Forms.ListView();
            this.columnDate = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnGenre = new System.Windows.Forms.ColumnHeader();
            this.columnRating = new System.Windows.Forms.ColumnHeader();
            this.ColumnWin = new System.Windows.Forms.ColumnHeader();
            this.columnTime = new System.Windows.Forms.ColumnHeader();
            this.columnVersions = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmGoToSite = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolSep1,
            this.toolFilter,
            this.toolInfo,
            this.toolColor,
            this.toolSep2,
            this.toolDictionary,
            this.toolStat,
            this.toolPurchase,
            this.toolHistory,
            this.toolSep3,
            this.toolAbout,
            this.toolReset,
            this.toolSearch,
            this.toolSearchLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.toolStrip.Size = new System.Drawing.Size(1974, 82);
            this.toolStrip.TabIndex = 0;
            // 
            // toolAdd
            // 
            this.toolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdd.Image = global::My_Games.Properties.Resources.add;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(68, 68);
            this.toolAdd.Text = "Добавить";
            this.toolAdd.Click += new System.EventHandler(this.addGame);
            // 
            // toolSep1
            // 
            this.toolSep1.Name = "toolSep1";
            this.toolSep1.Size = new System.Drawing.Size(6, 74);
            // 
            // toolFilter
            // 
            this.toolFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFilter.Image = global::My_Games.Properties.Resources.filter;
            this.toolFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFilter.Name = "toolFilter";
            this.toolFilter.Size = new System.Drawing.Size(68, 68);
            this.toolFilter.Text = "Фильтр";
            this.toolFilter.Click += new System.EventHandler(this.FilterChange);
            // 
            // toolInfo
            // 
            this.toolInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolInfo.Image = global::My_Games.Properties.Resources.infopanel;
            this.toolInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInfo.Name = "toolInfo";
            this.toolInfo.Size = new System.Drawing.Size(68, 68);
            this.toolInfo.Text = "Инфопанель (F4)";
            this.toolInfo.ToolTipText = "Инфопанель";
            this.toolInfo.Click += new System.EventHandler(this.infoPanelTogle);
            // 
            // toolColor
            // 
            this.toolColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolColNone,
            this.toolColWin});
            this.toolColor.Image = global::My_Games.Properties.Resources.paint;
            this.toolColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolColor.Name = "toolColor";
            this.toolColor.Size = new System.Drawing.Size(86, 68);
            this.toolColor.Text = "Раскраска";
            // 
            // toolColNone
            // 
            this.toolColNone.Name = "toolColNone";
            this.toolColNone.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolColNone.Size = new System.Drawing.Size(343, 44);
            this.toolColNone.Text = "Без раскраски";
            this.toolColNone.Click += new System.EventHandler(this.ColorNone);
            // 
            // toolColWin
            // 
            this.toolColWin.Name = "toolColWin";
            this.toolColWin.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toolColWin.Size = new System.Drawing.Size(343, 44);
            this.toolColWin.Text = "Прохождение";
            this.toolColWin.Click += new System.EventHandler(this.ColorWin);
            // 
            // toolSep2
            // 
            this.toolSep2.Name = "toolSep2";
            this.toolSep2.Size = new System.Drawing.Size(6, 74);
            // 
            // toolDictionary
            // 
            this.toolDictionary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDictPlatforms,
            this.toolDictMedia,
            this.toolDictGenres});
            this.toolDictionary.Image = global::My_Games.Properties.Resources.dictionary;
            this.toolDictionary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDictionary.Name = "toolDictionary";
            this.toolDictionary.Size = new System.Drawing.Size(86, 68);
            this.toolDictionary.Text = "Справочники";
            // 
            // toolDictPlatforms
            // 
            this.toolDictPlatforms.Name = "toolDictPlatforms";
            this.toolDictPlatforms.Size = new System.Drawing.Size(277, 44);
            this.toolDictPlatforms.Text = "Платформы";
            this.toolDictPlatforms.Click += new System.EventHandler(this.dictPlatforms);
            // 
            // toolDictMedia
            // 
            this.toolDictMedia.Name = "toolDictMedia";
            this.toolDictMedia.Size = new System.Drawing.Size(277, 44);
            this.toolDictMedia.Text = "Носители";
            this.toolDictMedia.Click += new System.EventHandler(this.dictMediums);
            // 
            // toolDictGenres
            // 
            this.toolDictGenres.Name = "toolDictGenres";
            this.toolDictGenres.Size = new System.Drawing.Size(277, 44);
            this.toolDictGenres.Text = "Жанры";
            this.toolDictGenres.Click += new System.EventHandler(this.dictGenres);
            // 
            // toolStat
            // 
            this.toolStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStat.Image = global::My_Games.Properties.Resources.graph;
            this.toolStat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(68, 68);
            this.toolStat.Text = "Статистика";
            this.toolStat.Click += new System.EventHandler(this.Statistic);
            // 
            // toolPurchase
            // 
            this.toolPurchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPurchase.Image = global::My_Games.Properties.Resources.purchase;
            this.toolPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPurchase.Name = "toolPurchase";
            this.toolPurchase.Size = new System.Drawing.Size(68, 68);
            this.toolPurchase.Text = "Покупки";
            this.toolPurchase.Click += new System.EventHandler(this.Purchases);
            // 
            // toolHistory
            // 
            this.toolHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHistory.Image = global::My_Games.Properties.Resources.winner;
            this.toolHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHistory.Name = "toolHistory";
            this.toolHistory.Size = new System.Drawing.Size(68, 68);
            this.toolHistory.Text = "История";
            this.toolHistory.Click += new System.EventHandler(this.History);
            // 
            // toolSep3
            // 
            this.toolSep3.Name = "toolSep3";
            this.toolSep3.Size = new System.Drawing.Size(6, 74);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbout.Image = global::My_Games.Properties.Resources.about;
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(68, 68);
            this.toolAbout.Text = "О программе";
            this.toolAbout.Click += new System.EventHandler(this.About);
            // 
            // toolReset
            // 
            this.toolReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReset.Image = global::My_Games.Properties.Resources.reset;
            this.toolReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReset.Name = "toolReset";
            this.toolReset.Size = new System.Drawing.Size(68, 68);
            this.toolReset.Text = "Сброс";
            this.toolReset.Click += new System.EventHandler(this.SearchReset);
            // 
            // toolSearch
            // 
            this.toolSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(400, 74);
            this.toolSearch.TextChanged += new System.EventHandler(this.SearchTextChange);
            // 
            // toolSearchLabel
            // 
            this.toolSearchLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSearchLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSearchLabel.Image = global::My_Games.Properties.Resources.find;
            this.toolSearchLabel.Name = "toolSearchLabel";
            this.toolSearchLabel.Size = new System.Drawing.Size(64, 68);
            this.toolSearchLabel.Text = "toolStripLabel1";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAll,
            this.statusShowed,
            this.statusSelected});
            this.statusStrip.Location = new System.Drawing.Point(0, 1274);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1974, 55);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusAll
            // 
            this.statusAll.AutoSize = false;
            this.statusAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusAll.Name = "statusAll";
            this.statusAll.Size = new System.Drawing.Size(320, 45);
            this.statusAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusShowed
            // 
            this.statusShowed.AutoSize = false;
            this.statusShowed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusShowed.Name = "statusShowed";
            this.statusShowed.Size = new System.Drawing.Size(320, 45);
            this.statusShowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusSelected
            // 
            this.statusSelected.AutoSize = false;
            this.statusSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusSelected.Name = "statusSelected";
            this.statusSelected.Size = new System.Drawing.Size(320, 45);
            this.statusSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listGames
            // 
            this.listGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnName,
            this.columnGenre,
            this.columnRating,
            this.ColumnWin,
            this.columnTime,
            this.columnVersions,
            this.columnPrice});
            this.listGames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listGames.FullRowSelect = true;
            this.listGames.Location = new System.Drawing.Point(0, 85);
            this.listGames.Name = "listGames";
            this.listGames.Size = new System.Drawing.Size(1568, 1186);
            this.listGames.TabIndex = 2;
            this.listGames.UseCompatibleStateImageBehavior = false;
            this.listGames.View = System.Windows.Forms.View.Details;
            this.listGames.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listGames_ColumnClick);
            this.listGames.SelectedIndexChanged += new System.EventHandler(this.listGames_SelectedIndexChanged);
            this.listGames.DoubleClick += new System.EventHandler(this.Open);
            this.listGames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listGames_KeyDown);
            // 
            // columnDate
            // 
            this.columnDate.Text = "Дата";
            this.columnDate.Width = 180;
            // 
            // columnName
            // 
            this.columnName.Text = "Игра";
            this.columnName.Width = 450;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Жанр";
            this.columnGenre.Width = 300;
            // 
            // columnRating
            // 
            this.columnRating.Text = "Оценка";
            this.columnRating.Width = 150;
            // 
            // ColumnWin
            // 
            this.ColumnWin.Text = "Пройдена";
            this.ColumnWin.Width = 300;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Время";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTime.Width = 150;
            // 
            // columnVersions
            // 
            this.columnVersions.Text = "Версий";
            this.columnVersions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnVersions.Width = 150;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Потрачено";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnPrice.Width = 180;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.pictureCover);
            this.panelInfo.Location = new System.Drawing.Point(1574, 85);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(400, 1186);
            this.panelInfo.TabIndex = 3;
            // 
            // pictureCover
            // 
            this.pictureCover.Location = new System.Drawing.Point(3, 3);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(400, 400);
            this.pictureCover.TabIndex = 0;
            this.pictureCover.TabStop = false;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmOpen,
            this.cmGoToSite,
            this.cmDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(353, 160);
            this.contextMenu.Click += new System.EventHandler(this.GoToSite);
            // 
            // cmOpen
            // 
            this.cmOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmOpen.Name = "cmOpen";
            this.cmOpen.Size = new System.Drawing.Size(352, 52);
            this.cmOpen.Text = "Открыть";
            this.cmOpen.Click += new System.EventHandler(this.Open);
            // 
            // cmGoToSite
            // 
            this.cmGoToSite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmGoToSite.Name = "cmGoToSite";
            this.cmGoToSite.Size = new System.Drawing.Size(352, 52);
            this.cmGoToSite.Text = "Перейти на сайт";
            // 
            // cmDelete
            // 
            this.cmDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmDelete.Image = global::My_Games.Properties.Resources.delete;
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(352, 52);
            this.cmDelete.Text = "Удалить";
            this.cmDelete.Click += new System.EventHandler(this.Delete);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1329);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.listGames);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(2000, 1400);
            this.Name = "FormMain";
            this.Text = "My Games";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton toolAdd;
        private ToolStripSeparator toolSep1;
        private ToolStripButton toolFilter;
        private ToolStripButton toolInfo;
        private ToolStripSeparator toolSep2;
        private ToolStripButton toolStat;
        private ToolStripButton toolPurchase;
        private ToolStripButton toolHistory;
        private ToolStripSeparator toolSep3;
        private ToolStripButton toolAbout;
        private ToolStripLabel toolSearchLabel;
        private ToolStripTextBox toolSearch;
        private ToolStripButton toolReset;
        private ToolStripDropDownButton toolColor;
        private ToolStripMenuItem toolColNone;
        private ToolStripMenuItem toolColWin;
        private ToolStripDropDownButton toolDictionary;
        private ToolStripMenuItem toolDictPlatforms;
        private ToolStripMenuItem toolDictMedia;
        private ToolStripMenuItem toolDictGenres;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusAll;
        private ToolStripStatusLabel statusShowed;
        private ToolStripStatusLabel statusSelected;
        private ListView listGames;
        private Panel panelInfo;
        private ColumnHeader columnDate;
        private ColumnHeader columnName;
        private ColumnHeader columnGenre;
        private ColumnHeader columnRating;
        private ColumnHeader ColumnWin;
        private ColumnHeader columnTime;
        private ColumnHeader columnVersions;
        private ColumnHeader columnPrice;
        private PictureBox pictureCover;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem cmOpen;
        private ToolStripMenuItem cmGoToSite;
        private ToolStripMenuItem cmDelete;
    }
}