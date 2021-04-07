using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The can_invite_users permission of a supergroup chat was toggled
            /// </summary>
            public class ChatEventInvitesToggled : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventInvitesToggled";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// New value of can_invite_users permission
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_invite_users")]
                public bool CanInviteUsers { get; set; }
            }
        }
    }
}