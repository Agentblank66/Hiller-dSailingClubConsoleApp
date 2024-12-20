using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
	public class BoatRepo
	{
		public Dictionary<int, Boat> Boats = new Dictionary<int, Boat>();
		public Dictionary<int, Boat> RepairBoats = new Dictionary<int, Boat>();

		// Metoden Add prøver at tilføje object referrence til dictionary 
		public bool Add(Boat boat)
		{
			return Boats.TryAdd(boat.Id, boat);
        }

		// Metoden Update opdaterer informationer for en båd i et Dictionary kaldet Boats.
		// Den tager flere argumenter når kaldet, som bruges til at opdatere de relevante egenskaber for båden.
		public Boat? Update(int Id, string boattype, string model, string boatname, int sailnr, string engineinfo, double size, int buildyear)
		{
			// hent båden med det givne id
			Boat? boatToUpdate = GetBoat(Id);

			// hvis båden findes, opdatere dens egenskaber.
			if (boatToUpdate != null)
			{
                boatToUpdate.BoatType = boattype;
                boatToUpdate.Model = model;
                boatToUpdate.BoatName = boatname;
                boatToUpdate.SailingNumber = sailnr;
                boatToUpdate.EngineInformation = engineinfo;
                boatToUpdate.Size = size;
                boatToUpdate.BuildYear = buildyear;
			}

			return boatToUpdate;
		}

		// retunere Boat som type når kaldet 
		public Boat? GetBoat(int id)
		{
			if (Boats.ContainsKey(id))
			{
				return Boats[id]; // retunere båden vis den findes i dictionary
			}
			return null; // Hvis båden ikke findes, returner null
        }

		// boat med det angivede id fjernes fra dictionary når kaldet
		public bool DeleteBoat(int id)
		{
			return Boats.Remove(id);
		}
		
		// metoden udskriver alle objecter i consolen og retunere en string
		public string PrintAllBoat()
		{
			return string.Join(",", Boats);
		}

		public bool SendBoatToRepair(Boat boat, string message)
		{
			if (RepairBoats.TryAdd(boat.Id, boat))
			{
                boat.RequestRepairs(message);
                return Boats.Remove(boat.Id);
			}
			return false;
        }

		public bool GetBoatFromRepair(Boat boat)
		{
			if (Boats.TryAdd(boat.Id, boat)) 
			{ 
				return RepairBoats.Remove(boat.Id);
			}
			return false;
        }

		public string PrintAllRepairBoats()
		{
			return string.Join(", \n ", RepairBoats);

        }
    }
}