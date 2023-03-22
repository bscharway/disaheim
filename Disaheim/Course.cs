using System;
namespace Disaheim
{
	public class Course
	{
		public string Name { get; set; }
		public int DurationInMinutes { get; set; }

		//Constructor overloading and setting a default value for durationInMinutes 
		public Course(string name, int durationInMinutes = 0)
		{
			Name = name;
			DurationInMinutes = durationInMinutes;

		}

        public override string ToString()
        {
			return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}

