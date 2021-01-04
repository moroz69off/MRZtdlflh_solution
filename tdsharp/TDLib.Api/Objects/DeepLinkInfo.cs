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
        /// Contains information about a tg:// deep link
        /// </summary>
        public partial class DeepLinkInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deepLinkInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Text to be shown to the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public FormattedText Text { get; set; }

            /// <summary>
            /// True, if user should be asked to update the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_update_application")]
            public bool NeedUpdateApplication { get; set; }
        }
    }
}