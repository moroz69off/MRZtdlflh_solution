using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InlineQueryResult : Object
        {
            /// <summary>
            /// Represents a voice note
            /// </summary>
            public class InlineQueryResultVoiceNote : InlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultVoiceNote";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique identifier of the query result
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                /// <summary>
                /// Voice note
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("voice_note")]
                public VoiceNote VoiceNote { get; set; }

                /// <summary>
                /// Title of the voice note
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }
            }
        }
    }
}