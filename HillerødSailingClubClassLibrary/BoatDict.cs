using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
	public class BoatDict
	{
		private Dictionary<int, Boat> Boats = new Dictionary<int, Boat>();

		// Metoden Add prøver at tilføje object referrence til dictionary 
		public void Add(Boat boat)
		{
			Boats.TryAdd(boat.Id, boat);
		}

		// Metoden Update opdaterer informationer for en båd i et Dictionary kaldet Boats.
		// Den tager flere argumenter når kaldet, som bruges til at opdatere de relevante egenskaber for båden.
		public void Update(int Id, string boattype, string model, string boatname, int sailnr, string engineinfo, double size, int buildyear)
		{
			if (Boats.ContainsKey(Id))
			{
				Boats[Id].BoatType = boattype;
				Boats[Id].Model = model;
				Boats[Id].BoatName = boatname;
				Boats[Id].SailingNumber = sailnr;
				Boats[Id].EngineInformation = engineinfo;
				Boats[Id].Size = size;
				Boats[Id].BuildYear = buildyear;
			}
		}

		// retunere Boat som type når kaldet 
		public Boat? GetBoat(int id)
		{
			if (Boats.ContainsKey(id))
			{
				return Boats[id];
			}
			else
			{
				return null;
			}
		}

		// boat med det angivede id fjernes fra dictionary når kaldet
		public bool DeleteBoat(int id)
		{
			return Boats.Remove(id);
		}

		// metoden udskriver alle objecter i consolen og retunere dictionariet
		public string PrintAllBoat()
		{
			string BoatsString = string.Join(",", Boats);
			return BoatsString;
		}
	}
}
