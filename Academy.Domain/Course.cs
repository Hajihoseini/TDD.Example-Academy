

namespace Academy.Domain
{
    public partial class CourseTests
    {
        public class Course
        {
            public int Id = 1;
            public string Name = "Programming";
            public bool IsOnline = true;
            public double Tuition = 1000;

            public Course(int id, string name, bool isOnline, double tuition)
            {
                GurdAgainstInvalidName(name);

                GurdAgainstInvalidTuition(tuition);

                Id = id;
                Name = name;
                IsOnline = isOnline;
                Tuition = tuition;
            }


            private static void GurdAgainstInvalidTuition(double tuition)
            {
                if (tuition <= 0)
                throw new CourseTuitionIsInvalidException();
            }


            private static void GurdAgainstInvalidName(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                    throw new CourseNameIsInvalidException();
            }
        }
    }
}