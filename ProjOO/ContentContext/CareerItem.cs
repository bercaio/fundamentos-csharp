namespace ProjOO.ContentContext
{
    public class CareerItem
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
                throw new System.Exception("O curso nao pode ser NULL");

            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}