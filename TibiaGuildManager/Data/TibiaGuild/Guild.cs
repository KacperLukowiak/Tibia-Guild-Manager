using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaGuildManager.Data.TibiaGuild
{
    public class Guild
    {
        public Data data { get; set; }
        public List<Member> members { get; set; }
    }
}
