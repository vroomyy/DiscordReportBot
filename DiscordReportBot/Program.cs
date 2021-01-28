using Discord;
using Discord.Gateway;
using DiscordReportBot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiscordReportBot
{
    class Program
    {
        private static report_t Report = new report_t();

        static void Main(string[] args)
        {
            Console.WriteLine("Guild ID:");
            Report.guildId = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Channel ID:");
            Report.channelId = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Message ID:");
            Report.messageId = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Reason [0-4]:");
            Report.reason = int.Parse(Console.ReadLine());

            string token = File.ReadAllLines("Token.txt").First();
            DiscordSocketClient client = new DiscordSocketClient();
            client.OnLoggedIn += Client_OnLoggedIn;
            client.Login(token);

            Console.Clear();
            Thread.Sleep(-1);
        }

        private async static void Client_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            while (true)
            {
                try
                {
                    var report = client.Report(Report);
                    ConsoleUtils.Success($"Report Sent! [Id: {report.Id}]");

                }
                catch (DiscordHttpException ex) 
                { 
                    ConsoleUtils.Error("Failed to report"); 
                }
            }
        }
    }
}
