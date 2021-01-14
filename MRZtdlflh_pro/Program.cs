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
                Task<TdClient> v = TaskAsync();
                v.Dispose();
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
            var GetMeClient = await TdApi.GetMeAsync(tdClient);
            return tdClient;
        }
    }
}
