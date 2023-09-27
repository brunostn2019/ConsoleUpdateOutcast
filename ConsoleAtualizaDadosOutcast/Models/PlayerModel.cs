using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsOutcast.Models
{
    public class PlayerModel
    {
        public DateTime Data { get; set; }
        public String Nome { get; set; }
        public int MagicLevel { get; set; }
        public String Guild { get; set; }
        public String Vocation { get; set; }
        public String Gender { get; set; }
        public int Level { get; set; }
        public int Rank { get; set; }
        public int Age { get; set; }
        public decimal LevelPerDayAvg { get; set; }


    }
}
