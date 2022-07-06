using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //solid
    //o= open closed principle dosyana yenı bir komut ekliyorsan eski yazdığın hicbir komutuna dokunamazsın
    // bu yaptığımızn örnekler solid prensibinin o harfıne denk gelir

    //DTO data transformation object
    public class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
                
           // Categorytest();
        }

        private static void Categorytest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true){
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}