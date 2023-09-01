using System.Data;
using System.Threading.Tasks;
using Discord.Commands;
using Microsoft.Extensions.Logging;

namespace DISCORDBOTV2.Modules
{
    public class TestModule : ModuleBase<SocketCommandContext>
    {
        private readonly ILogger<TestModule> _logger;

        public TestModule(ILogger<TestModule> logger)
            => _logger = logger;

        [Command("Тест")]
        public async Task TestAsync()
        {
            await ReplyAsync("Тест");
            _logger.LogInformation($"{Context.User.Username} executed the test command!");
        }

    }

}
