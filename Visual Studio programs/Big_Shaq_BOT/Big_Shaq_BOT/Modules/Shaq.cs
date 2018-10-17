using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Big_Shaq_BOT.Modules
{
    public class Shaq : ModuleBase<SocketCommandContext>
    {
        [Command("Zdr")]
        public async Task Zdr()
        {
            await Context.Channel.SendMessageAsync("Em zdr");
        }

        [Command("Mn li si goten")]
        public async Task Goten()
        {
            await Context.Channel.SendMessageAsync("est");
        }

        [Command("Kak si")]
        public async Task Kak_si()
        {
            await Context.Channel.SendMessageAsync("emi sredna rabota,  ti?");
        }

        [Command("Dobre")]
        public async Task Good()
        {
            await Context.Channel.SendMessageAsync("Men kvo me interesuva");
        }

        [Command("Leka")]
        public async Task Night()
        {
            await Context.Channel.SendMessageAsync("Emi kak reshish. \n Lekar s noj ;D");
        }

        [Command("alo?")]
        public async Task ALO()
        {
            await Context.Channel.SendMessageAsync("MAIKATASIEEBALO");
        }

        [Command("2+2 is 4")]
        public async Task math()
        {
            await Context.Channel.SendMessageAsync("-1 thats 3 quick maths ;D");
        }

        [Command("the tings go")]

        public async Task skra()
        {
            await Context.Channel.SendMessageAsync("Scrrraaaa");
        }
    }
}
