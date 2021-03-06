﻿using System;
using System.ComponentModel.Design;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case "QUIT":
                        command = Commands.QUIT;
                        break;

                    case "LOOK":
                        command = Commands.LOOK;
                        break;

                    case "NORTH":
                        command = Commands.NORTH;
                        break;

                    case "SOUTH":
                        command = Commands.SOUTH;
                        break;

                    case "EAST":
                        command = Commands.EAST;
                        break;

                    case "WEST":
                        command = Commands.WEST;
                        break;

                    default:
                        command = Commands.UNKNOWN;
                        break;
                }

                Console.WriteLine(outputString);
            }
        }
        private static Commands ToCommand(string commandString)
        {

            return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        }
    }
}

