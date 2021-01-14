using System;

using TDLib;
using TDLib.Bindings;

using TdLib;
using TdLib.Bindings;
using System.Threading.Tasks;
using static TdLib.TdApi;

namespace MRZtdlflh_pro
{
    class Program
    {
        private static string phoneNumber;

        static void Main(string[] args)
        {
            try
            {
                SetTdlibParameters setTdlibParameters = new SetTdlibParameters();
                //setTdlibParameters.Parameters.UseTestDc = true;
                Task<TdClient> v = TaskAsync();
                //v.ConfigureAwait(true);
                var result = v.Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static async Task<TdClient> TaskAsync()
        {
            TdClient tdClient = new TdClient();
            AccountTtl accountTtl = new AccountTtl();
            
            await tdClient.CheckChatUsernameAsync();
            var GetMeClient = await TdApi.GetMeAsync(tdClient);
            return tdClient;
        }
    }
}
