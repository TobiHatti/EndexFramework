﻿using EndevFWNwtCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetComServerInstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            // === SETTING UP THE SERVER ===

            // Define the tcp-port on which the communication should take place
            int tcpServerPort = 2225;

            // Create a instance of the server
            NetComServer server = new NetComServer(tcpServerPort);

            // Set the wanted Debug-Output
            server.SetDebugOutput(DebugOutput.ToConsole);

            // Set the authentication-method.
            // Authentication-Methods can be customly created, as long as 
            // they accept a username [string] and a password [string] and 
            // return true or false wether the authentication / login was successfull or not
            server.SetAuthenticationTool(AuthenticationTools.DebugAuth);

            // Start the server and all its background-processes.
            server.Start();


            // === COMMUNICATE WITH CLIENTS ===

            // Create the instruction you want to send. General purpose-instructions are defined in the 
            // InstructionLibraryEssentials-class. Additional Instructions are defined in the 
            // InstructionLibraryExtensions-class. Custom instructions can be created as shown in the 
            // "CustomInstructions"-Project

            // 1) Send a message to a single connected client

            int connectedClientIndex = 0;
            InstructionBase instruction1 = new InstructionLibraryEssentials.SimpleMessageBox
                (server, server.ConnectedClients[connectedClientIndex], "Hello world.");


            //server.Send(instruction1);
        }
    }
}
