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
        /// Sends a simple network request to the Telegram servers; for testing only. Can be called before authorization
        /// </summary>
        public class TestNetwork : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testNetwork";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
        }

        /// <summary>
        /// Sends a simple network request to the Telegram servers; for testing only. Can be called before authorization
        /// </summary>
        public static Task<Ok> TestNetworkAsync(
            this Client client)
        {
            return client.ExecuteAsync(new TestNetwork
            {
            });
        }
    }
}