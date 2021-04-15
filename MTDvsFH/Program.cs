using System;
using System.Threading.Tasks;
using TdLib;
using TdAPI = TdLib.TdApi;
using JsonSerial = Newtonsoft.Json.Serialization;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using TDLib.Bindings;
// 464756882
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
            //bind = null;
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

            //Console.WriteLine("\n______________\n"+"Type the you phone number: ");
            //phoneNumber = Console.ReadLine();

            #region debugmode
            string appHash = Resources.mrzRes.appKey;
            int appId = int.Parse(Resources.mrzRes.appID);
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
                UseMessageDatabase=true,
                UseFileDatabase = true,
                UseTestDc = true
            };
            encryptionKey = Encoding.ASCII.GetBytes(publicKey);

            client = CreateTdClient();

            client.SetTdlibParametersAsync(parameters);
            client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            authorizationState = (TdAPI.AuthorizationState)client.GetAuthorizationStateAsync().AsyncState;

            if (authorizationState is TdAPI.AuthorizationState.AuthorizationStateWaitEncryptionKey)
            {
                Console.WriteLine("\n***CHECK DATABASE ENCRYPTION KEY***" + "\n______________\n");
                client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            }

            if (authorizationState is TdAPI.AuthorizationState.AuthorizationStateWaitPassword)
            {
                Console.WriteLine("\n***CHECK AUTHENTICATION PASSWORD***" + "\n______________\n");
                client.CheckAuthenticationPasswordAsync();
            }

            TdAPI.Ok clientSetLogVerbosityLevel = client.Execute(new TdAPI.SetLogVerbosityLevel());
            if (!(client.Execute(new TdAPI.SetLogVerbosityLevel()) is TdApi.Ok)) throw new IOException("\nWrite access to the current directory is required" + "\n______________\n");

            Task<TdAPI.AuthorizationState> clientAuthState = client.GetAuthorizationStateAsync();

            var passportElements = client.GetAllPassportElementsAsync();

            Task<TdAPI.Chat> mChat = client.GetChatAsync(464756882);
            appChatStatus = mChat.Status;
            Console.WriteLine("\nCHAT STATUS = " + appChatStatus + "\n______________\n");
            Task<TdAPI.User> ME = client.GetMeAsync();
            Console.WriteLine("\nME STATUS = " + ME.Status + "\n______________\n");

            Task<TdAPI.Sessions> activeSessions = client.GetActiveSessionsAsync();

            var appConfig = client.GetApplicationConfigAsync();

            //ЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖ

            //ЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖ

            client.CloseAsync();
        }

        private static TaskStatus appChatStatus;
        private static string publicKey = Resources.mrzRes.publicKey;
        private static TdAPI.AuthorizationState authorizationState;
        private static ITdLibBindings bind;
        //private static TaskScheduler scheduler;
    }
}
