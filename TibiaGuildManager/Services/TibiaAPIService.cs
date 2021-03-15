using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TibiaGuildManager.Data.TibiaGuild;

namespace TibiaGuildManager.Services
{
    public class TibiaAPIService : ITibiaAPIService
    {
        private static HttpClient tibiaAPIClient;
        private string APIURI;

        public TibiaAPIService()
        {
            APIURI = "https://api.tibiadata.com/v2/";
            tibiaAPIClient = new HttpClient();
        }

        public async Task<GuildRoot> GetGuild(string guild)
        {
            guild = guild.Replace(" ", "+");
            HttpResponseMessage httpResponseMessage = await tibiaAPIClient.GetAsync(APIURI + "guild/" + guild + ".json");
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                return null;
            }
            string response = await httpResponseMessage.Content.ReadAsStringAsync();
            GuildRoot tibiaGuild = JsonSerializer.Deserialize<GuildRoot>(response);
            return tibiaGuild;
        }
    }
}
