using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint=generic sınırlandırma
    // class = referans tıp olabilir demek
   // new()= newlenebılır olabilmeli boylece IEntity kaldırmış olduk sadece IEntity implemente eden sınıfları çekebilicez
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //expression linq teki sartlı getirme kodu iste kategori 2 olanı getır vs..(p=>p.categoryıd==2)

        // filter=null veya filter arasındaki fark filtre siz hepsini getir veya filtreli olanları getir demek
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        
        // tek bir veri getirme 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);

        void Delete(T entity);

       
    }
}
