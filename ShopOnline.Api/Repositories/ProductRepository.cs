using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext _context)
        {
            shopOnlineDbContext = _context;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await shopOnlineDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public Task<ProductCategory> GetItemCategory(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await shopOnlineDbContext.Products.ToListAsync();

            return products;
        }
    }
}
