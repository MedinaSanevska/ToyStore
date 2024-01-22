namespace ToyStore_Models.Models
{
    public class ToyMaker
    {
        public string Category;

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string Specialty { get; set; } = string.Empty;
    }
}
