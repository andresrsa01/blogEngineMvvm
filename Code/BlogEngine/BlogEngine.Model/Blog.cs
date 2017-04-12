using System.Collections.Generic;

namespace BlogEngine.Model
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public virtual List<Publication> Publications { get; set; }
    }
}
