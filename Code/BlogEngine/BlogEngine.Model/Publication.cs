namespace BlogEngine.Model
{
    public class Publication
    {
        public int PublicationId { get; set; }
        
        public string Title { get; set; }

        public string Content { get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

    }
}