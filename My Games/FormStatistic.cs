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
    public partial class FormStatistic : Form
    {
        Graphics graph, graphl;
        Bitmap bmp, bmpl;
        int gWidth, gHeight, lWidth, lHeight;

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            DrawGraph();
        }

        public FormStatistic()
        {
            InitializeComponent();
            graph = pictureBoxGraph.CreateGraphics();
            
        }

        void DrawGraph()
        {
            gWidth = pictureBoxGraph.Width;
            gHeight = pictureBoxGraph.Height;
            lWidth = pictureBoxLegend.Width;
            lHeight = pictureBoxLegend.Height;
            bmp = new Bitmap(gWidth, gHeight);
            bmpl = new Bitmap(lWidth, lHeight);
            graph = Graphics.FromImage(bmp);
            graphl = Graphics.FromImage(bmpl);
            graph.DrawLine(Pens.Black, 0, 0, gWidth, gHeight);
            graphl.DrawLine(Pens.Black, 0, 0, lWidth, lHeight);
            pictureBoxGraph.Image = bmp;
            pictureBoxLegend.Image = bmpl;
        }

        private void FormStatistic_Paint(object sender, PaintEventArgs e) { DrawGraph(); }
    }
}
