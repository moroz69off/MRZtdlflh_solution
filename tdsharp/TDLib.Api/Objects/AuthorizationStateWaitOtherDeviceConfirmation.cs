using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// The user needs to confirm authorization on another logged in device by scanning a QR code with the provided link
            /// </summary>
            public class AuthorizationStateWaitOtherDeviceConfirmation : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitOtherDeviceConfirmation";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// A tg:// URL for the QR code. The link will be updated frequently
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("link")]
                public string Link { get; set; }
            }
        }
    }
}