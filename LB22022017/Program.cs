using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB22022017
{
    class Program
    {
        static void Main(string[] args)
        {
            complex c1 = new complex(4,-7);
            complex c2 = new complex(5,8);

            complex c3 = new complex(4, -7);
            complex c4 = new complex(5, 8);

            complex c5 = new complex(4, -7);
            complex c6 = new complex(5, 8);


            c1.add(c2);
            c3.Substract(c4);
            c5.Multiply(c5);

            /// f5 ile çalıştır ve bak c3 ve c5 in değerlerine
            /// 
            
        }
    }
}
