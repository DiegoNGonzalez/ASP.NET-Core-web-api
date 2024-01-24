namespace Backend_api.DTOs
{
    public class BeerInsertDto
    {
        public string Name { get; set; }
        public decimal Alcohol { get; set; }
        public int BrandId { get; set; }
    }
}
