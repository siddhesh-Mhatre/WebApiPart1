using Microsoft.EntityFrameworkCore;
using WebApiUsingCrudStored.Data;
using WebApiUsingCrudStored.Models;
using WebApiUsingCrudStored.Repo;

namespace WebApiUsingCrudStored.Service
{
 
    public class Services : IRepository
    {
        private readonly DonContext _context;

        public Services(DonContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Database.ExecuteSqlRaw("EXEC CreateProduct @p0, @p1, @p2",
              product.ProdName,
              product.Price,
              product.Category);
        }

        public List<Product> GetProducts()
        {
            var products = _context.Products
                                         .FromSqlRaw("EXEC GetAllProducts")
                                         .ToList();
            return products;
        }
    }
}
