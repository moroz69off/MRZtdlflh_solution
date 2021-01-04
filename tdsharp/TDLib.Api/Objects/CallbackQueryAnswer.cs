using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains a bot's answer to a callback query
        /// </summary>
        public partial class CallbackQueryAnswer : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "callbackQueryAnswer";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Text of the answer
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public string Text { get; set; }

            /// <summary>
            /// True, if an alert should be shown to the user instead of a toast notification
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("show_alert")]
            public bool ShowAlert { get; set; }

            /// <summary>
            /// URL to be opened
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }
        }
    }
}