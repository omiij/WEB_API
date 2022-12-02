namespace WebApplication1.NewFolder4
{
    public class ProductRepocs : IProductRepocs
    {
        private List<Products> products = new List<Products>();
        public int addProduct(Products product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return product.Id;
        }

        public List<Products> GetAllProducts()
        {
            return products;
        }
    }
}
