using IRepository;

namespace Repository;

public class AccountAndCartRepository : IAccountAndCartRepository
{
    public object GetAccounWithCart(int id)
    {
        using (var context = new Z9Context())
        {
            var resoult = context.Accounts.Join(context.Roles,
            account => account.RoleId,
            role => role.RoleId,
            (account, role) => new
            {
                FirstName = account.FirstName,
                LastName = account.LastName,
                Email = account.Email,
                Phone = account.Phone,
                RoleName = role.RoleId,
                Cart = context.ShoppingCarts.Join(context.Products,
                    shoppingCart => shoppingCart.ProductId,
                    product => product.ProductId,
                    (shoppingCart, product) => new
                    {
                        ProductId = product.ProductId,
                        ProductName = product.Name,
                        Amount = shoppingCart.Amount

                    })
            });
            return resoult;
        }
    }
}