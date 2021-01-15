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
            Console.WriteLine("Type the you phone number");
            //phoneNumber = Console.ReadLine();

            parameters = new TdA.TdlibParameters()
            {
                ApiId = int.Parse(mResource.apiId),
                ApiHash = mResource.apiHash,
                ApplicationVersion = "1.0",
                SystemLanguageCode = "ru-RU",
                DeviceModel = "desktop",
                SystemVersion = "Windows 10 Pro"
            };

            client = new TdClient();
            client.SetTdlibParametersAsync(parameters);
            client.CheckDatabaseEncryptionKeyAsync();
            TaskStatus authorizationStateStatus = client.GetAuthorizationStateAsync().Status;
            Console.WriteLine("===authorization state status===:\n" + authorizationStateStatus + "\n===ЖЖЖЖЖЖЖЖЖЖЖЖЖЖ===\n");
            Console.ReadLine();
        }
    }
}
