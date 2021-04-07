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
            /// Telegram Passport data has been sent
            /// </summary>
            public class MessagePassportDataSent : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messagePassportDataSent";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// List of Telegram Passport element types sent
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("types")]
                public PassportElementType[] Types { get; set; }
            }
        }
    }
}