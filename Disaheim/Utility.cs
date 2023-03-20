﻿using System;
namespace Disaheim
{
	public class Utility
	{
		public double GetValueOfBook(Book book)
		{

			return book.Price ;
		}
		public double GetValueOfAmulet(Amulet amulet)
		{
			switch (amulet.Quality)
			{
				case Level.low:
					return 12.5;
					//break;
				case Level.medium:
					return 20.0;
					//break;
				case Level.high:
					return 27.5;
					//break;

			}
			return 00.0;
		}
	}

}

