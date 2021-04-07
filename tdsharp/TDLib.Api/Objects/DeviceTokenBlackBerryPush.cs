using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class DeviceToken : Object
        {
            /// <summary>
            /// A token for BlackBerry Push Service
            /// </summary>
            public class DeviceTokenBlackBerryPush : DeviceToken
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "deviceTokenBlackBerryPush";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Token; may be empty to de-register a device
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("token")]
                public string Token { get; set; }
            }
        }
    }
}