using System.Threading.Tasks;
using TibiaGuildManager.Data.TibiaGuild;

namespace TibiaGuildManager.Services
{
    public interface ITibiaAPIService
    {
        Task<GuildRoot> GetGuild(string guild);
    }
}