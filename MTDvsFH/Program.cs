using System;
using System.Threading.Tasks;
using TdLib;
using TdAPI = TdLib.TdApi;
using JsonSerial = Newtonsoft.Json.Serialization;
using System.Text;
using System.IO;
using System.Collections.Generic;

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

            client = new TdClient();
            
            client.SetTdlibParametersAsync(parameters);

            encryptionKey = Encoding.ASCII.GetBytes(publicKey);
            var checkEncription = client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            
            var clientSetLogVerbosityLevel = client.Execute(new TdAPI.SetLogVerbosityLevel());
            if (!(client.Execute(new TdAPI.SetLogVerbosityLevel()) is TdApi.Ok)) throw new IOException("Write access to the current directory is required");
            
            
            var clientAuthState = client.GetAuthorizationStateAsync();
            Console.WriteLine("client Auth State ====== " + clientAuthState);
            var me = client.GetMeAsync();

            var appChat = client.GetChatAsync(appId);
            var ME = client.GetMeAsync();
            var status = ME.Status;
            Console.WriteLine(status);
            client.CloseAsync();
        }

        private static string publicKey = mrzRes.publicKey;
    }
}
