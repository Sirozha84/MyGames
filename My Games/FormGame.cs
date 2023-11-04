using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace My_Games
{
    public partial class FormGame : Form
    {
        Game game;
        List<Version> versions = new List<Version>();
        List<DLC> dlcs = new List<DLC>();
        List<Event> history = new List<Event>();
        List<Note> notes = new List<Note>();

        bool changePicture = false;
        string newCover;
        //string ext;

        public FormGame(Game game)
        {
            InitializeComponent();
            this.game = game;
            comboRate.DataSource = Game.stars;
            RefreshData();
            textName.Focus();
        }

        void RefreshData()
        {
            //Вкладка общих сведений
            Text = game.name;
            textName.Text = game.name;
            textDeveloper.Text = game.developer;
            textPublisher.Text = game.publisher;
            textYear.Text = game.year;
            Genre.FillCombobox(comboGenre, game.genre);
            comboRate.SelectedIndex = game.rate - 1;
            textSite.Text = game.website;
            textSF.Text = game.scrFolder;
            textBoxComment.Text = game.comment != null ? game.comment.Replace("☺", "\r\n") : "";
            if (game.cover != null)
                OpenCover("Covers\\" + game.cover);

            //Вкладка покупок
            versions.Clear();
            foreach (Version v in game.versions)
                versions.Add(new Version(v));
            DrawVersions();
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
            notes.Clear();
            foreach (Note n in game.notes)
            {
                Note nn = new Note(n);
                nn.note = nn.note.Replace("☺", "\r\n");
                notes.Add(nn);
            }
            DrawNotes(false);

            //Вкладка прочего
            RefreshOthers();
            checkHidden.Checked = game.hidden;

            textBoxName_TextChanged(null, null); //Это чтоб обновить кнопку ОК
        }

        string TimeSpanString(DateTime Start, DateTime End)
        {
            int days = (int)(End - Start).TotalDays + 1;
            if (days < 365) return days.ToString() + " (дней)";
            return ((int)(days / 365.25)).ToString() + " (лет)";
        }

        private void OK(object sender, EventArgs e)
        {
            //ID
            if (game.ID == 0)
            {
                game.ID = ++Data.data.gameLastID;
                Data.Save();
            }

            //Общие сведения
            game.change = DateTime.Now;
            game.name = textName.Text;
            game.developer = textDeveloper.Text;
            game.publisher = textPublisher.Text;
            game.year = textYear.Text;
            game.genre = Data.GenreNameToID(comboGenre.Text);
            game.rate = comboRate.SelectedIndex + 1;
            textSite.Text = textSite.Text.Replace("http://", "");
            textSite.Text = textSite.Text.Replace("https://", "");
            game.website = textSite.Text;
            game.scrFolder = textSF.Text;
            game.comment = textBoxComment.Text.Replace("\r\n", "☺");
            if (changePicture)
            {
                if (newCover == "") game.cover = null;
                else
                    try
                    {
                        Directory.CreateDirectory("Covers");
                        string file = game.ID + Path.GetExtension(newCover).ToLower();
                        File.Copy(newCover, "Covers\\" + file, true);
                        game.cover = file;
                    }
                    catch { }
            }

            //Внутренние таблицы
            game.versions.Clear();
            foreach (Version v in versions)
                game.versions.Add(new Version(v));
            game.DLCs.Clear();
            foreach (DLC d in dlcs)
                game.DLCs.Add(new DLC(d));
            game.history.Clear();
            foreach (Event ev in history)
                game.history.Add(new Event(ev));
            
            //Вкладка заметок
            notes.Sort((o1, o2) => o1.date.CompareTo(o2.date));
            game.notes.Clear();
            foreach (Note n in notes)
            {
                Note nn = new Note(n);
                nn.note = nn.note.Replace("\r\n", "☺");
                game.notes.Add(nn);
            }

            //Вкладка прочего
            game.hidden = checkHidden.Checked;

            game.Hold();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TabPageVersions_SizeChanged(object sender, EventArgs e)
        {
            panelVersion.Height = (tabPagePurchases.Height - 10) / 2;
        }

        #region Main
        private void textBoxName_TextChanged(object sender, EventArgs e) 
        {
            Text = textName.Text;
            if (textName.Text == "") Text = "Новая игра";
            buttonOK.Enabled = textName.Text != "";
        }

        private void GenreCat(object sender, EventArgs e)
        {
            FormCats form = new FormCats(3, Data.data.genres);
            form.ShowDialog();
            Genre.FillCombobox(comboGenre, game.genre);
        }

        private void GotoWebsite(object sender, EventArgs e)
        {
            if (textSite.Text == "") return;
            System.Diagnostics.Process.Start("http:" + textSite.Text);
        }

        private void OpenScrFolder(object sender, EventArgs e)
        {
            if (textSF.Text == "") return;
            game.scrFolder = textSF.Text;
            game.OpenScrFolder();
        }

        private void BrowseScrFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                textSF.Text = dialog.SelectedPath;
        }

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
            changePicture = OpenCover(file);
        }

        private void SelectCover(object sender, EventArgs e)
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

        private void RemoveCover(object sender, EventArgs e)
        {
            changePicture = true;
            newCover = "";
            pictureBoxCover.Image = null;
            pictureBoxCover.BackColor = SystemColors.AppWorkspace;
            labelCover.Visible = true;
        }

        bool OpenCover(string file)
        {
            try
            {
                labelCover.Visible = false;
                using (var File = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                    pictureBoxCover.Image = Image.FromStream(File);
                pictureBoxCover.BackColor = tabPageMain.BackColor;
                newCover = file;
                return true;
            }
            catch { return false; }
        }
        #endregion

        #region Versions
        private void AddVersion(object sender, EventArgs e)
        {
            Version version = new Version();
            FormVersion form = new FormVersion(version);
            if (form.ShowDialog() == DialogResult.OK)
            {
                versions.Add(version);
                DrawVersions();
                RefreshOthers();
            }
        }

        private void EditVersion(object sender, EventArgs e)
        {
            if (listViewVersions.SelectedIndices.Count == 1)
            {
                Version version = (Version)listViewVersions.SelectedItems[0].Tag;
                FormVersion form = new FormVersion(version);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DrawVersions();
                    RefreshOthers();
                }
            }
        }

        private void removeVersion(object sender, EventArgs e)
        {
            if (listViewVersions.SelectedIndices.Count == 1)
            {
                Version version = (Version)listViewVersions.SelectedItems[0].Tag;
                versions.Remove(version);
                DrawVersions();
                RefreshOthers();
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
            labelVers.Text = Data.StringVersions(versions);
            listViewVersions.EndUpdate();
            tabPagePurchases.Text = versions.Count + dlcs.Count > 0 ? "Покупки: " + (versions.Count + dlcs.Count).ToString() : "Покупки";
            listViewVersions_SelectedIndexChanged(null, null);
        }

        private void listViewVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewVersions.SelectedIndices.Count > 0;
            buttonChangeVersion.Enabled = sel;
            buttonDelVersion.Enabled = sel;
        }

        #endregion

        #region DLC
        private void AddDLC(object sender, EventArgs e)
        {
            DLC dlc = new DLC();
            FormDLC form = new FormDLC(dlc, versions);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dlcs.Add(dlc);
                DrawDLCs();
                RefreshOthers();
            }
        }

        private void EditDLC(object sender, EventArgs e)
        {
            if (listViewDLCs.SelectedIndices.Count == 1)
            {
                DLC dlc = (DLC)listViewDLCs.SelectedItems[0].Tag;
                FormDLC form = new FormDLC(dlc, versions);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DrawDLCs();
                    RefreshOthers();
                }
            }
        }

        private void RemoveDLC(object sender, EventArgs e)
        {
            if (listViewDLCs.SelectedIndices.Count == 1)
            {
                DLC dlc = (DLC)listViewDLCs.SelectedItems[0].Tag;
                dlcs.Remove(dlc);
                DrawDLCs();
                RefreshOthers();
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
            labelDLCs.Text = Data.StringDLCs(dlcs);
            listViewDLCs.EndUpdate();
            tabPagePurchases.Text = versions.Count + dlcs.Count > 0 ? "Покупки: " + (versions.Count + dlcs.Count).ToString() : "Покупки";
            ListViewDLCs_SelectedIndexChanged(null, null);
        }

        private void ListViewDLCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewDLCs.SelectedIndices.Count > 0;
            buttonChangeDLC.Enabled = sel;
            buttonDelDLC.Enabled = sel;
        }
        #endregion

        #region History
        private void AddEvent(object sender, EventArgs e)
        {
            Event ev = new Event();
            FormEvent form = new FormEvent(ev, versions, history);
            if (form.ShowDialog() == DialogResult.OK)
            {
                history.Add(ev);
                DrawHistory();
                RefreshOthers();
            }
        }

        private void EditEvent(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count == 1)
            {
                Event ev = (Event)listViewHistory.SelectedItems[0].Tag;
                FormEvent form = new FormEvent(ev, versions, history);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DrawHistory();
                    RefreshOthers();
                }
            }
        }

        private void RemoveEvent(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedIndices.Count == 1)
            {
                Event ev = (Event)listViewHistory.SelectedItems[0].Tag;
                history.Remove(ev);
                DrawHistory();
                RefreshOthers();
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
            labelHis.Text = Data.StringHistory(history); //Event.events[max] + ", общее время в игре: " + hours.ToString() + " ч.";
            listViewHistory.EndUpdate();
            tabPageHistory.Text = history.Count > 0 ? "История: " + (history.Count).ToString() : "История";
            listViewHistory_SelectedIndexChanged(null, null);
        }

        private void listViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool sel = listViewHistory.SelectedIndices.Count > 0;
            buttonChangeEvent.Enabled = sel;
            buttonDelEvent.Enabled = sel;
        }
        #endregion

        #region Notes
        void DrawNotes(bool add)
        {
            listViewNotes.BeginUpdate();
            listViewNotes.Items.Clear();
            foreach (Note n in notes)
                listViewNotes.Items.Add(n.listItem());
            listViewNotes.EndUpdate();
            if (add) listViewNotes.Items[listViewNotes.Items.Count - 1].Selected = true;
            tabPageNotes.Text = notes.Count > 0 ? "Заметки: " + (notes.Count).ToString() : "Заметки";
        }


        private void AddNote(object sender, EventArgs e)
        {
            notes.Add(new Note());
            DrawNotes(true);
        }

        private void ListViewNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count == 0)
            {
                buttonNoteDel.Enabled = false;
                dateTimeNote.Enabled = false;
                dateTimeNote.Value = DateTime.Now;
                textBoxNoteName.Enabled = false;
                textBoxNoteName.Text = "";
                textBoxNote.Enabled = false;
                textBoxNote.Text = "";
            }
            else
            {
                Note note = (Note)listViewNotes.SelectedItems[0].Tag;
                buttonNoteDel.Enabled = true;
                dateTimeNote.Enabled = true;
                dateTimeNote.Value = note.date;
                textBoxNoteName.Enabled = true;
                textBoxNoteName.Text = note.name;
                textBoxNote.Enabled = true;
                textBoxNote.Text = note.note;
            }
        }

        private void DateTimeNote_ValueChanged(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count == 0) return;
            Note note = (Note)listViewNotes.SelectedItems[0].Tag;
            note.date = dateTimeNote.Value;
            listViewNotes.SelectedItems[0].SubItems[0].Text = note.date.ToString("dd.MM.yyyy");
        }

        private void TextBoxNoteName_TextChanged(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count == 0) return;
            Note note = (Note)listViewNotes.SelectedItems[0].Tag;
            note.name = textBoxNoteName.Text;
            listViewNotes.SelectedItems[0].SubItems[1].Text = note.name;
        }

        private void TextBoxNote_TextChanged(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count == 0) return;
            Note note = (Note)listViewNotes.SelectedItems[0].Tag;
            note.note = textBoxNote.Text;
        }

        private void RemoveNote(object sender, EventArgs e)
        {
            if (listViewNotes.SelectedItems.Count == 0) return;
            Note note = (Note)listViewNotes.SelectedItems[0].Tag;
            notes.Remove(note);
            DrawNotes(false);
            ListViewNotes_SelectedIndexChanged(null, null);
        }
        #endregion

        #region Others
        void RefreshOthers()
        {
            string timeInCollection = "";
            string timeUntilPlay = "";
            string timePlay = "";
            string timeFromLastPlay = "";
            if (versions.Count > 0 & history.Count > 0)
            {
                DateTime firstPurchase = versions[0].date;
                DateTime firstPlay = history[0].date;
                DateTime lastPlay = history[history.Count - 1].date;
                timeInCollection = TimeSpanString(firstPurchase, DateTime.Now);
                timeUntilPlay = TimeSpanString(firstPurchase, firstPlay);
                timePlay = TimeSpanString(firstPlay, lastPlay);
                timeFromLastPlay = TimeSpanString(lastPlay, DateTime.Now);
            }
            labelInfo.Text = "Игра: " + game.name +
                "\n\nID: " + (game.ID != 0 ? game.ID.ToString() : "Присвоится при записи") +
                "\n\nДата создания: " + game.create +
                "\n\nДата последнего изменения: " + game.change +
                "\n\nВремени в коллекции: " + timeInCollection +
                "\n\nВремя с покупки до игры: " + timeUntilPlay +
                "\n\nПериод игры: " + timePlay +
                "\n\nПрошло времени с последней игры: " + timeFromLastPlay;
        }
        #endregion

    }
}