using System;
using System.Threading.Tasks;
using TdLib;
using TdAPI = TdLib.TdApi;

namespace MTDvsFH
{
    class Program
    {
        private static string phoneNumber;
        static TdAPI.Ok Tok;
        private static TdAPI.Client client;
        static TdAPI.InlineQueryResult GetInlineQueryResult = null;
        private static TdAPI.TdlibParameters parameters;

        static void Main(string[] args)
        {
            Console.Title = "moroz69off tg-client";

            Console.WriteLine("Type the you phone number");
            //phoneNumber = Console.ReadLine();

            parameters = new TdAPI.TdlibParameters()
            {
                ApiId = int.Parse(mResource.apiId),
                ApiHash = mResource.apiHash,
                ApplicationVersion = "1.0",
                SystemLanguageCode = "ru-RU",
                DeviceModel = "desktop",
                SystemVersion = "Windows 10 Pro",
                UseFileDatabase = true,
                UseTestDc = true
            };

            client = new TdClient();
            client.SetTdlibParametersAsync(parameters);
            client.CheckDatabaseEncryptionKeyAsync();

            Task<TdAPI.Chat> mChat = client.GetChatAsync(464756882);

            Console.ReadLine();
        }
    }
}
