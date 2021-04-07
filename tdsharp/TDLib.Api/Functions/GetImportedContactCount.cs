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
        /// Returns the total number of imported contacts
        /// </summary>
        public class GetImportedContactCount : Function<Count>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getImportedContactCount";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
        }

        /// <summary>
        /// Returns the total number of imported contacts
        /// </summary>
        public static Task<Count> GetImportedContactCountAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetImportedContactCount
            {
            });
        }
    }
}