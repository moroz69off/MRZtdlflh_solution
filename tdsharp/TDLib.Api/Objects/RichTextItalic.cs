using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class RichText : Object
        {
            /// <summary>
            /// An italicized rich text
            /// </summary>
            public class RichTextItalic : RichText
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "richTextItalic";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Text
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public RichText Text { get; set; }
            }
        }
    }
}