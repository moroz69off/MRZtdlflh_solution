using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PageBlock : Object
        {
            /// <summary>
            /// A link to a chat
            /// </summary>
            public class PageBlockChatLink : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockChatLink";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Chat title
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// Chat photo; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public ChatPhotoInfo Photo { get; set; }

                /// <summary>
                /// Chat username, by which all other information about the chat should be resolved
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("username")]
                public string Username { get; set; }
            }
        }
    }
}