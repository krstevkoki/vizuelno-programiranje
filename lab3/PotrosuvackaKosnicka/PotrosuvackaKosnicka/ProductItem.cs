namespace PotrosuvackaKosnicka
{
    public class ProductItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public ProductItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public ProductItem()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} {1:.0}x{2:.0} = {3:.00}", Product, Quantity, Product.Price,
                Quantity * Product.Price);
        }
    }
}