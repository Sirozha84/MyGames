using System;
using System.Drawing;

namespace My_Games
{
    public abstract class CatItem : IComparable
    {
        public int ID;
        protected int Counter = 1;
        public string name;
        public int colR = -1;
        public int colG = -1;
        public int colB = -1;
        static Random rnd = new Random();
        public abstract int CompareTo(object obj);
        internal Color color
        {
            set
            {
                colR = value.R;
                colG = value.G;
                colB = value.B;
            }
            get
            {
                if (colR < 0) NewColor();
                return Color.FromArgb(colR, colG, colB);
            }
        }

        void NewColor()
        {
            colR = rnd.Next(128, 255);
            colG = rnd.Next(128, 255);
            colB = rnd.Next(128, 255);
        }
    }
}
