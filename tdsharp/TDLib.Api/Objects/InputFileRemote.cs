using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputFile : Object
        {
            /// <summary>
            /// A file defined by its remote ID. The remote ID is guaranteed to be usable only if the corresponding file is still accessible to the user and known to TDLib.
            /// </summary>
            public class InputFileRemote : InputFile
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputFileRemote";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Remote file identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }
            }
        }
    }
}