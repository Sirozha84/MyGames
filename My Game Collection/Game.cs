using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Game_Collection
{
    class Game
    {
        string name;
        DateTime date;
        List<Version> versions = new List<Version>();
        List<DLC> DLCs = new List<DLC>();
        List<Event> History = new List<Event>();
    }
}
