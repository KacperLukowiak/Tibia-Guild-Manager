using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaGuildManager.Data.TibiaGuild
{
    public class Character
    {
        public string name { get; set; }
        public string nick { get; set; }
        public int level { get; set; }
        public string vocation { get; set; }
        public string joined { get; set; }
        public string status { get; set; }
    }
}
