using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAuthorization
{
    public class Aut
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log">строка</param>
        /// <param name="pas">строка</param>
        /// <param name="chek">булево значение</param>
        public static void Authoriz(string log, string pas,
                                    out bool chek)
        {
            chek = false;
            if (log == "admin" && pas == "admin")
                chek = true;
        }
    }
}
