namespace BurritoApi.Models
{
    public class Burrito
    {
        public int BurritoId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string Protein { get; set; }
        public string Review { get; set; }
        public Double Rating { get; set; }

    }
}