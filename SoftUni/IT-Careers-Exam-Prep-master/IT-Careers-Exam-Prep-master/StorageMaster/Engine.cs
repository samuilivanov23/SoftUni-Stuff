using System;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    public class Engine
    {
        private bool isRunning;
        private StorageMaster storageMaster;

        public Engine()
        {
            this.storageMaster = new StorageMaster();
        }

        public void Run()
        {
            this.isRunning = true;
            StringBuilder sb = new StringBuilder();

            while (this.isRunning)
            {
                string output;
                try
                {
                    string line = Console.ReadLine();
                    output = ProcessCommand(line);
                }
                catch (InvalidOperationException e)
                {
                    output = $"Error: {e.Message}";
                }

                sb.AppendLine(output);
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private string ProcessCommand(string line)
        {
            string[] tokens = line.Split();

            string command = tokens[0];

            string output = string.Empty;
            string storageName;
            int garageSlot;
            switch (command)
            {
                case "AddProduct":
                    string productType = tokens[1];
                    double productPrice = double.Parse(tokens[2]);
                    output = this.storageMaster.AddProduct(productType, productPrice);
                    break;
                case "RegisterStorage":
                    string storageType = tokens[1];
                    storageName = tokens[2];
                    output = this.storageMaster.RegisterStorage(storageType, storageName);
                    break;
                case "SelectVehicle":
                    storageName = tokens[1];
                    garageSlot = int.Parse(tokens[2]);
                    output = this.storageMaster.SelectVehicle(storageName, garageSlot);
                    break;
                case "LoadVehicle":
                    string[] names = tokens.Skip(1).ToArray();
                    output = this.storageMaster.LoadVehicle(names);
                    break;
                case "SendVehicleTo":
                    string sourceName = tokens[1];
                    int sourceGarageSlot = int.Parse(tokens[2]);
                    string destinationName = tokens[3];
                    output = this.storageMaster.SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                    break;
                case "UnloadVehicle":
                    storageName = tokens[1];
                    garageSlot = int.Parse(tokens[2]);
                    output = this.storageMaster.UnloadVehicle(storageName, garageSlot);
                    break;
                case "GetStorageStatus":
                    storageName = tokens[1];
                    output = this.storageMaster.GetStorageStatus(storageName);
                    break;
                case "END":
                    this.isRunning = false;
                    output = this.storageMaster.GetSummary();
                    break;
            }

            return output;
        }
    }
}