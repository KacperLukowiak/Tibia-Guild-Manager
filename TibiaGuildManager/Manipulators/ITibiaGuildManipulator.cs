using System.Collections.Generic;
using TibiaGuildManager.Data.TibiaGuild;

namespace TibiaGuildManager.Manipulators
{
    public interface ITibiaGuildManipulator
    {
        List<Character> PullAllCharacters(GuildRoot guildRoot);
    }
}