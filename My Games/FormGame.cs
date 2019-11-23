using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormGame : Form
    {
        Game game;
        List<Version> versions = new List<Version>();
        List<DLC> dlcs = new List<DLC>();
        List<Event> history = new List<Event>();

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
            labelDates.Text = "ID: " + game.ID +
                "     Дата создания: " + game.create + 
                "     Дата последнего изменения: " + game.change;
        }

        void RefreshData()
        {
            Text = game.name;
            textBoxName.Text = game.name;
            comboBoxDeveloper.Text = game.developer;
            comboBoxPublisher.Text = game.publisher;
            textBoxYear.Text = game.year;
            Genre.FillCombobox(comboBoxGenre, game.genre);
            comboBoxRate.SelectedIndex = game.rate - 1;
            textBoxSite.Text = game.website;
            versions.Clear();
            foreach (Version v in game.versions)
                versions.Add(new Version(v));
            DrawVersions();
            dlcs.Clear();
            foreach (DLC d in game.DLCs)
                dlcs.Add(new DLC(d));
            DrawDLCs();
            history.Clear();
            foreach (Event e in game.history)
                history.Add(new Event(e));
            DrawHistory();
            textBoxComment.Text = game.comment != null? game.comment.Replace("☺", "\r\n") : "";
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
            foreach (Version v in versions)
                listViewVersions.Items.Add(v.listItem());
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
            foreach (DLC d in dlcs)
                listViewDLCs.Items.Add(d.listItem());
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
            foreach (Event e in history)
                listViewHistory.Items.Add(e.listItem());
            listViewHistory.EndUpdate();
        }

        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewHistory.SelectedIndices.Count > 0;
            buttonChangeEvent.Enabled = sel;
            buttonDelEvent.Enabled = sel;
        }
        #endregion
    }
}
