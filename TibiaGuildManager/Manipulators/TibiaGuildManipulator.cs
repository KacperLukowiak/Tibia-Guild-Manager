using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TibiaGuildManager.Data.TibiaGuild;

namespace TibiaGuildManager.Manipulators
{
    public class TibiaGuildManipulator : ITibiaGuildManipulator
    {
        public List<Character> PullAllCharacters(GuildRoot guildRoot)
        {
            if (guildRoot is null)
            {
                return null;
            }
            List<Character> characterList = new List<Character>();
            foreach (var member in guildRoot.guild.members)
            {
                foreach (var character in member.characters)
                {
                    characterList.Add(character);
                }
            }
            return characterList;
        }

    }
}
