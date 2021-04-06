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
        static TdAPI.InlineQueryResult GetInlResult = null;
        private static TdAPI.TdlibParameters parameters;

        private static TdApi.Client CreateTdClient()
        {
            TdAPI.Client result = new TdClient();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
             
            }).Start();
            return result;
        }
        static void Main(string[] args)
        {
            Console.Title = "moroz69off tg-client";

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

            client = CreateTdClient();
            
            client.SetTdlibParametersAsync(parameters);

            encryptionKey = Encoding.ASCII.GetBytes(publicKey);

            if (authorizationState is TdAPI.AuthorizationState.AuthorizationStateWaitEncryptionKey)
            {
                client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            }
            client.CheckDatabaseEncryptionKeyAsync(encryptionKey);

            TdAPI.Ok clientSetLogVerbosityLevel = client.Execute(new TdAPI.SetLogVerbosityLevel());
            if (!(client.Execute(new TdAPI.SetLogVerbosityLevel()) is TdApi.Ok)) throw new IOException("Write access to the current directory is required");
            Console.WriteLine("Client set log verbosity level ===== " + clientSetLogVerbosityLevel);


            Task<TdAPI.AuthorizationState> clientAuthState = client.GetAuthorizationStateAsync();
            Console.WriteLine("Client auth state ====== " + clientAuthState);
            Task<TdAPI.Chat> mChat = client.GetChatAsync(464756882);
            Task<TdAPI.User> ME = client.GetMeAsync();
            Console.WriteLine(ME.Status);
            client.CloseAsync();
        }

        private static string publicKey = mrzRes.publicKey;
        private static TdAPI.AuthorizationState authorizationState;
    }
}
