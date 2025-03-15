using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300100
{
    class HaloGeneric
    {
        public static void sapaUser<T>(T nama)
        {
            Console.WriteLine("Halo User " + nama);
        }
    }
}
