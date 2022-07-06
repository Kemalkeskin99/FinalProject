using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // temel voidler için
    // işlem sonucu ve işlem sonucu bilgilendirme mesajları için
    public interface IResult
    {
        bool Success { get; } //  yapmak istediğim işlem başrılı mı başarısız mı
        string Message { get; } // işlem sonucu bilgilendirme kısmı
    }
}
