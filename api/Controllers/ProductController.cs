using IRepository;
using Microsoft.AspNetCore.Mvc;
using z9.Models;

namespace api.Controller;

[Route("api/products")]
[ApiController ]
public class ProductController:ControllerBase
{
    private IProductRepository _repository;
    [HttpPost]
    public IActionResult Add(string name, float weight, float width, float height, float depth, List<int> categoriesId)
    {
        var product = new Product(name,weight,width,height,depth);
        return Ok(_repository.AddProduct(product, categoriesId));
    }
}