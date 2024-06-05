using z9.Models;

namespace IRepository;

public interface IProductRepository
{
    public int AddProduct(Product product, List<int> categoriesId);
}