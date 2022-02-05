namespace pharmacy_pos.ef.Entities.ProductType
{
    public class ProductType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Product.Product> Products { get; set; }
    }
}
