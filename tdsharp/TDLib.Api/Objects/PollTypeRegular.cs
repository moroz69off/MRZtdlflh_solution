using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PollType : Object
        {
            /// <summary>
            /// Describes the type of a poll
            /// </summary>
            public class PollTypeRegular : PollType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pollTypeRegular";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if multiple answer options can be chosen simultaneously
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("allow_multiple_answers")]
                public bool AllowMultipleAnswers { get; set; }
            }
        }
    }
}