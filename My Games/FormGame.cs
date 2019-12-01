using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace My_Games
{
    public partial class FormGame : Form
    {
        Game game;
        List<Version> versions = new List<Version>();
        List<DLC> dlcs = new List<DLC>();
        List<Event> history = new List<Event>();

        bool changePicture = false;
        string ext;

        public FormGame(Game game)
        {
            InitializeComponent();

            this.game = game;

            //Если у игры нет ID, создадим его здесь
            if (game.ID == 0)
            {
                game.ID = ++Data.data.gameLastID;
                Data.Save();
            }

            comboBoxRate.DataSource = Game.stars;
            RefreshData();
        }

        void RefreshData()
        {
            Text = game.name;

            //Вкладка общих сведений
            textBoxName.Text = game.name;
            comboBoxDeveloper.Text = game.developer;
            comboBoxPublisher.Text = game.publisher;
            textBoxYear.Text = game.year;
            Genre.FillCombobox(comboBoxGenre, game.genre);
            comboBoxRate.SelectedIndex = game.rate - 1;
            textBoxSite.Text = game.website;
            textBoxComment.Text = game.comment != null ? game.comment.Replace("☺", "\r\n") : "";
            if (game.cover != null)
                OpenCover("Covers\\" + game.cover);

            //Вкладка версий
            versions.Clear();
            foreach (Version v in game.versions)
                versions.Add(new Version(v));
            DrawVersions();

            //Вкладка дополнительных материалов
            dlcs.Clear();
            foreach (DLC d in game.DLCs)
                dlcs.Add(new DLC(d));
            DrawDLCs();

            //Вкладка истории прохождений
            history.Clear();
            foreach (Event e in game.history)
                history.Add(new Event(e));
            DrawHistory();

            //Вкладка заметок


            //Вкладка прочего
            labelDates.Text = "ID: " + game.ID +
                "\nДата создания: " + game.create +
                "\nДата последнего изменения: " + game.change;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            game.change = DateTime.Now;
            game.name = textBoxName.Text;
            if (versions.Count > 0) game.date = versions[0].date;
            game.developer = comboBoxDeveloper.Text;
            game.publisher = comboBoxPublisher.Text;
            game.year = textBoxYear.Text;
            game.genre = Data.GenreNameToID(comboBoxGenre.Text);
            game.rate = comboBoxRate.SelectedIndex + 1;
            textBoxSite.Text = textBoxSite.Text.Replace("http://", "");
            textBoxSite.Text = textBoxSite.Text.Replace("https://", "");
            game.website = textBoxSite.Text;
            game.price = 0;
            game.win = 0;
            game.hours = 0;
            game.versions.Clear();
            foreach (Version v in versions)
            {
                game.versions.Add(new Version(v));
                game.price += v.price;
            }
            game.DLCs.Clear();
            foreach (DLC d in dlcs)
            {
                game.DLCs.Add(new DLC(d));
                game.price += d.price;
            }
            game.history.Clear();
            foreach (Event ev in history)
            {
                game.history.Add(new Event(ev));
                game.hours += ev.hours;
                if (game.win < ev.even) game.win = ev.even;
            }
            game.comment = textBoxComment.Text.Replace("\r\n", "☺");
            if (changePicture)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("Covers");
                    string file = game.ID + ext;
                    pictureBoxCover.Image.Save("Covers\\" + file);
                    game.cover = file;
                }
                catch { }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(3, Data.data.genres);
            form.ShowDialog();
            Genre.FillCombobox(comboBoxGenre, game.genre);
        }

        #region Versions
        private void buttonAddVersion_Click(object sender, EventArgs e)
        {
            Version version = new Version();
            FormVersion form = new FormVersion(version);
            if (form.ShowDialog() == DialogResult.OK)
            {
                versions.Add(version);
                DrawVersions();
            }
        }

        private void listViewVersions_MouseDoubleClick(object sender, MouseEventArgs e) { buttonChangeVersion_Click(null, null); }
        private void buttonChangeVersion_Click(object sender, EventArgs e)
        {
            if (listViewVersions.SelectedIndices.Count == 1)
            {
                Version version = (Version)listViewVersions.SelectedItems[0].Tag;
                FormVersion form = new FormVersion(version);
                if (form.ShowDialog() == DialogResult.OK)
                    DrawVersions();
            }
        }

        private void buttonDelVersion_Click(object sender, EventArgs e)
        {
            if (listViewVersions.SelectedIndices.Count == 1)
            {
                Version version = (Version)listViewVersions.SelectedItems[0].Tag;
                versions.Remove(version);
                DrawVersions();
                listViewVersions_SelectedIndexChanged(null, null);
            }
        }

        void DrawVersions()
        {
            VersionDateComparer dc = new VersionDateComparer();
            versions.Sort(dc);
            listViewVersions.BeginUpdate();
            listViewVersions.Items.Clear();
            string text = "";
            foreach (Version v in versions)
            {
                listViewVersions.Items.Add(v.listItem());
                if (text != "") text += ", ";
                text += Data.PlatformIDToName(v.platform);
            }
            if (text == "") text += "Нет";
            labelVers.Text = text;
            listViewVersions.EndUpdate();
        }

        private void listViewVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewVersions.SelectedIndices.Count > 0;
            buttonChangeVersion.Enabled = sel;
            buttonDelVersion.Enabled = sel;
        }

        #endregion

        #region DLC
        private void buttonAddDLC_Click(object sender, EventArgs e)
        {
            DLC dlc = new DLC();
            FormDLC form = new FormDLC(dlc);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dlcs.Add(dlc);
                DrawDLCs();
            }
        }

        private void listViewDLCs_MouseDoubleClick(object sender, MouseEventArgs e) { buttonChangeDLC_Click(null, null); }
        private void buttonChangeDLC_Click(object sender, EventArgs e)
        {
            if (listViewDLCs.SelectedIndices.Count == 1)
            {
                DLC dlc = (DLC)listViewDLCs.SelectedItems[0].Tag;
                FormDLC form = new FormDLC(dlc);
                if (form.ShowDialog() == DialogResult.OK)
                    DrawDLCs();
            }
        }

        private void buttonDelDLC_Click(object sender, EventArgs e)
        {
            if (listViewDLCs.SelectedIndices.Count == 1)
            {
                DLC dlc = (DLC)listViewDLCs.SelectedItems[0].Tag;
                dlcs.Remove(dlc);
                DrawDLCs();
                listViewDLCs_SelectedIndexChanged(null, null);
            }
        }

        void DrawDLCs()
        {
            DLCDateComparer dc = new DLCDateComparer();
            dlcs.Sort(dc);
            listViewDLCs.BeginUpdate();
            listViewDLCs.Items.Clear();
            string text = "";
            foreach (DLC d in dlcs)
            {
                listViewDLCs.Items.Add(d.listItem());
                if (text != "") text += ", ";
                text += d.name;
            }
            if (text == "") text += "Нет";
            labelDLCs.Text = text;
            listViewDLCs.EndUpdate();
        }

        private void listViewDLCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewDLCs.SelectedIndices.Count > 0;
            buttonChangeDLC.Enabled = sel;
            buttonDelDLC.Enabled = sel;
        }
        #endregion

        #region History
        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            FormEvent form = new FormEvent(ev);
            if (form.ShowDialog() == DialogResult.OK)
            {
                history.Add(ev);
                DrawHistory();
            }
        }

        private void listViewHistory_DoubleClick(object sender, EventArgs e) { buttonChangeEvent_Click(null, null); }
        private void buttonChangeEvent_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count == 1)
            {
                Event ev = (Event)listViewHistory.SelectedItems[0].Tag;
                FormEvent form = new FormEvent(ev);
                if (form.ShowDialog() == DialogResult.OK)
                    DrawHistory();
            }
        }

        private void buttonDelEvent_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count == 1)
            {
                Event ev = (Event)listViewHistory.SelectedItems[0].Tag;
                history.Remove(ev);
                DrawHistory();
                listViewHistory_SelectedIndexChanged(null, null);
            }
        }

        void DrawHistory()
        {
            EventDateComparer dc = new EventDateComparer();
            history.Sort(dc);
            listViewHistory.BeginUpdate();
            listViewHistory.Items.Clear();
            int max = 0;
            int hours = 0;
            foreach (Event e in history)
            {
                listViewHistory.Items.Add(e.listItem());
                if (max < e.even) max = e.even;
                hours += e.hours;
            }
            labelHis.Text = Event.events[max] + ", общее время в игре: " + hours.ToString() + " ч.";
            listViewHistory.EndUpdate();
        }

        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewHistory.SelectedIndices.Count > 0;
            buttonChangeEvent.Enabled = sel;
            buttonDelEvent.Enabled = sel;
        }
        #endregion

        private void TabPageMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void TabPageMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string file = files[0];
            ext = System.IO.Path.GetExtension(file).ToLower();
            changePicture = OpenCover(file);
        }

        private void PictureBoxCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|" +
                "*.jpg; *.jpeg; *.png; *.gif; *.bmp|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                changePicture = true;
                OpenCover(dialog.FileName);
            }
        }

        bool OpenCover(string file)
        {
            try
            {
                pictureBoxCover.Image = Image.FromFile(file);
                labelCover.Visible = false;
                pictureBoxCover.BackColor = tabPageMain.BackColor;
                return true;
            }
            catch { return false; }
        }
    }
}
