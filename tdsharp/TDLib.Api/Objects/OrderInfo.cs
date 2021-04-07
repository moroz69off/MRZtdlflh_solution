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
        /// Order information
        /// </summary>
        public partial class OrderInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "orderInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Name of the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Phone number of the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// Email address of the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("email_address")]
            public string EmailAddress { get; set; }

            /// <summary>
            /// Shipping address for this order; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shipping_address")]
            public Address ShippingAddress { get; set; }
        }
    }
}