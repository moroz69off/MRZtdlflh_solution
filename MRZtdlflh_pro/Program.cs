using System;
using TdLib;
using TdLib.Bindings;
using System.Threading.Tasks;


namespace MRZtdlflh_pro
{
    class Program
    {
        private static string phoneNumber;
        
        static void Main(string[] args)
        {
            try
            {
                TdClient MTDClient = new TdLib.TdClient();
                Task<TdApi.AuthorizationState> autorisationState = MTDClient.GetAuthorizationStateAsync();
                Console.WriteLine("autorisation state: "+autorisationState);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
