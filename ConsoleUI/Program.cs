using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //solid
    //o= open closed principle dosyana yenı bir komut ekliyorsan eski yazdığın hicbir komutuna dokunamazsın
    // bu yaptığımızn örnekler solid prensibinin o harfıne denk gelir
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}