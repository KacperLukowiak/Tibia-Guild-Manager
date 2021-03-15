using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaGuildManager.Data.TibiaGuild
{
    public class Member
    {
        public string rank_title { get; set; }
        public List<Character> characters { get; set; }
    }
}
