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
        /// Returns the received vector of strings; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public class TestCallVectorString : Function<TestVectorString>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testCallVectorString";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Vector of strings to return
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("x")]
            public string[] X { get; set; }
        }

        /// <summary>
        /// Returns the received vector of strings; for testing only. This is an offline method. Can be called before authorization
        /// </summary>
        public static Task<TestVectorString> TestCallVectorStringAsync(
            this Client client, string[] x = default)
        {
            return client.ExecuteAsync(new TestCallVectorString
            {
                X = x
            });
        }
    }
}