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
        /// Returns saved animations
        /// </summary>
        public class GetSavedAnimations : Function<Animations>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getSavedAnimations";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
        }

        /// <summary>
        /// Returns saved animations
        /// </summary>
        public static Task<Animations> GetSavedAnimationsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetSavedAnimations
            {
            });
        }
    }
}