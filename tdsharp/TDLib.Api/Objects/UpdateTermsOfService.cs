using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// New terms of service must be accepted by the user. If the terms of service are declined, then the deleteAccount method should be called with the reason "Decline ToS update"
            /// </summary>
            public class UpdateTermsOfService : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateTermsOfService";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the terms of service
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("terms_of_service_id")]
                public string TermsOfServiceId { get; set; }

                /// <summary>
                /// The new terms of service
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("terms_of_service")]
                public TermsOfService TermsOfService { get; set; }
            }
        }
    }
}