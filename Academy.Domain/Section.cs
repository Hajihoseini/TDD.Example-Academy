namespace Academy.Domain
{
    public class Section
    {


        public Section(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public object Id { get; set; }
        public string Name { get; set; }
    }
}