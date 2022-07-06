using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            //  başrılı mı başarısız mı olduğunu ve bilgi mesajı görmek isterse bu çalışır.
        }
        public SuccessResult() : base(true)
        {
            // sadece başrılı mı başarısız mı olduğunu görmek isterse bu çalışır.
        }
    }
}
