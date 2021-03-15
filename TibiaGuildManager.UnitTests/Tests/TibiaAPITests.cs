using System;
using System.Threading.Tasks;
using Xunit;
using TibiaGuildManager.Data;
using TibiaGuildManager.Services;

namespace TibiaGuildManager.UnitTests.Tests
{
    public class TibiaAPITests
    {
        [Fact]
        public async Task GetGuildTest()
        {
            TibiaAPIService tibiaAPIService = new TibiaAPIService();
            var guild = await tibiaAPIService.GetGuild("Immortal");
            Assert.NotNull(guild);
        }
    }
}
