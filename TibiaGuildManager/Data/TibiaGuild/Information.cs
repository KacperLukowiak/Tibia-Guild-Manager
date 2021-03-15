using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TibiaGuildManager.Data.TibiaGuild
{
    public class Information
    {
        public int api_version { get; set; }
        public double execution_time { get; set; }
        public string last_updated { get; set; }
        public string timestamp { get; set; }
    }
}
