namespace Minilibrary.Entites
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
