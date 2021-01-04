using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ReplyMarkup : Object
        {
            /// <summary>
            /// Contains a custom keyboard layout to quickly reply to bots
            /// </summary>
            public class ReplyMarkupShowKeyboard : ReplyMarkup
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "replyMarkupShowKeyboard";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// A list of rows of bot keyboard buttons
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("rows")]
                public KeyboardButton[][] Rows { get; set; }

                /// <summary>
                /// True, if the application needs to resize the keyboard vertically
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("resize_keyboard")]
                public bool ResizeKeyboard { get; set; }

                /// <summary>
                /// True, if the application needs to hide the keyboard after use
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("one_time")]
                public bool OneTime { get; set; }

                /// <summary>
                /// True, if the keyboard must automatically be shown to the current user. For outgoing messages, specify true to show the keyboard only for the mentioned users and for the target user of a reply
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_personal")]
                public bool IsPersonal { get; set; }
            }
        }
    }
}