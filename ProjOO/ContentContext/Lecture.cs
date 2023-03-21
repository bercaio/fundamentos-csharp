using ProjOO.ContentContext.Enums;
using ProjOO.SharedContext;

namespace ProjOO.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurantionInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}