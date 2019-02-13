using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ValRef
    {
        int V
        {
            get;
            set;
        }
    }


    class R : ValRef
    {
        private int L;

        public R(int V)
        {
            L = V;
        }


        public int V
        {
            get   
            {
                return L;
            }
            set
            {
                L = value;
            }
        }
        static void Main(string[] args)
        {
            void PV(ValRef P)
            {
                Console.WriteLine(P.V);
            }
        }
    }



}
