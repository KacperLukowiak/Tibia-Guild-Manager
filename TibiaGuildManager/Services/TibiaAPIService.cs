using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TibiaGuildManager.Data;

namespace TibiaGuildManager.Services
{
    public class TibiaAPIService
    {
        private static HttpClient tibiaAPIClient;
        private string APIURI;

        public TibiaAPIService()
        {
            APIURI = "https://api.tibiadata.com/v2/";
            tibiaAPIClient = new HttpClient();
        }

        public async Task<TibiaGuild.Root> GetGuild(string guild)
        {
            guild = guild.Replace(" ", "+");
            HttpResponseMessage httpResponseMessage = await tibiaAPIClient.GetAsync(APIURI + "guild/" + guild + ".json");
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                return null;
            }
            string response = await httpResponseMessage.Content.ReadAsStringAsync();
            TibiaGuild.Root tibiaGuild = JsonSerializer.Deserialize<TibiaGuild.Root>(response);
            return tibiaGuild;
        }
    }
}
