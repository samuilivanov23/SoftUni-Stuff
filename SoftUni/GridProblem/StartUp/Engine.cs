using System;
using System.Collections.Generic;
using System.Text;
using GRID.Drivers;
using GRID.Tyres;
using System.Linq;

namespace GRID
{
    public class Engine
    {
        private bool isRunning;
        private RaceTower raceTower;

        public Engine()
        {
            raceTower = new RaceTower();
        }

        public void Run()
        {
            this.isRunning = true;
            int lapsNumber = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            raceTower.SetTrackInfo(lapsNumber, trackLength);

            while (this.isRunning)
            {
                if (raceTower.CurrentLap >= raceTower.LapsNumber) this.isRunning = false;

                try
                {
                    string input = Console.ReadLine();
                    List<string> tokens = input.Split(" ").ToList();
                    string command = tokens[0];
                    List<string> commandArgs = tokens.Skip(1).ToList();
                    string output = "";

                    switch (command)
                    {
                        case "RegisterDriver":
                            raceTower.RegisterDriver(commandArgs);
                            break;
                        case "Leaderboard":
                            output = raceTower.GetLeaderboard();
                            break;
                        case "CompleteLaps":
                            output = raceTower.CompleteLaps(commandArgs);
                            break;
                        case "Box":
                            raceTower.DriverBoxes(commandArgs);
                            break;
                    }

                    Console.WriteLine(output);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private string ProcessCommand(string line)
        {
            throw new NotImplementedException();
        }
    }
}
