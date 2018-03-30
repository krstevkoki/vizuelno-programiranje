namespace CashAccount
{
    public class Product
    {
        public decimal Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} {2:.00}", Code, Name, Price);
        }
    }
}