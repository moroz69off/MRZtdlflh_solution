using System;
using System.Threading.Tasks;
using TdLib;
using TdA = TdLib.TdApi;

namespace MTDvsFH
{
    class Program
    {
        private static string phoneNumber;
        static TdA.Ok Tok;
        private static TdA.Client client;
        static TdA.InlineQueryResult GetInlineQueryResult = null;
        private static TdA.TdlibParameters parameters;

        static void Main(string[] args)
        {
            Console.Title = "moroz69off tg-client";

            Console.WriteLine("Type the you phone number");
            //phoneNumber = Console.ReadLine();

            parameters = new TdA.TdlibParameters()
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

            Task<TdA.Chat> mChat = client.GetChatAsync(464756882);
            mChat.ConfigureAwait(false);

            TaskStatus authorizationStateStatus = client.GetAuthorizationStateAsync().Status;



            Console.WriteLine("===authorization state status===:\n" + authorizationStateStatus + "\n===ЖЖЖЖЖЖЖЖЖЖЖЖЖЖ===\n");
            Console.ReadLine();
        }
    }
}
