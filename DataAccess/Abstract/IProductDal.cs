using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //List<Product> GetAll(); //ürün listelemek için
        //// başka bir katmanı kullanmak istersek referans gös termeliyiz.
        //// product ı kırmızı çizdiyse ampulden add referansı seç eğer olmazsa cancel de. DataAccess sağ tık ekle project referance de gelen ekrandan sadece entities'i seç ampulde artık using kısmı gelir, tıkla.
        //void Add(Product product);
        //void Update (Product product);
        //void Delete(Product product);

        //List<Product> GetAllByCategory(int categoryId); // ürünleri kategori id'ye göre filtreleme.
    }
}
