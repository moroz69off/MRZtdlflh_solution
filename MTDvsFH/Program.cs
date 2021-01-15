using System;
using TdLib;


namespace MTDvsFH
{
    class Program
    {
        static void Main(string[] args)
        {
            TdClient MtdClient = new TdClient();

            MtdClient.Dispose();
            Console.ReadLine();
        }
    }
}
