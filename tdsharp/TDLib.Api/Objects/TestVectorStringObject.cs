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
        /// A simple object containing a vector of objects that hold a string; for testing only
        /// </summary>
        public partial class TestVectorStringObject : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testVectorStringObject";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Vector of objects
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("value")]
            public TestString[] Value { get; set; }
        }
    }
}