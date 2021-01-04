using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// User activity in the chat has changed
            /// </summary>
            public class UpdateUserChatAction : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateUserChatAction";

                /// <summary>
                /// Extra data attached to the message
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
                /// If not 0, a message thread identifier in which the action was performed
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_thread_id")]
                public long MessageThreadId { get; set; }

                /// <summary>
                /// Identifier of a user performing an action
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }

                /// <summary>
                /// The action description
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("action")]
                public ChatAction Action { get; set; }
            }
        }
    }
}