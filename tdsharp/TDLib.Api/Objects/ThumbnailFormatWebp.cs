using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ThumbnailFormat : Object
        {
            /// <summary>
            /// The thumbnail is in WEBP format. It will be used only for some stickers
            /// </summary>
            public class ThumbnailFormatWebp : ThumbnailFormat
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "thumbnailFormatWebp";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}