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
        /// Reports a chat to the Telegram moderators. A chat can be reported only from the chat action bar, or if this is a private chats with a bot, a private chat with a user sharing their location, a supergroup, or a channel, since other chats can't be checked by moderators
        /// </summary>
        public class ReportChat : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "reportChat";

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
            /// The reason for reporting the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reason")]
            public ChatReportReason Reason { get; set; }

            /// <summary>
            /// Identifiers of reported messages, if any
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_ids")]
            public long[] MessageIds { get; set; }
        }

        /// <summary>
        /// Reports a chat to the Telegram moderators. A chat can be reported only from the chat action bar, or if this is a private chats with a bot, a private chat with a user sharing their location, a supergroup, or a channel, since other chats can't be checked by moderators
        /// </summary>
        public static Task<Ok> ReportChatAsync(
            this Client client, long chatId = default, ChatReportReason reason = default, long[] messageIds = default)
        {
            return client.ExecuteAsync(new ReportChat
            {
                ChatId = chatId, Reason = reason, MessageIds = messageIds
            });
        }
    }
}