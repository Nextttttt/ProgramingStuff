namespace GrandPrix.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Models.Drivers;

    class RaceTower
    {
        List<Driver> drivers = new List<Driver>();

        void SetTrackInfo(int lapsNumber, int trackLength)
        {
            

        }
        void RegisterDriver(List<string> commandArgs)
        {
            //TODO: Add some logic here …
            string type = commandArgs[0];

            switch(type)
            {
                case "Agressive":
                    {
                        drivers.Add()
                        break;
                    }
            }
        }

        void DriverBoxes(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        string CompleteLaps(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        string GetLeaderboard()
        {
            //TODO: Add some logic here …
        }

        void ChangeWeather(List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

    }
}
