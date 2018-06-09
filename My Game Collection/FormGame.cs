using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Game_Collection
{
    public partial class FormGame : Form
    {
        Game game;
        public bool change;

        public FormGame(Game game)
        {
            this.game = game;
            InitializeComponent();
            change = false;
            textBoxName.Text = game.name;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonChangeVersion_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            game.name = textBoxName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e) { change = true; }
    }
}
