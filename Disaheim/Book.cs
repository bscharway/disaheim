using System;
namespace Disaheim
{
    public class Book
    {
        //Auto implementation of properties.
        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        // Constuctor overloading with different parameters.
        public Book(string ItemId, string Title = "", double Price = 00.00)
        {
            this.ItemId = ItemId;
            this.Title = Title;
            this.Price = Price;
        }
        /*public Book(string ItemId, string Title)
        {
            this.ItemId = ItemId;
            this.Title = Title;
            this.Price = 00.00;
        }
        public Book(string ItemId)
        {
            this.ItemId = ItemId;
            this.Title = "";
            this.Price = 00.00;
        }*/
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
