using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal // önce using i ekle sonra implement interface de.
    {
        List<Product> _products;
        public InMemoryProductDal() //ctor yaz 2 kez taba a tıkla
        {
            _products = new List<Product> {

            new Product {ProductId = 1, CategoryId = 1, ProductName="bardak", UnitPrice= 15, UnitsInStock=15 },
            new Product {ProductId = 2, CategoryId = 1, ProductName = "kamera", UnitPrice = 500, UnitsInStock = 3 },
            new Product {ProductId = 3, CategoryId = 2, ProductName = "telefon", UnitPrice = 1500, UnitsInStock = 2 },
            new Product {ProductId = 4, CategoryId = 2, ProductName = "klavye", UnitPrice = 150, UnitsInStock = 65 },
            new Product {ProductId = 5, CategoryId = 2, ProductName = "fare", UnitPrice = 85, UnitsInStock = 1 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product); //yazarsan referans tip olduğu için silinmez

            //bir ürünü silerken primary key kullanılır.(ıd)

            Product productToDelete;
            foreach (var p in _products)
            {
                if(product.ProductId== p.ProductId)
                {
                    productToDelete = p;
                }
            }
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
