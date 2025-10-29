namespace Minilibrary.Entites
{
    public class Location
    {
        public int Id { get; set; }
        public string Row { get; set; }
        public string RowNumber { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
