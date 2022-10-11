using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public void CreateProduct(Product product)
        {
            _connection.Execute("INSERT INTO PRODUCTS  (Name)= @name, Price=@price, CategoryId=@category,OnSale = @onsale, Stocklevel=@stocklevel WHERE ProductId= @id;",
              new { name = product.Name, price = product.Price, category = product.CategoryID, onsale = product.OnSale, stocklevel = product.StockLevel });
            
        }

        public IEnumerable<Product> GetAll()
        {
            return _connection.Query<Product>("SELECT * FROM Products;").ToList();
        }

       
    }
}
