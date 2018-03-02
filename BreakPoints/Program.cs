using System;

namespace BreakPoints
    {
    class Program
        {
        static void Main (string[] args)
            {
            Console.ReadKey ();
            Program obj = new Program ();

            var x = obj.AddNumber (obj.GetNumber (1), obj.GetNumber (2));

            Console.WriteLine (x);
            Console.ReadKey ();
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
