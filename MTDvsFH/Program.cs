using System;
using System.Threading.Tasks;
using TdLib;
using TdAPI = TdLib.TdApi;
using JsonSerial = Newtonsoft.Json.Serialization;
using System.Text;

namespace MTDvsFH
{
    class Program
    {
        private static byte[] encryptionKey = null;
        private static string phoneNumber = null;
        static TdAPI.Ok Tok = null;
        private static TdAPI.Client client = null;
        static TdAPI.InlineQueryResult GetInlineQueryResult = null;
        private static TdAPI.TdlibParameters parameters;

        static void Main(string[] args)
        {
            Console.Title = "moroz69off tg-client";
            //encryptionKey = Encoding.UTF8.GetBytes("MIIBCgKCAQEAwVACPi9w23mF3tBkdZz+zwrzKOaaQdr01vAbU4E1pvkfj4sqDsm6");
            //Console.WriteLine("Type the you phone number");
            //phoneNumber = Console.ReadLine();

            parameters = new TdAPI.TdlibParameters()
            {
                ApiId = int.Parse(mResource.apiId),
                UseChatInfoDatabase=true,
                UseMessageDatabase=true,
                ApiHash = mResource.apiHash,
                ApplicationVersion = "1.0",
                SystemLanguageCode = "ru-RU",
                DeviceModel = "desktop",
                SystemVersion = "Windows 10 Pro",
                UseFileDatabase = true,
                UseTestDc = true
            };

            client = new TdLib.TdClient();
            client.SetTdlibParametersAsync(parameters);
            //client.CheckDatabaseEncryptionKeyAsync(encryptionKey);

            //client = new TdClient();
            //client.SetTdlibParametersAsync(parameters);
            //client.CheckDatabaseEncryptionKeyAsync();

            //Task<TdAPI.Chat> mChat = client.GetChatAsync(464756882);

            client.CloseAsync();

            Console.ReadLine();
        }
    }
}
