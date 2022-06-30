using ProjOO.ContentContext.Enums;

namespace ProjOO.ContentContext
{
    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurantionInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}