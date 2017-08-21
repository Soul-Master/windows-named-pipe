using System;
using System.IO;
using System.IO.Pipes;

namespace ConsoleApp3
{
    /*
     //./pipe/TestPipe
     */
    class Program
    {
        static void Main(string[] args)
        {
            var server = new NamedPipeServerStream("TestPipe");
            server.WaitForConnection();
            var reader = new StreamReader(server);
            var writer = new StreamWriter(server);

            while (true)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
