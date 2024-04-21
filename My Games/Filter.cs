using System;

namespace My_Games
{
    public class Filter
    {
        public bool enable;
        
        public bool startEnable;
        public DateTime start = DateTime.Now;
        
        public bool endEnable;
        public DateTime end = DateTime.Now;
        
        public bool platformEnable;
        public int platform;
        
        public bool mediumEnable;
        public int medium;
        
        public bool genreEnable;
        public int genre;

        public bool yearEnable;
        public string year;
    }
}
