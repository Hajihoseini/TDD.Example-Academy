namespace Academy.Domain.Tests
{
    public class CourseTestBuilder
    {
        private int id = 1;
        private string _name = "Programming";
        private const bool IsOnline = true;
        private double _tuition = 1000;


        public CourseTestBuilder WithId(int Id)
        {
            id = Id;
            return this;
        }

        public CourseTestBuilder WithName(string name)
        {
            _name = name;
            return this;    
        }

        public CourseTestBuilder WithTuition(double tuition)
        {
            _tuition = tuition;
            return this;
        }

        public Course Build()
        {
            return new Course(id, _name, IsOnline, _tuition);
        }
    }
}
