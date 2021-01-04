using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputMessageContent : Object
        {
            /// <summary>
            /// A video message
            /// </summary>
            public class InputMessageVideo : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Video to be sent
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video")]
                public InputFile Video { get; set; }

                /// <summary>
                /// Video thumbnail, if available
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail Thumbnail { get; set; }

                /// <summary>
                /// File identifiers of the stickers added to the video, if applicable
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("added_sticker_file_ids")]
                public int[] AddedStickerFileIds { get; set; }

                /// <summary>
                /// Duration of the video, in seconds
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int Duration { get; set; }

                /// <summary>
                /// Video width
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int Width { get; set; }

                /// <summary>
                /// Video height
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int Height { get; set; }

                /// <summary>
                /// True, if the video should be tried to be streamed
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("supports_streaming")]
                public bool SupportsStreaming { get; set; }

                /// <summary>
                /// Video caption; 0-GetOption("message_caption_length_max") characters
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }

                /// <summary>
                /// Video TTL (Time To Live), in seconds (0-60). A non-zero TTL can be specified only in private chats
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("ttl")]
                public int Ttl { get; set; }
            }
        }
    }
}