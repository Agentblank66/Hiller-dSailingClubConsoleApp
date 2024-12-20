﻿using System.Threading.Channels;


namespace HillerødSialingClub
{
	public class Boat
	{
		public int Id { get; set; }
		public double Size { get; set; }
		public string EngineInformation { get; set; }
		public int BuildYear { get; set; }
		public string Model { get; set; }
		public string BoatType { get; set; }
		public int SailingNumber { get; set; }
		public string BoatName { get; set; }

		List<string> MaintenanceLog = new List<string>();
		List<string> RepairsLog = new List<string>();

		// dette er Constroctoren
		public Boat(int id, double size, string motorInfo, int buildYear, string model, string type, int sailNr, string name)
		{
			Id = id;
			Size = size;
			EngineInformation = motorInfo;
			BuildYear = buildYear;
			Model = model;
			BoatType = type;
			SailingNumber = sailNr;
			BoatName = name;
		}

        // PrintMaintenanceLog() laver en joined string af listen som så retuneres
        public string PrintMaintenanceLog()
		{
            return string.Join(", ", MaintenanceLog);
        }

		// metode tilføjer en string til List
		public void AddToMaintenanceLog(string maintenanceString)
		{
            MaintenanceLog.Add(maintenanceString);
		}

        // PrintRepairsLog() laver en joined string af listen som så retuneres
        public string PrintRepairsLog()
		{
			return string.Join(", ", RepairsLog);
		}

		// metode tilføjer en string til List
		public void RequestRepairs(string RepairText)
		{
			RepairsLog.Add(RepairText);
        }

		// ToString() bliver overskrevet så vi bestemmer hvordan den skriver når kaldet
		public override string ToString()
		{
			return $" \n BoatName: {BoatName} \n Id:{Id} \n Size: {Size}m \n Model: {Model} \n Type: {BoatType} \n Engine: {EngineInformation} \n Sailnumber: {SailingNumber} \n Build in: {BuildYear} \n" + "-----------------------\n";
		}
	}
}

