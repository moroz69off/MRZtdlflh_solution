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
            //encryptionKey = Encoding.UTF8.GetBytes("MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAruw2yP/BCcsJliRoW5eBVBVle9dtjJw+OYED160Wybum9SXtBBLXriwt4rROd9csv0t0OHCaTmRqBcQ0J8fxhN6/cpR1GWgOZRUAiQxoMnlt0R93LCX/j1dnVa/gVbCjdSxpbrfY2g2L4frzjJvdl84Kd9ORYjDEAyFnEA7dD556OptgLQQ2e2iVNq8NZLYTzLp5YpOdO1doK+ttrltggTCy5SrKeLoCPPbOgGsdxJxyz5KKcZnSLj16yE5HvJQn0CNpRdENvRUXe6tBP78O39oJ8BTHp9oIjd6XWXAsp2CvK45Ol8wFXGF710w9lwCGNbmNxNYhtIkdqfsEcwR5JwIDAQAB");
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
            client.GetAuthorizationStateAsync();
            Task<TdAPI.Ok> encription = client.CheckDatabaseEncryptionKeyAsync(encryptionKey);
            client.SendMessageAsync(464756882, 464756882, null, null, new TdAPI.InputMessageContent());
            client.CloseAsync();

            Console.ReadLine();
        }
    }
}
