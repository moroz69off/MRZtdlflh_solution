using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Stops the uploading of a file. Supported only for files uploaded by using uploadFile. For other files the behavior is undefined
        /// </summary>
        public class CancelUploadFile : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "cancelUploadFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the file to stop uploading
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }
        }

        /// <summary>
        /// Stops the uploading of a file. Supported only for files uploaded by using uploadFile. For other files the behavior is undefined
        /// </summary>
        public static Task<Ok> CancelUploadFileAsync(
            this Client client, int fileId = default)
        {
            return client.ExecuteAsync(new CancelUploadFile
            {
                FileId = fileId
            });
        }
    }
}