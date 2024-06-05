// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Repository;

Console.WriteLine("Hello, World!");

using (Z9Context dbContext = new Z9Context())
{
    dbContext.Database.OpenConnection();
}