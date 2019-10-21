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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            label2.Text = "Версия: " + Program.Version;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }
    }
}
