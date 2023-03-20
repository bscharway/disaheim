using System;
namespace Disaheim
{
	public class Controller
	{
		// auto implementation of the properties (generic list)..
		public List<Book>Books { get; set; }
		public List<Amulet> Amulets { get; set; }


		// Making a constructor to initialize the controller class and constructor overloading
		public Controller(Book book, Amulet amulet)
		{
			List<Book> Books = new List<Book> { book }; //making a new instance of Book list and assignng it to this.Books
			this.Books = Books;
			List<Amulet> Amulets = new List<Amulet> {amulet}; //making a new instance of Amulet list and assignng it to this.Amulets
            this.Amulets = Amulets; 
		}
		public Controller()
		{
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }

		//implementing the to operations, as methods

		public void AddToList(Book book)
		{
            Books.Add(book);
        }

		public void AddToList(Amulet amulet)
		{
            Amulets.Add(amulet);
        }
	}
}

