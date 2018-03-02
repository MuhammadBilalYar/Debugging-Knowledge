using System;
using System.Linq;

namespace Immediate_Window
    {
    class Program
        {
        static void Main (string[] args)
            {
            Program obj = new Program ();
            obj.PrintFirstAndLastName ("Muhammad.Bilal@hotmail.com");
            var x = obj.AddNumber (obj.GetNumber (1), obj.GetNumber (2));

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
        public void PrintFirstAndLastName (string email)
            {
            //string[] splitEmail = email.Split ('@');
            //string[] name = splitEmail[0].Split ('.');
            //Console.WriteLine ($"First Name : {name.FirstOrDefault ()}");
            //Console.WriteLine ($"Last Name : {name.LastOrDefault()}");
            }
        }
    }
