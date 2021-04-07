using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputInlineQueryResult : Object
        {
            /// <summary>
            /// Represents a link to a file
            /// </summary>
            public class InputInlineQueryResultDocument : InputInlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultDocument";

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
                /// Title of the resulting file
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string Description { get; set; }

                /// <summary>
                /// URL of the file
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("document_url")]
                public string DocumentUrl { get; set; }

                /// <summary>
                /// MIME type of the file content; only "application/pdf" and "application/zip" are currently allowed
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string MimeType { get; set; }

                /// <summary>
                /// The URL of the file thumbnail, if it exists
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// Width of the thumbnail
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_width")]
                public int ThumbnailWidth { get; set; }

                /// <summary>
                /// Height of the thumbnail
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_height")]
                public int ThumbnailHeight { get; set; }

                /// <summary>
                /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }

                /// <summary>
                /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageDocument, InputMessageLocation, InputMessageVenue or InputMessageContact
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent InputMessageContent { get; set; }
            }
        }
    }
}