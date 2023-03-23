using System;
using Disaheim;
namespace Disaheim
{
	public class Utility
	{
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            double val = 0;

            if (merchandise is Book)
            {

                val = ((Book)merchandise).Price;
                
            }

            else if (merchandise is Amulet)
            {
                switch( ((Amulet)merchandise).Quality)
                {
                    case Level.low:
                        val = 12.5;
                        break;

                    case Level.medium:
                        val = 20.0;
                        break;

                    case Level.high:
                        val = 27.5;
                        break;
                }
            }
            return val;
        }
        //public double GetValueOfBook(Book book)
        //{

        //    return book.Price;
        //}
        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    switch (amulet.Quality)
        //    {
        //        case Level.low:
        //            return 12.5;
        //        //break;
        //        case Level.medium:
        //            return 20.0;
        //        //break;
        //        case Level.high:
        //            return 27.5;
        //            //break;

        //    }
        //    return 00.0;
        //}
        public double GetValueOfCourse(Course course)
        {
            int min = course.DurationInMinutes;
            int leftOver = min % 60;
            int wholeHours = (min - leftOver) / 60;

            if (min == 0)
            {
                return 0.00;
            }
            else if (wholeHours > 0 || leftOver > 0)
            {
                if (leftOver > 0)
                {
                    return (wholeHours + 1) * 875;
                }
                else
                {
                    return wholeHours * 875;
                }
            }

            return wholeHours * 875;


        }
    }
}

