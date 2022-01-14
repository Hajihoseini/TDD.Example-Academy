using Academy.Domain;

namespace Academy.Infrastructure
{
    public class CourseRepository
    {
        public List<Course> Courses = new List<Course>
        {
            new Course(24,"Programming with C#",true,5000)
        };

        public void Create(Course course)
        {
            Courses.Add(course);
        }

    }
}