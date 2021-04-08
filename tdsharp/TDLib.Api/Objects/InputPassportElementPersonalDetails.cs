using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputPassportElement : Object
        {
            /// <summary>
            /// Contains information about a Telegram Passport element to be saved
            /// </summary>
            public class InputPassportElementPersonalDetails : InputPassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementPersonalDetails";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Personal details of the user
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("personal_details")]
                public PersonalDetails PersonalDetails { get; set; }
            }
        }
    }
}