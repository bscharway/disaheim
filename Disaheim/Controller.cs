using System;
namespace Disaheim
{
	public class Controller
	{
		// auto implementation of the properties (generic list)..
		public ValuableRepository ValuableRepo { get; set; }
		public List<Book> Books { get; set; }
		public List<Amulet> Amulets { get; set; }
		public List<Course> Courses { get; set; }


		//public Controller()
		//{
		//	ValuableRepo = new ValuableRepository();
		//}


		// Making a constructor to initialize the controller class and constructor overloading

		public Controller(Book book, Amulet amulet, Course course)
		{
			List<Book> Books = new List<Book> { book }; //making a new instance of Book list and assignng it to this.Books
			this.Books = Books;

			List<Amulet> Amulets = new List<Amulet> { amulet }; //making a new instance of Amulet list and assignng it to this.Amulets
			this.Amulets = Amulets;

			List<Course> Courses = new List<Course> { course };
			this.Courses = Courses;
		}
		public Controller()
		{
			Books = new List<Book>();
			Amulets = new List<Amulet>();
			Courses = new List<Course>();
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

		public void AddToList(Course course)
		{
			Courses.Add(course);
		}

		//public void AddToList(IValuable valuable)
		//{
		//	ValuableRepo.AddValuable(valuable);
		//}
	}
}

