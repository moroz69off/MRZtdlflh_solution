using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element containing the user's utility bill
            /// </summary>
            public class PassportElementUtilityBill : PassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementUtilityBill";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Utility bill
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("utility_bill")]
                public PersonalDocument UtilityBill { get; set; }
            }
        }
    }
}