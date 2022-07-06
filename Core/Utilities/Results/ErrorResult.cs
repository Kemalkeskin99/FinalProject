using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)
        {
            //  başrılı mı başarısız mı olduğunu ve bilgi mesajı görmek isterse bu çalışır.
        }
        public ErrorResult() : base(false)
        {
            // sadece başrılı mı başarısız mı olduğunu görmek isterse bu çalışır.
        }
    }
}
