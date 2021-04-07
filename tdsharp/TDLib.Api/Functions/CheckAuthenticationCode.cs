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
        /// Checks the authentication code. Works only when the current authorization state is authorizationStateWaitCode
        /// </summary>
        public class CheckAuthenticationCode : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "checkAuthenticationCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The verification code received via SMS, Telegram message, phone call, or flash call
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("code")]
            public string Code { get; set; }
        }

        /// <summary>
        /// Checks the authentication code. Works only when the current authorization state is authorizationStateWaitCode
        /// </summary>
        public static Task<Ok> CheckAuthenticationCodeAsync(
            this Client client, string code = default)
        {
            return client.ExecuteAsync(new CheckAuthenticationCode
            {
                Code = code
            });
        }
    }
}