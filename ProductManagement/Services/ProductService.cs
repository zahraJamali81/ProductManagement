using ProductManagement.Data;
using ProductManagement.Enums;
using ProductManagement.Interfaces;
using ProductManagement.Models;

namespace ProductManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = ProductData.Products;
        }

        public List<Product> GetProductsByCategory(Categories category)
        {
            return _products
                .Where(p => p.Category == category)
                .ToList();
        }

        public Product GetMostExpensiveProduct()
        {
            return _products
                .OrderByDescending(p => p.Price)
                .FirstOrDefault();
        }

        public decimal GetTotalPrice()
        {
            return _products.Sum(p => p.Price);
        }

        public Dictionary<Categories, List<Product>> GroupByCategory()
        {
            return _products
                .GroupBy(p => p.Category)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public decimal GetAveragePrice()
        {
            return _products.Average(p => p.Price);
        }
    }

}
