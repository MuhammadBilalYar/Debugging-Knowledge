using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locals_And_Autos
    {
    class Program
        {
        static void Main (string[] args)
            {
            Program obj = new Program ();

            var x = obj.AddNumber (obj.GetNumber (1), obj.GetNumber (2));
            var y = obj.AddNumber (obj.GetNumber (4), obj.GetNumber (5));

            var z = obj.AddNumber (obj.GetNumber (1), obj.GetNumber (2));
            Console.ReadKey ();
            var abc = 0;
            }
        public int GetNumber (int parm)
            {
            return parm;
            }

        public int AddNumber (int parm, int parm1)
            {
            return parm + parm1;
            }
        }
    }
