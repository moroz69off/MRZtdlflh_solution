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
            TdAPI.Client result = new TdClient(bind);
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
           Console.WriteLine("\n______________\n"+"Type the you phone number: ");
            phoneNumber = Console.ReadLine();

            #region debugmode
            string appHash = Resources.mrzRes.appKey;
            int appId = int.Parse(Resources.mrzRes.appID);
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
            Console.WriteLine("\nAUTHORIZATION STATE (Task<TdAPI.AuthorizationState> state = client.GetAuthorizationStateAsync();) = " + state + "\n______________\n" + "\nAUTHORIZATION STATE (TdAPI.AuthorizationState)client.GetAuthorizationStateAsync().AsyncState;) = " + authorizationState + "\n______________\n");

            if (authorizationState is TdAPI.AuthorizationState.AuthorizationStateWaitEncryptionKey)
            {
                Console.WriteLine("\n***CHECK DATABASE ENCRYPTION KEY***" + "\n______________\n");
                client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            }

            Console.WriteLine("\nAUTHORIZATION STATE = " + state + "\n______________\n");

            if (authorizationState is TdAPI.AuthorizationState.AuthorizationStateWaitPassword)
            {
                Console.WriteLine("\n***CHECK AUTHENTICATION PASSWORD***" + "\n______________\n");
                client.CheckAuthenticationPasswordAsync();
            }

            Console.WriteLine("\nAUTHORIZATION STATE = " + state + "\n______________\n");

            Console.WriteLine("\nENCRYPTION KEY LENGTH (BYTES) = " + encryptionKey.Length + "\n______________\n");
            TdAPI.Ok clientSetLogVerbosityLevel = client.Execute(new TdAPI.SetLogVerbosityLevel());
            if (!(client.Execute(new TdAPI.SetLogVerbosityLevel()) is TdApi.Ok)) throw new IOException("\nWrite access to the current directory is required" + "\n______________\n");
            Console.WriteLine("\nCLIENT SET LOG VERBOSITY LEVEL = " + clientSetLogVerbosityLevel + "\n______________\n");


            Task<TdAPI.AuthorizationState> clientAuthState = client.GetAuthorizationStateAsync();
            Console.WriteLine("\nCLIENT AUTH STATE = " + clientAuthState + "\n______________\n");

            var passportElements = client.GetAllPassportElementsAsync();
            Console.WriteLine("\nPASSPORT ELEMENTS = " + passportElements + "\n______________\n");

            Task<TdAPI.Chat> mChat = client.GetChatAsync(464756882);
            appChatStatus = mChat.Status;
            Console.WriteLine("\nCHAT STATUS = " + appChatStatus + "\n______________\n");
            Task<TdAPI.User> ME = client.GetMeAsync();
            Console.WriteLine("\nME STATUS = " + ME.Status + "\n______________\n");

            Task<TdAPI.Sessions> activeSessions = client.GetActiveSessionsAsync();
            Console.WriteLine("\nACTIVE SESSION = " + activeSessions + "\n______________\n");

            var appConfig = client.GetApplicationConfigAsync();
            Console.WriteLine("\nIS COMPLETED ('TRUE' or 'FALSE')\nПолучает объект состояния, предоставленный при создании System.Threading.Tasks.Task,\nили null, если ничего не было предоставлено.\nIS COMPLETED===" + appConfig.IsCompleted + "\n______________\n");

            Console.WriteLine("\nAUTHORIZATION STATE = " + state + "\n______________\n");

            //ЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖ
            // AUTHORIZATION STATE = System.Threading.Tasks.Task`1[TdLib.TdApi+AuthorizationState]
            client.CloseAsync();
        }

        private static TaskStatus appChatStatus;
        private static string publicKey = Resources.mrzRes.publicKey;
        private static TdAPI.AuthorizationState authorizationState;
        private static ITdLibBindings bind;
    }
}
