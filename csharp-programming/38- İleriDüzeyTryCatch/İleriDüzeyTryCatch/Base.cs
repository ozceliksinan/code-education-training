using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriDüzeyTryCatch
{
   public  class Base
    {
        public void TryCatchKullanim(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {

                // Nlog ile loglama işlemi yapılacak .
            }
        }
    }
}
