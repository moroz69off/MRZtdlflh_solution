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
        /// Converts a JSON-serialized string to corresponding JsonValue object. Can be called synchronously
        /// </summary>
        public class GetJsonValue : Function<JsonValue>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getJsonValue";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The JSON-serialized string
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("json")]
            public string Json { get; set; }
        }

        /// <summary>
        /// Converts a JSON-serialized string to corresponding JsonValue object. Can be called synchronously
        /// </summary>
        public static Task<JsonValue> GetJsonValueAsync(
            this Client client, string json = default)
        {
            return client.ExecuteAsync(new GetJsonValue
            {
                Json = json
            });
        }
    }
}