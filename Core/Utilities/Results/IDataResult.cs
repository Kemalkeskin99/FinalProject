using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // succes ,message ve veri var
    // içinde success ve mesage olduğu için tekrar yazmak yerine IResult implemnete ettik.
    
    public interface IDataResult<T>:IResult
    {
        // Gneric yapı kullandık (T) çünkü birisi ürün döndürüyor başkası ürün listesi döndürüyor, başkası kategori döndürüyo, kategori listesi döndürüryo bu yuzden hangı yapı ile çalışacagımızı söyluyoruz.
        T Data { get;}
    }
}
