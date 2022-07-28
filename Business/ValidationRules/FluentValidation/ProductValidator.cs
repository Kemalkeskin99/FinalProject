using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);

            //fiyatı 10 tlden duşük olamaz ama sadece category ıdsı 1 olanlar için 
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
             //burda normalde olmayan ama sadece bızım  proje ıcın kendı kurallımızı yazdık. 
             //kural urun ısmı a ile başlayacak
             // widthmessage;=hata olunca istediğimiz mesajı ekrana yazar
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler A ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            // true donerse kurala uygun false ise kurala uygun değil
            return arg.StartsWith("A");
            //isim a ile başlamazsa kural hata verır(false).
        }
    }
}
