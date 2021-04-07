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
        /// Contains information about a Telegram Passport elements and corresponding errors
        /// </summary>
        public partial class PassportElementsWithErrors : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "passportElementsWithErrors";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Telegram Passport elements
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("elements")]
            public PassportElement[] Elements { get; set; }

            /// <summary>
            /// Errors in the elements that are already available
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("errors")]
            public PassportElementError[] Errors { get; set; }
        }
    }
}