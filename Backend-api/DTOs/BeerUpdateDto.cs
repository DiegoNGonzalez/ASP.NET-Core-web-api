namespace Backend_api.DTOs
{
    public class BeerUpdateDto
    {
        public string Name { get; set; }
        public decimal Alcohol { get; set; }
        public int BrandId { get; set; }
    }
}
