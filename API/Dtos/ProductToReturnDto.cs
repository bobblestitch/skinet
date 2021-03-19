namespace API.Dtos
{
    public class ProductToReturnDto
    {
        // Represents the explicit data (message) that we want to return to the caller
        // Flattens out the graph - instead of returning a "lumpy" product (with child classes, etc)
        // We return this
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
    }
}