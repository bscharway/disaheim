using System;
namespace Disaheim
{
	public abstract class Merchandise
	{
		// auto implementing the property  ItemId.
		public string ItemId { get; set; }

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

