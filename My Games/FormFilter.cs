namespace My_Games
{
    public partial class FormFilter : Form
    {
        bool isUser = false;
        public FormFilter()
        {
            Filter fl = Data.data.filter;

            InitializeComponent();

            dateTimeStart.Value = fl.start;
            checkBoxStart.Checked = fl.startEnable;

            dateTimeEnd.Value = fl.end;
            checkBoxEnd.Checked = fl.endEnable;

            Platform.FillCombobox(comboBoxPlatform, 0, true, null);
            comboBoxPlatform.SelectedItem = Data.PlatformIDToName(fl.platform);
            checkBoxPlatform.Checked = fl.platformEnable;

            Medium.FillCombobox(comboBoxMedium, 0, "");
            comboBoxMedium.SelectedItem = Data.MediumIDToName(fl.medium);
            checkBoxMedium.Checked = fl.mediumEnable;

            Genre.FillCombobox(comboBoxGenre, 0);
            comboBoxGenre.SelectedItem = Data.GenreIDToName(fl.genre);
            checkBoxGenre.Checked = fl.genreEnable;

            isUser = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Filter fl = Data.data.filter;
            fl.start = dateTimeStart.Value;
            fl.startEnable = checkBoxStart.Checked;
            fl.end = dateTimeEnd.Value;
            fl.endEnable = checkBoxEnd.Checked;
            fl.platform = Data.PlatformNameToID(comboBoxPlatform.SelectedItem.ToString());
            fl.platformEnable = checkBoxPlatform.Checked;
            fl.medium = Data.MediumNameToID(comboBoxMedium.SelectedItem.ToString());
            fl.mediumEnable = checkBoxMedium.Checked;
            fl.genre = Data.GenreNameToID(comboBoxGenre.SelectedItem.ToString());
            fl.genreEnable = checkBoxGenre.Checked;
            fl.enable = fl.startEnable | 
                        fl.endEnable | 
                        fl.platformEnable | 
                        fl.mediumEnable | 
                        fl.genreEnable;
            Close();
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
            checkBoxStart.Checked = true;
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            checkBoxEnd.Checked = true;
        }

        private void comboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUser) checkBoxPlatform.Checked = comboBoxPlatform.SelectedIndex > 0;
        }

        private void comboBoxMedium_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUser) checkBoxMedium.Checked = comboBoxMedium.SelectedIndex > 0;
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUser) checkBoxGenre.Checked = comboBoxGenre.SelectedIndex > 0;
        }
    }
}
