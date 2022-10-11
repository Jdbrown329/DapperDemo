using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public interface IProductRepository
    { 
       public IEnumerable<Product> GetAll();


    }
}
