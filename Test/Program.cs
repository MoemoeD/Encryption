using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RSAbcHelper h = new RSAbcHelper();
            h.GetKey();
        }
    }
}
