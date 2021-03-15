using System;
using System.Threading.Tasks;
using Xunit;
using TibiaGuildManager.Data.TibiaGuild;
using TibiaGuildManager.Services;
using TibiaGuildManager.Manipulators;
using System.Text.Json;

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
            Assert.Equal(64, characters.Count);
        }
    }
}
