using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();

            //Заполняем выпадающме списки и выбираем первый пункт
            comboBoxType.Items.Add("Все");
            comboBoxType.Items.Add("Игры");
            comboBoxType.Items.Add("DLC");
            comboBoxType.SelectedIndex = 0;

            comboBoxPlatform.Items.Add("Все");
            foreach (Platform pl in Data.data.platforms)
                comboBoxPlatform.Items.Add(pl.name);
            comboBoxPlatform.SelectedIndex = 0;

            comboBoxMedium.Items.Add("Все");
            foreach (Medium md in Data.data.mediums)
                comboBoxMedium.Items.Add(md.name);
            comboBoxMedium.SelectedIndex = 0;

            comboBoxGenre.Items.Add("Все");
            foreach (Genre gr in Data.data.genres)
                comboBoxGenre.Items.Add(gr.name);
            comboBoxGenre.SelectedIndex = 0;

            Refresh();
        }

        void Refresh()
        {
            listViewHistory.BeginUpdate();
            listViewHistory.Items.Clear();
            foreach (Game game in Data.data.games)
            {
                if (comboBoxType.SelectedIndex == 0 | comboBoxType.SelectedIndex == 1)
                {
                    foreach (Version ver in game.versions)
                    {
                        string[] str = { ver.date.ToString("dd.MM.yyyy"),
                        "Игра",
                        game.name,
                        Data.PlatformIDToName(ver.platform),
                        Data.MediumIDToName(ver.medium),
                        Data.GenreIDToName(game.genre),
                        ver.price.ToString()};
                        listViewHistory.Items.Add(new ListViewItem(str));
                    }
                }
                if (comboBoxType.SelectedIndex == 0 | comboBoxType.SelectedIndex == 2)
                {
                    foreach (DLC dlc in game.DLCs)
                    {
                        string[] str = { dlc.date.ToString("dd.MM.yyyy"),
                        "DLC",
                        game.name,
                        Data.PlatformIDToName(dlc.platform),
                        "",
                        Data.GenreIDToName(game.genre),
                        dlc.price.ToString()};
                        listViewHistory.Items.Add(new ListViewItem(str));
                    }
                }
            }
            listViewHistory.EndUpdate();
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e) { Refresh(); }
        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e) { Refresh(); }
        private void ComboBoxMedium_SelectedIndexChanged(object sender, EventArgs e) { Refresh(); }
        private void ComboBoxGenre_SelectedIndexChanged(object sender, EventArgs e) { Refresh(); }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxPlatform.SelectedIndex = 0;
            comboBoxMedium.SelectedIndex = 0;
            comboBoxGenre.SelectedIndex = 0;
            Refresh();
        }
    }
}
