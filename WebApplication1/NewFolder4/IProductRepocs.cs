namespace WebApplication1.NewFolder4
{
    public interface IProductRepocs
    {
        int addProduct(Products product);
        List<Products> GetAllProducts();
    }
}