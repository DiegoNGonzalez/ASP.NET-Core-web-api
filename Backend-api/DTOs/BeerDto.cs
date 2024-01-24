namespace Backend_api.DTOs
{
    public class BeerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Alcohol { get; set; }
        public int BrandId { get; set; }
    }
}
