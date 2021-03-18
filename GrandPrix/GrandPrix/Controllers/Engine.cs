

namespace GrandPrix.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class Engine
    {

        public static void Run()
        {
            var raceTower = new RaceTower();
            string result = string.Empty;

            string input;

            int totalLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());

            raceTower.SetTrackInfo(totalLaps, trackLength);

            while(!result.Contains("Final"))
            {
                input = Console.ReadLine();

                List<string> commandArgs = input.Split(' ').ToList();

                string command = commandArgs[0];
                commandArgs = commandArgs.Skip(1).ToList();

                switch(command)
                {

                    case "RegisterDriver":
                        {
                            raceTower.RegisterDriver(commandArgs);
                            break;
                        }
                    case "Leaderboard":
                        {
                            result = raceTower.GetLeaderboard();
                            break;
                        }
                    case "CompleteLaps":
                        {
                            result = raceTower.CompleteLaps(commandArgs);
                            break;
                        }
                    case "Box":
                        {
                            raceTower.DriverBoxes(commandArgs);
                            break;
                        }
                    case "ChangeWeather":
                        {
                            raceTower.ChangeWeather(commandArgs);
                            break;
                        }
                   

                }

                Console.WriteLine(result);

            }
        }

    }
}
