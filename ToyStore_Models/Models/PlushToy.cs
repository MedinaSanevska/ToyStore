namespace ToyStore_Models.Models
{
    public class PlushToy
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; }
        public int ToyMakerId { get; set; }
    }
}
