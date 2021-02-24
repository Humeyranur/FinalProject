using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); // Dataaccess ve entities'i project reference olarak seçip, ampulden using entities kısmını ekle.
    }
}
