using System;
namespace Disaheim
{
	public class CourseRepository
	{
        private List<Course> courses;

        // making a constructor to initialize 
        public CourseRepository()
        {
            courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);

        }

        public Course GetCourse(string name)
        {
            Course course = courses.Find(id => id.Name == name);
            return course;
        }

        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValue = 0.00;

            foreach (Course course in courses)
            {
                totalValue += utility.GetValueOfCourse(course);
            }
            return totalValue;
        }
    }
}
