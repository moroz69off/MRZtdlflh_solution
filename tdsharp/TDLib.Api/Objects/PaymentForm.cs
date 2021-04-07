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
        /// Contains information about an invoice payment form
        /// </summary>
        public partial class PaymentForm : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "paymentForm";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Full information of the invoice
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invoice")]
            public Invoice Invoice { get; set; }

            /// <summary>
            /// Payment form URL
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// Contains information about the payment provider, if available, to support it natively without the need for opening the URL; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("payments_provider")]
            public PaymentsProviderStripe PaymentsProvider { get; set; }

            /// <summary>
            /// Saved server-side order information; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("saved_order_info")]
            public OrderInfo SavedOrderInfo { get; set; }

            /// <summary>
            /// Contains information about saved card credentials; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("saved_credentials")]
            public SavedCredentials SavedCredentials { get; set; }

            /// <summary>
            /// True, if the user can choose to save credentials
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_save_credentials")]
            public bool CanSaveCredentials { get; set; }

            /// <summary>
            /// True, if the user will be able to save credentials protected by a password they set up
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_password")]
            public bool NeedPassword { get; set; }
        }
    }
}