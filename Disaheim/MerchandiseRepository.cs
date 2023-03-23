using System;
namespace Disaheim
{
	public class MerchandiseRepository
	{
		private List<Merchandise> merchandises;


		public MerchandiseRepository()
		{
			merchandises = new List<Merchandise>();
		}
        public void AddMerchandise(Merchandise merchandise)
		{
			merchandises.Add(merchandise);

		}

		public Merchandise GetMerchandise(string itemId)
		{
			Merchandise toReturnMerchandise = merchandises.Find(id => id.ItemId == itemId);
			return toReturnMerchandise;
		}

		public double GetTotalvalue()
		{
			double total = 0;
			Utility utility = new Utility();

			foreach (Merchandise merchandise in merchandises)
			{
				if (merchandise is Book)
				{
					

					total += utility.GetValueOfMerchandise(merchandise);
					
				}

				else if (merchandise is Amulet)
				{

					total += utility.GetValueOfMerchandise(merchandise);
				}
				
			}

			return total;
		}
	}
}

