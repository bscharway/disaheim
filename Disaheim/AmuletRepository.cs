using System;
namespace Disaheim
{
	public class AmuletRepository
	{
        private List<Amulet> amulets;

        // making a constructor to initialize 
        public AmuletRepository()
        {
            amulets = new List<Amulet>();
        }

        // Making of the method AddAmulet
        public void AddAmulet(Amulet amulet)
        {
            this.amulets.Add(amulet);

        }

        // Making of the method GetAmulet
        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet = amulets.Find(inAmulet => inAmulet.ItemId == itemId);
            return amulet;
        }

        // Making of the method GetTotalValue
        public double GetTotalValue()
        {
            Utility utility = new Utility();

            double totalValue = 0.00;

            foreach (Amulet amulet in amulets)
            {
                totalValue += utility.GetValueOfMerchandise(amulet);// passing in amulet as a parameter so it's quality can be assesed 

            }
            return totalValue;
        }
    }
}


