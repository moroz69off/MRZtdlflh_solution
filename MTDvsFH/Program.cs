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

            //Console.WriteLine("Type the you phone number");
            //phoneNumber = Console.ReadLine();

            parameters = new TdAPI.TdlibParameters()
            {
                ApiId = int.Parse(""),
                UseChatInfoDatabase=true,
                UseMessageDatabase=true,
                ApiHash = "",
                ApplicationVersion = "1.0",
                SystemLanguageCode = "ru-RU",
                DeviceModel = "desktop",
                SystemVersion = "Windows 10 Pro",
                UseFileDatabase = true,
                UseTestDc = true
            };
            
            client = new TdLib.TdClient();
            client.SetTdlibParametersAsync(parameters);
            client.GetAuthorizationStateAsync();
            Task<TdAPI.Ok> encription = client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            client.SendMessageAsync(464756882, 464756882, null, null, new TdAPI.InputMessageContent());
            client.CloseAsync();

            Console.ReadLine();
        }
    }
}
