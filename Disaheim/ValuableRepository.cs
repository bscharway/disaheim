using System.IO;
using System;
namespace Disaheim
{
	public class ValuableRepository: IPersistable
	{
		private List<IValuable> valuables;

		public ValuableRepository()
		{
			valuables = new List<IValuable>();
		}

		//-------------------Implememting the methods---------------------------

		// TODO implement the method AddValueble
		public void AddValuable(IValuable valuable)
		{
			valuables.Add(valuable);
		}

		// TODO Implement the method GetValueble

		public IValuable GetValuable(string id)
		{

			foreach (IValuable valuable in valuables)
			{
				if (valuable is Book b)
				{
					if (b.ItemId == id)
					{
						return b;
					}

				}

				else if (valuable is Amulet a)
				{
					if (a.ItemId == id)
					{
						return a;
					}
				}
			}
			return null;
		}

		// TODO Implement the method GetTotalValue
        public double GetTotalValue()
		{
			double total = 0.00;
			foreach (IValuable valuable in valuables)
			{
				total += valuable.GetValue();
			}
			return total;
		}

		public int Count()
		{
			int count = valuables.Count;
			return count;
		}

		//implementing the first save interface:
        public void Save()
        {
			using (StreamWriter writer = new StreamWriter("ValuableRepository.txt"))
			{
				try
				{
					foreach (IValuable valuable in valuables)
					{
						writer.WriteLine(valuable.ToString());
					}
					writer.Close();
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception: " + e.Message);
				}
			}
        }

        public void Save(string fileName)
        {
			using (StreamWriter writer = new StreamWriter($"{fileName}.txt"))
			{
				try
				{
					foreach (IValuable valuable in valuables)
					{
						writer.WriteLine(valuable.ToString());
					}
					writer.Close();
				}
				catch (Exception e)
				{
					Console.WriteLine("Exception: " + e.Message);
				}
			}
        }

        public void Load()
		{
			using (StreamReader myReader = new StreamReader("ValuableRepository.txt"))
			{
				string line = "";

				while (line != null)
				{
					line = myReader.ReadLine();
					if (line != null)
					{
						Console.WriteLine(line);
					}

				}
				myReader.Close();
			}
        }

        public void Load(string fileName)
        {
			using (StreamReader myReader = new StreamReader($"{fileName}.txt"))
			{
				string line = "";

				while (line != null)
				{
					line = myReader.ReadLine();
					if (line != null)
					{
						Console.WriteLine(line);
					}

				}
				myReader.Close();
			}
        }
    }
}

