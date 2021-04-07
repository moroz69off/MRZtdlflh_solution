using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Returns detailed statistics about a chat. Currently this method can be used only for supergroups and channels. Can be used only if SupergroupFullInfo.can_get_statistics == true
        /// </summary>
        public class GetChatStatistics : Function<ChatStatistics>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatStatistics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Pass true if a dark theme is used by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_dark")]
            public bool IsDark { get; set; }
        }

        /// <summary>
        /// Returns detailed statistics about a chat. Currently this method can be used only for supergroups and channels. Can be used only if SupergroupFullInfo.can_get_statistics == true
        /// </summary>
        public static Task<ChatStatistics> GetChatStatisticsAsync(
            this Client client, long chatId = default, bool isDark = default)
        {
            return client.ExecuteAsync(new GetChatStatistics
            {
                ChatId = chatId, IsDark = isDark
            });
        }
    }
}