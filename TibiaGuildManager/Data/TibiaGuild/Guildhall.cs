using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaGuildManager.Data.TibiaGuild
{
    public class Guildhall
    {
        public string name { get; set; }
        public string town { get; set; }
        public string paid { get; set; }
        public string world { get; set; }
        public int houseid { get; set; }
    }
}
