using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InlineKeyboardButtonType : Object
        {
            /// <summary>
            /// Describes the type of an inline keyboard button
            /// </summary>
            public class InlineKeyboardButtonTypeUrl : InlineKeyboardButtonType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineKeyboardButtonTypeUrl";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// HTTP or tg:// URL to open
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }
            }
        }
    }
}