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
        /// Sets the result of a pre-checkout query; for bots only
        /// </summary>
        public class AnswerPreCheckoutQuery : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "answerPreCheckoutQuery";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the pre-checkout query
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("pre_checkout_query_id")]
            public long PreCheckoutQueryId { get; set; }

            /// <summary>
            /// An error message, empty on success
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("error_message")]
            public string ErrorMessage { get; set; }
        }

        /// <summary>
        /// Sets the result of a pre-checkout query; for bots only
        /// </summary>
        public static Task<Ok> AnswerPreCheckoutQueryAsync(
            this Client client, long preCheckoutQueryId = default, string errorMessage = default)
        {
            return client.ExecuteAsync(new AnswerPreCheckoutQuery
            {
                PreCheckoutQueryId = preCheckoutQueryId, ErrorMessage = errorMessage
            });
        }
    }
}