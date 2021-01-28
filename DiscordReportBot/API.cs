using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using DiscordReportBot.Models;

namespace DiscordReportBot
{
    public static class API
    {
        public static report_result_t Report(this DiscordClient client, report_t report)
        {
            return client.HttpClient.Post("/report", report).Deserialize<report_result_t>();
        }
    }
}
