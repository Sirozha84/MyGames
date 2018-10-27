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
    public partial class FormFastAdd : Form
    {
        Game game;

        public FormFastAdd(Game game)
        {
            InitializeComponent();
            this.game = game;
            comboBoxRate.DataSource = Game.stars;
            comboBoxRate.SelectedIndex = game.rate - 1;
            Genre.FillCombobox(comboBoxGenre, game.genre);
            Platform.FillCombobox(comboBoxPlatform, game.genre);
            Medium.FillCombobox(comboBoxMedium, game.genre);
        }

        /// <summary>
        /// Заполнение важных полей по "быстрой анкете"
        /// </summary>
        void Create()
        {
            game.name = textBoxName.Text;
            game.genre = Data.GenreNameToID(comboBoxGenre.Text);
            game.rate = comboBoxRate.SelectedIndex + 1;
            Version version = new Version();
            version.date = date.Value;
            version.platform = Data.PlatformNameToID(comboBoxPlatform.Text);
            version.medium = Data.MediumNameToID(comboBoxMedium.Text);
            version.price = Convert.ToInt32(textBoxPrice.Text);
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
    }
}
