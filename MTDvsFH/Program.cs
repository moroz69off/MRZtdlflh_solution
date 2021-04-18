using System;
using System.Threading.Tasks;
using TdLib;
using TDLib.Bindings;
using TdAPI = TdLib.TdApi;
using JsonSerial = Newtonsoft.Json.Serialization;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MTDvsFH
{
    class Program
    {
        private static TdAPI.Ok OK = null;
        private static TdAPI.InlineQueryResult result = null;
        private static TdAPI.TdlibParameters parameters = null;
        private static TdAPI.Update.UpdateAuthorizationState updateAuthState = null;
        private static ManualResetEventSlim resetEvent = new ManualResetEventSlim();
        private static bool authNeeded = false;
        private static TdClient client = null;

        public static TdAPI.TdlibParameters Parameters { get; private set; }

        static async Task Main(string[] args)
        {
            Console.Title = "moroz69off tg-client";

            client = new TdClient();

            TdAPI.SetLogVerbosityLevel level = new TdAPI.SetLogVerbosityLevel();
            //level.NewVerbosityLevel = 0;

            updateAuthState = new TdAPI.Update.UpdateAuthorizationState();

            #region debugmode
            // 464756882

            string phoneNumber = Resources.mrzRes.phoneNumber;
            string publicKey = Resources.mrzRes.publicKey;
            string appHash = Resources.mrzRes.appKey;
            int appId = int.Parse(Resources.mrzRes.appID);
            byte[] encryptionKey = Encoding.ASCII.GetBytes(publicKey);

            #endregion

            parameters = new TdAPI.TdlibParameters()
            {
                ApiId = appId,
                ApiHash = appHash,
                ApplicationVersion = "1.0",
                DeviceModel = "desktop",
                SystemLanguageCode = "ru-RU",
                SystemVersion = "Windows 10 Pro",
                UseChatInfoDatabase = true,
                UseMessageDatabase = true,
                UseFileDatabase = true,
                UseTestDc = true
            };

            client.SetTdlibParametersAsync(parameters);

            var encription = client.CheckDatabaseEncryptionKeyAsync(encryptionKey);

            var phone = client.SetAuthenticationPhoneNumberAsync(phoneNumber);

            client.UpdateReceived += async (sender, update) => {
                switch (update)
                {
                    case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitRegistration):
                        authNeeded = true;
                        resetEvent.Set();
                        break;
                    //case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitTdlibParameters):
                    //    Parameters = parameters;
                    //    client.SetTdlibParametersAsync(Parameters);
                    //    break;
                    //case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitEncryptionKey):
                    //    client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
                    //    break;
                    //case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitPhoneNumber):
                    //    authNeeded = true;
                    //    resetEvent.Set();
                    //    break;
                    case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitCode):
                        Console.Write("Insert the login code: ");
                        string code = Console.ReadLine();
                        await client.ExecuteAsync(new TdApi.CheckAuthenticationCode
                        {
                            Code = code
                        });
                        break;
                    case TdApi.Update.UpdateUser updateUser:
                        resetEvent.Set();
                        break;
                    case TdApi.Update.UpdateConnectionState updateConnectionState when updateConnectionState.State.GetType() == typeof(TdApi.ConnectionState.ConnectionStateReady):
                        break;

                    default:
                        ; // add a breakpoint here to see other events
                        break;
                }
            };

            resetEvent.Wait();

            if (authNeeded)
            {
                await client.ExecuteAsync(new TdApi.SetAuthenticationPhoneNumber
                {
                    PhoneNumber = phoneNumber
                });
                Console.Write("Insert the login code: ");
                string code = Console.ReadLine();
                client.CheckAuthenticationCodeAsync(code);
            }

            await foreach (TdApi.Chat chat in GetChannels())
            {
                Console.WriteLine(chat.Title);
            }

            Console.ReadLine();
            //client.CloseAsync();
        }

        public static async IAsyncEnumerable<TdApi.Chat> GetChannels(
            long offsetOrder = long.MaxValue,
            long offsetId = 0,
            int limit = 1000)
        {
            var chats = await client.ExecuteAsync(new TdApi.GetChats { 
                OffsetOrder = offsetOrder,
                Limit = limit,
                OffsetChatId = offsetId });
            foreach (long chatId in chats.ChatIds)
            {
                TdApi.Chat chat = await client.ExecuteAsync(new TdApi.GetChat { ChatId = chatId });
                if (
                    true
                    //chat.Type is TdApi.ChatType.ChatTypeSupergroup || 
                    //chat.Type is TdApi.ChatType.ChatTypeBasicGroup || 
                    //chat.Type is TdApi.ChatType.ChatTypePrivate
                    )
                {
                    yield return chat;
                }
            }
        }
    }
}
