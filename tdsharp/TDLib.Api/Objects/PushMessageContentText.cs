using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PushMessageContent : Object
        {
            /// <summary>
            /// A text message
            /// </summary>
            public class PushMessageContentText : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentText";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Message text
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public string Text { get; set; }

                /// <summary>
                /// True, if the message is a pinned message with the specified content
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_pinned")]
                public bool IsPinned { get; set; }
            }
        }
    }
}