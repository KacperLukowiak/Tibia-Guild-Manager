using System;
using System.Threading.Tasks;
using Xunit;
using TibiaGuildManager.Data.TibiaGuild;
using TibiaGuildManager.Services;
using TibiaGuildManager.Manipulators;
using System.Text.Json;
using System.Collections.Generic;

namespace TibiaGuildManager.UnitTests.Tests
{
    public class TibiaGuildManipulatorTests
    {
        private ITibiaGuildManipulator _tibiaGuildManipulator;
        private GuildRoot _guildRoot;
        public TibiaGuildManipulatorTests()
        {
            _tibiaGuildManipulator = new TibiaGuildManipulator();
            string text = System.IO.File.ReadAllText(@"Data\Immortal.json");
            _guildRoot = JsonSerializer.Deserialize<GuildRoot>(text);
        }

        [Fact]
        public void PullAllCharactersTest()
        {
            var characters = _tibiaGuildManipulator.PullAllCharacters(_guildRoot);
            HashSet<string> ranks = new HashSet<string>();
            Assert.Equal(64, characters.Count);
            foreach (var character in characters)
            {
                ranks.Add(character.rank);
            }
            Assert.Equal(8, ranks.Count);
        }

        [Fact]
        public void PullRanksTest()
        {
            string[] ranksExpected =
            {
                "Leader", "Icon", "First", "Second", "Third", "Fourth", "Fifth", "Trial"
            };
            var ranks = _tibiaGuildManipulator.PullRanks(_guildRoot);
            Assert.Equal(8, ranks.Count);

            for (int i = 0; i < ranksExpected.Length; i++)
            {
                Assert.Contains(ranksExpected[i], ranks);
            }
        }
    }
}
