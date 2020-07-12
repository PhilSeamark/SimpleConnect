using System;
using Microsoft.AnalysisServices.Tabular;

namespace SimpleConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            server.Connect("powerbi://api.powerbi.com/v1.0/myorg/PBICAT AAS Migration Test");
            Database database = server.Databases[0];
            Model model = database.Model;


            Console.WriteLine("Hello World!");
        }
    }
}
