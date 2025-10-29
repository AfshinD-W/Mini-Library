namespace Minilibrary.Entites
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> books { get; set; } = new List<Book>();
    }
}
