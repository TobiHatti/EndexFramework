﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleStartupAssist
{
    class Startup
    {
        static void Main(string[] args)
        {
            var clientPath = @"..\..\..\SampleAppClient\bin\Debug\SampleAppClient.exe";
            var serverPath = @"..\..\..\SampleAppServer\bin\Debug\SampleAppServer.exe";

            Console.WriteLine("Amount of clients: ");
            var clientCount = Convert.ToInt32(Console.ReadLine());

            Process.Start(serverPath);

            Thread.Sleep(2000);

            for (int i = 0; i < clientCount; i++)
            {
                Process.Start(clientPath, $"{i + 1}");
                Thread.Sleep(1000);
            }
                

            

            Environment.Exit(0);
        }
    }
}
