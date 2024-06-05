using IRepository;
using z9.Models;

namespace Repository;

public class ProductRepository:IProductRepository
{
    
    public int AddProduct(Product product, List<int> categoriesId)
    {
        using (var context = new Z9Context())
        {
            context.Products.Add(product);
            var productCategories = new List<ProductsCategories>();
            var id = product.ProductId;
            for (int i = 0; i < categoriesId.Count; i++)
            {
                var productCategory = new ProductsCategories(id, categoriesId[i]);
                productCategories.Add(productCategory);
            }
            product.ProductsCategories = productCategories;
            context.SaveChanges();
            return id;
        }

    }
    
}