using System;

namespace My_Game_Collection
{
    public abstract class CatItem : IComparable
    {
        public int ID;
        protected int Counter = 1;
        public string name;
        public abstract int CompareTo(object obj);
    }
}
