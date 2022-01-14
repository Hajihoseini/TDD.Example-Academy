

namespace Academy.Domain
{
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsOnline { get; set; }
            public double Tuition { get; set; }
            public List<Section> Sections { get; set; }


            public Course(int id, string name, bool isOnline, double tuition)
            {
                GurdAgainstInvalidName(name);
                GurdAgainstInvalidTuition(tuition);
                Id = id;
                Name = name;
                IsOnline = isOnline;
                Tuition = tuition;
                Sections = new List<Section>();  
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

            public void AddSection(Section section)
            {
                Sections.Add(section);
            }

            public override bool Equals(object obj)
            {
                if(obj is Course course) return false;
                return Id == course.Id;
            }

        }
    
}