namespace pharmacy_pos.ef.Entities.ProductType
{
    public class ProductType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public List<Product.Product> Products { get; set; }
    }
}
