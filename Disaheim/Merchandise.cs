using System;
namespace Disaheim
{
	public abstract class Merchandise : IValuable
	{

		// auto implementing the property  ItemId.
		public string ItemId { get; set; }

        

        //TODO Implmenting the interface (change the code below to proper code)
        public double GetValue()
        {
            double val = 0;

            return val;
        }

        //// making a condtructor to initialize the attribute 
        //public Merchandise(string itemId)
        //{
        //	this.ItemId = itemId;
        //}


        public override string ToString()
		{
			return $"ItemId: {ItemId}";
		}
        
            
        
    }
}

