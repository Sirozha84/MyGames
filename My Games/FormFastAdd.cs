using System;
using System.Windows.Forms;

namespace My_Games
{
    public partial class FormFastAdd : Form
    {
        Game game;

        public FormFastAdd(Game game)
        {
            InitializeComponent();
            this.game = game;
            comboBoxRate.DataSource = Game.stars;
            comboBoxRate.SelectedIndex = game.rate - 1;
            Genre.FillCombobox(comboBoxGenre, 0);
            Platform.FillCombobox(comboBoxPlatform, 0, true, null);
            Medium.FillCombobox(comboBoxMedium, 0, "");
            textBoxName_TextChanged(null, null);
        }

        /// <summary>
        /// Заполнение важных полей по "быстрой анкете"
        /// </summary>
        void Create()
        {
            game.ID = ++Data.data.gameLastID;
            game.date = date.Value;
            game.change = DateTime.Now;
            game.name = textBoxName.Text;
            game.genre = Data.GenreNameToID(comboBoxGenre.Text);
            game.rate = comboBoxRate.SelectedIndex + 1;
            game.price = Convert.ToInt32(textBoxPrice.Text);
            Version version = new Version();
            version.date = date.Value;
            version.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            version.medium = Data.MediumNameToID(comboBoxMedium.Text);
            version.price = game.price;
            game.versions.Add(version);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Create();
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Create();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(3, Data.data.genres);
            form.ShowDialog();
            Genre.FillCombobox(comboBoxGenre, game.genre);
        }

        private void linkLabelPlatform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(1, Data.data.platforms);
            form.ShowDialog();
            Platform.FillCombobox(comboBoxPlatform, 0, true, null);
        }

        private void linkLabelMedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCats form = new FormCats(2, Data.data.mediums);
            form.ShowDialog();
            Medium.FillCombobox(comboBoxMedium, 0, comboBoxPlatform.Text);
        }

        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medium.FillCombobox(comboBoxMedium, 0, comboBoxPlatform.Text);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonOK.Enabled = textBoxName.Text != "";
        }
    }
}
