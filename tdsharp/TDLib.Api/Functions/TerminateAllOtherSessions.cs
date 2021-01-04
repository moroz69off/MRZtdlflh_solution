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
        /// Terminates all other sessions of the current user
        /// </summary>
        public class TerminateAllOtherSessions : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "terminateAllOtherSessions";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
        }

        /// <summary>
        /// Terminates all other sessions of the current user
        /// </summary>
        public static Task<Ok> TerminateAllOtherSessionsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new TerminateAllOtherSessions
            {
            });
        }
    }
}