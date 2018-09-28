using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;

namespace EchoBot
{
    public class EchoBot : IBot
    {      
        public async Task OnTurn(ITurnContext context)
        {
            // This bot is only handling Messages
            if (context.Activity.Type == ActivityTypes.Message)
            {
                // Echo back to the user whatever they typed.
                await context.SendActivity($"Você digitou: '{context.Activity.Text}'");
            }
        }
    }    
}
