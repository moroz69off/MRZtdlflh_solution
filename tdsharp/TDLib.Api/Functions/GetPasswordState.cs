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
        /// Returns the current state of 2-step verification
        /// </summary>
        public class GetPasswordState : Function<PasswordState>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPasswordState";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
        }

        /// <summary>
        /// Returns the current state of 2-step verification
        /// </summary>
        public static Task<PasswordState> GetPasswordStateAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetPasswordState
            {
            });
        }
    }
}