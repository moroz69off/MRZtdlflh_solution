using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Represents a closed vector path. The path begins at the end point of the last command
        /// </summary>
        public partial class ClosedVectorPath : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "closedVectorPath";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of vector path commands
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("commands")]
            public VectorPathCommand[] Commands { get; set; }
        }
    }
}