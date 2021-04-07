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
        /// Hides a suggested action
        /// </summary>
        public class HideSuggestedAction : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "hideSuggestedAction";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Suggested action to hide
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("action")]
            public SuggestedAction Action { get; set; }
        }

        /// <summary>
        /// Hides a suggested action
        /// </summary>
        public static Task<Ok> HideSuggestedActionAsync(
            this Client client, SuggestedAction action = default)
        {
            return client.ExecuteAsync(new HideSuggestedAction
            {
                Action = action
            });
        }
    }
}