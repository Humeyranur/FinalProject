
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //çıplak class kalmasın-çck
   public class Category:IEntity// altta çıkan ampule tıkla ve using entities abstract ı seç.
    {
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }
    }
}
