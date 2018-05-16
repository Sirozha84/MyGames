﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Game Collection\nВерсия 0.1");
        }

        private void toolStripButton1_Click(object sender, EventArgs e) { новаяToolStripMenuItem_Click(null, null); }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            FormGame form = new FormGame(game);
            form.ShowDialog();
        }
    }
}