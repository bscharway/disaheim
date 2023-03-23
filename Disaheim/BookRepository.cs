using System;

namespace Disaheim

{
	public class BookRepository
	{
		private List<Book> books;

		// making a constructor to initialize 
		public BookRepository()
		{
			books = new List<Book>();
		}

		public void AddBook(Book book)
		{
			this.books.Add(book);

		}

		public Book GetBook(string itemId)
		{
			Book book = books.Find(id => id.ItemId == itemId);
			return book;
		}

		public double GetTotalValue()
		{
			double totalValue = 0.00;
			
			Utility utility = new Utility();

			foreach (Book book in books)
			{
				totalValue +=  utility.GetValueOfMerchandise(book);
				
			}
			return totalValue;
		}
	}
}

