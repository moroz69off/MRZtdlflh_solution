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
        /// Uses an invite link to add the current user to the chat if possible. The new member will not be added until the chat state has been synchronized with the server
        /// </summary>
        public class JoinChatByInviteLink : Function<Chat>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "joinChatByInviteLink";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Invite link to import; should begin with "https://t.me/joinchat/", "https://telegram.me/joinchat/", or "https://telegram.dog/joinchat/"
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }
        }

        /// <summary>
        /// Uses an invite link to add the current user to the chat if possible. The new member will not be added until the chat state has been synchronized with the server
        /// </summary>
        public static Task<Chat> JoinChatByInviteLinkAsync(
            this Client client, string inviteLink = default)
        {
            return client.ExecuteAsync(new JoinChatByInviteLink
            {
                InviteLink = inviteLink
            });
        }
    }
}