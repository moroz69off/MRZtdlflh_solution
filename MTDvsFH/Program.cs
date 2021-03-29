using System;
using System.Threading.Tasks;
using TdLib;
using TdAPI = TdLib.TdApi;
using JsonSerial = Newtonsoft.Json.Serialization;
using System.Text;
using System.IO;

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

            #region debugmode
            string[] appStrings = File.ReadAllLines(@"C:\Users\moroz69off\Desktop\rattlesnakeBOT.txt")[12].Split(new char[] { ':' });
            string dtPath = @"C:\Users\moroz69off\Desktop\";
            string logName = "tdlog" + DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".txt";
            string logPath = dtPath + logName;
            #endregion debugmode

            parameters = new TdAPI.TdlibParameters()
            {
                ApiId = int.Parse(appStrings[0]),
                UseChatInfoDatabase=true,
                UseMessageDatabase=true,
                ApiHash = appStrings[1],
                ApplicationVersion = "1.0",
                SystemLanguageCode = "ru-RU",
                DeviceModel = "desktop",
                SystemVersion = "Windows 10 Pro",
                UseFileDatabase = true,
                UseTestDc = true
            };
            Console.WriteLine("appId: " + appStrings[0] + '\n' + "api hash: " + appStrings[1] + '\n');
            client = new TdLib.TdClient();
            client.SetTdlibParametersAsync(parameters);
            var clientAuthState = client.GetAuthorizationStateAsync();
            Console.WriteLine(clientAuthState.Result);

            client.CloseAsync();
        }
    }
}
