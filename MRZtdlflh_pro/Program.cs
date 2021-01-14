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
                TdClient MTDCli = new TdLib.TdClient();
                var MTDch = TdApi.SendBotStartMessageAsync(MTDCli);
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
