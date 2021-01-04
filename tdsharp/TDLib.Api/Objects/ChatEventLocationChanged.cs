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
            /// The supergroup location was changed
            /// </summary>
            public class ChatEventLocationChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventLocationChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous location; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_location")]
                public ChatLocation OldLocation { get; set; }

                /// <summary>
                /// New location; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_location")]
                public ChatLocation NewLocation { get; set; }
            }
        }
    }
}