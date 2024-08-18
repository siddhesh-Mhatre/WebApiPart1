using WebApiUsingCrudStored.Models;

namespace WebApiUsingCrudStored.Repo
{
    public interface IRepository
    {
        // get all products
     List<Product> GetProducts();


     void AddProduct(Product product);
    }
}
