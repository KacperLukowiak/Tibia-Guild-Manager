using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaGuildManager.Data.TibiaGuild
{
    public class Data
    {
        public string name { get; set; }
        public string description { get; set; }
        public Guildhall guildhall { get; set; }
        public bool application { get; set; }
        public bool war { get; set; }
        public int online_status { get; set; }
        public int offline_status { get; set; }
        public bool disbanded { get; set; }
        public int totalmembers { get; set; }
        public int totalinvited { get; set; }
        public string world { get; set; }
        public string founded { get; set; }
        public bool active { get; set; }
        public string guildlogo { get; set; }
    }
}
