using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class UserPrivacySetting : Object
        {
            /// <summary>
            /// A privacy setting for managing whether peer-to-peer connections can be used for calls
            /// </summary>
            public class UserPrivacySettingAllowPeerToPeerCalls : UserPrivacySetting
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingAllowPeerToPeerCalls";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}