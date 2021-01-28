using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;

namespace DiscordReportBot.Models
{
    public class report_t
    {
        [JsonProperty("channel_id")]
        public ulong channelId { get; set; }

        [JsonProperty("guild_id")]
        public ulong guildId { get; set; }

        [JsonProperty("message_id")]
        public ulong messageId { get; set; }

        [JsonProperty("reason")]
        public int reason { get; set; }
    }
    public class report_result_t
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }
    }
}
