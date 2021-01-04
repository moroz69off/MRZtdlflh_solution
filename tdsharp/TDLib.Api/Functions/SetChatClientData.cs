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
        /// Changes application-specific data associated with a chat
        /// </summary>
        public class SetChatClientData : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setChatClientData";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// New value of client_data
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("client_data")]
            public string ClientData { get; set; }
        }

        /// <summary>
        /// Changes application-specific data associated with a chat
        /// </summary>
        public static Task<Ok> SetChatClientDataAsync(
            this Client client, long chatId = default, string clientData = default)
        {
            return client.ExecuteAsync(new SetChatClientData
            {
                ChatId = chatId, ClientData = clientData
            });
        }
    }
}