namespace EhandelsplatformforKunstnere.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public ICollection<Post> Comments { get; set; } = [];
    }
}
