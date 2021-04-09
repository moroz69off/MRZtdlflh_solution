using System;
using System.Threading.Tasks;
using TdLib;
using TdAPI = TdLib.TdApi;
using JsonSerial = Newtonsoft.Json.Serialization;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace MTDvsFH
{
    class Program
    {
        private static byte[] encryptionKey = null;
        private static string phoneNumber = null;
        static TdAPI.Ok Tok = null;
        private static TdAPI.Client client = null;
        static TdAPI.InlineQueryResult getInlineResult = null;
        private static TdAPI.TdlibParameters parameters;
        
        private static TdApi.Client CreateTdClient()
        {
            TdAPI.Client result = new TdClient();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = false;
            }).Start();
            Console.WriteLine("TEST NETWORK ASYNC = " + result.TestNetworkAsync());
            return result;
        }
        static void Main(string[] args)
        {
            Console.Title = "moroz69off tg-client";
            TdAPI.Update.UpdateAuthorizationState UpdateAuthState = new TdAPI.Update.UpdateAuthorizationState();
            //Console.WriteLine("Type the you phone number");
            //phoneNumber = Console.ReadLine();

            #region debugmode
            string appHash = mrzRes.appKey;
            int appId = int.Parse(mrzRes.appID);
            #endregion

            parameters = new TdAPI.TdlibParameters()
            {
                ApiId = appId,
                UseChatInfoDatabase=true,
                UseMessageDatabase=true,
                ApiHash = appHash,
                ApplicationVersion = "1.0",
                SystemLanguageCode = "ru-RU",
                DeviceModel = "desktop",
                SystemVersion = "Windows 10 Pro",
                UseFileDatabase = true,
                UseTestDc = true
            };
            encryptionKey = Encoding.ASCII.GetBytes(publicKey);

            client = CreateTdClient();

            client.SetTdlibParametersAsync(parameters);

            authorizationState = (TdAPI.AuthorizationState)client.GetAuthorizationStateAsync().AsyncState;

            //var state = UpdateAuthState.AuthorizationState;
            Task<TdAPI.AuthorizationState> state = client.GetAuthorizationStateAsync();
            Console.WriteLine("AUTHORIZATION STATE = " + state);

            if (state is TdAPI.AuthorizationState.AuthorizationStateWaitEncryptionKey)
            {
                client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
                Console.WriteLine("***CHECK DATABASE ENCRYPTION KEY***");
            }
            if (state is TdAPI.AuthorizationState.AuthorizationStateWaitPassword)
            {
                client.CheckAuthenticationPasswordAsync();
                Console.WriteLine("***CHECK AUTHENTICATION PASSWORD***");
            }
            Console.WriteLine("ENCRYPTION KEY LENGTH (BYTES) = " + encryptionKey.Length);
            TdAPI.Ok clientSetLogVerbosityLevel = client.Execute(new TdAPI.SetLogVerbosityLevel());
            if (!(client.Execute(new TdAPI.SetLogVerbosityLevel()) is TdApi.Ok)) throw new IOException("Write access to the current directory is required");
            Console.WriteLine("CLIENT SET LOG VERBOSITY LEVEL = " + clientSetLogVerbosityLevel);


            Task<TdAPI.AuthorizationState> clientAuthState = client.GetAuthorizationStateAsync();
            Console.WriteLine("CLIENT AUTH STATE = " + clientAuthState);

            var passportElements = client.GetAllPassportElementsAsync();
            Console.WriteLine("PASSPORT ELEMENTS = " + passportElements);

            Task<TdAPI.Chat> mChat = client.GetChatAsync(464756882);
            appChatStatus = mChat.Status;
            Console.WriteLine("CHAT STATUS = " + appChatStatus);
            Task<TdAPI.User> ME = client.GetMeAsync();
            Console.WriteLine("ME STATUS = " + ME.Status);

            Task<TdAPI.Sessions> activeSessions = client.GetActiveSessionsAsync();
            Console.WriteLine("ACTIVE SESSION = " + activeSessions);

            

            client.CloseAsync();
        }

        private static TaskStatus appChatStatus;
        private static string publicKey = mrzRes.publicKey;
        private static TdAPI.AuthorizationState authorizationState;
    }
}
