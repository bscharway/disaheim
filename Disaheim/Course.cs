using System;
namespace Disaheim
{
	public class Course : IValuable
	{
		public string Name { get; set; }
		public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; }
        //public double CourseHourValue = 875.0;

        // Making a constuctor to initialize the courseHoursValue
        //public static void CourseHourValue(double chv)
        //{
        //    courseHourValue = new double();
        //    courseHourValue = chv;
        //}

        //TODO Implementing the interface (come back and change the code below to proper code)
        public double GetValue()
		{
            
            int min = this.DurationInMinutes;
            int leftOver = min % 60;
            int wholeHours = (min - leftOver) / 60;
            double toReturn = 0.0;

            if (min == 0)
            {
                return 0.00;
            }
            else if (wholeHours > 0 || leftOver > 0)
            {
                if (leftOver > 0)
                {
                    toReturn = (wholeHours + 1) * CourseHourValue;
                }
                else
                {
                    toReturn = wholeHours * CourseHourValue;
                }
            }
            return toReturn;
        }

		

		//Constructor overloading and setting a default value for durationInMinutes 
		public Course(string name, int durationInMinutes = 0)
		{
			Name = name;
			DurationInMinutes = durationInMinutes;
            CourseHourValue = 875.0;

		}

        public override string ToString()
        {
			return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {this.GetValue()}";
        }

        
    }
}

