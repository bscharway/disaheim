using System;
namespace Disaheim
{
    public class Amulet: Merchandise
    {
        // Auto implementation of properties
        public string Design { get; set; }
        public Level Quality { get; set; }

        // Constuctor overloading with 3, 2 and 1 arguments
        public Amulet(string ItemId, Level Quality, string Design) 
        {
            this.ItemId = ItemId;
            this.Quality = Quality;
            this.Design = Design;
        }
        public Amulet(string ItemId, Level Quality) 
        {
            this.ItemId = ItemId;
            this.Quality = Quality;
            Design = "";
        }
        public Amulet(string ItemId) 
        {
            this.ItemId = ItemId;
            Quality = Level.medium;
            Design = "";
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}


