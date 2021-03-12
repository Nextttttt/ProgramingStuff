namespace Minedraft
{
    using System;
    using Harvesters;
    using System.Linq;
    using System.Collections.Generic;
    using static DraftManager;
    public class StartUp
    {
        static void Main()
        {
            bool close = true;
          
            while(close)
            {
                string input = Console.ReadLine();
                List<string> Cmd = input.Split(' ').ToList();
                switch(Cmd[0])
                {

                    case "RegisterHarvester":
                        {
                            RegisterHarvester(Cmd);
                            break;

                        }
                    case "RegisterProvider":
                        {

                            RegisterProvider(Cmd);
                            break;

                        }
                    case "Day":
                        {
                            Day();
                            break;

                        }
                    case "Mode":
                        {

                            Mode(Cmd);
                            break;

                        }
                    case "Check":
                        {

                            Check(Cmd);
                            break;

                        }
                    case "Shutdown":
                        {

                            Console.WriteLine(ShutDown());
                            close = false;
                            break;

                        }

                }

            }

        }
    }
}
