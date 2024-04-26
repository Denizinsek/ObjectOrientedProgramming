namespace ObjectOrientedProgramming.App3.Domains.Products
{
    internal class Product
    {
        public int ProductNo { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }

        public Product(int productNo, string productName, int price, string brand)
        {
            ProductNo = productNo;
            ProductName = productName;
            Price = price;
            Brand = brand;
        }

        public Product()
        {
        }

        public int Plug(int price, int piece)
        {

            return price += piece;
        }
    }
}
