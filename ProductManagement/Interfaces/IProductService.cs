using ProductManagement.Enums;
using ProductManagement.Models;

namespace ProductManagement.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProductsByCategory(Categories category);
        Product GetMostExpensiveProduct();
        decimal GetTotalPrice();
        Dictionary<Categories, List<Product>> GroupByCategory();
        decimal GetAveragePrice();
    }

}
