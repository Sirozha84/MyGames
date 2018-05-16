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
        public FormGame(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show(game.rate.ToString());
        }
    }
}
