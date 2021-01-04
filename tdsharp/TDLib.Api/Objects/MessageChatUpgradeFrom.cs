using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A supergroup has been created from a basic group
            /// </summary>
            public class MessageChatUpgradeFrom : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatUpgradeFrom";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Title of the newly created supergroup
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// The identifier of the original basic group
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("basic_group_id")]
                public int BasicGroupId { get; set; }
            }
        }
    }
}