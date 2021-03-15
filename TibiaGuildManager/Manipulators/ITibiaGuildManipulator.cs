using System.Collections.Generic;
using TibiaGuildManager.Data.TibiaGuild;

namespace TibiaGuildManager.Manipulators
{
    public interface ITibiaGuildManipulator
    {
        /// <summary>
        /// Pulls all characters from the GuildRoot object. 
        /// Additionally gets rank and saves it in Character object.
        /// </summary>
        /// <param name="guildRoot"></param>
        /// <returns>
        /// A list of Character objects
        /// </returns>
        List<Character> PullAllCharacters(GuildRoot guildRoot);
        HashSet<string> PullRanks(GuildRoot guildRoot);
    }
}