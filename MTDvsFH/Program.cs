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
        static TdAPI.Ok OK = null;
        private static TdAPI.Client client = null;
        static TdAPI.InlineQueryResult getInlineResult = null;
        private static TdAPI.TdlibParameters parameters = null;

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
            encryptionKey = Encoding.ASCII.GetBytes(publicKey);
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

            client.CloseAsync();
        }

        private static string publicKey = Resources.mrzRes.publicKey;
    }
}
