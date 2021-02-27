using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID -O
    //OPEN CLOSED PRİNCİPLE : yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koda dokunamazsın.
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
          
            // foreach (var product in productManager.GetAll())

            //foreach (var product in productManager.GetByCategoryId(2))

            foreach (var product in productManager.GetByUnitPrice(40,100))

            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}
