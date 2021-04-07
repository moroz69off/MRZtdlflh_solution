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
            /// Notification settings for some type of chats were updated
            /// </summary>
            public class UpdateScopeNotificationSettings : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateScopeNotificationSettings";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Types of chats for which notification settings were updated
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("scope")]
                public NotificationSettingsScope Scope { get; set; }

                /// <summary>
                /// The new notification settings
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("notification_settings")]
                public ScopeNotificationSettings NotificationSettings { get; set; }
            }
        }
    }
}