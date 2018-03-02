using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_Stack
    {
    class Program
        {
        static void Main (string[] args)
            {
            Program progObj = new Program ();
            string email = "Muhammad.Bilal@hotmail.com";
            progObj.ExtractNameFromEmail (email);
            }
        void ExtractNameFromEmail (string email)
            {
            string name= email.Split ('@').FirstOrDefault ();
            SplitName (name);
            }
        void SplitName (string name)
            {
            string fisrtName= name.Split ('.').FirstOrDefault ();
            string lastName = name.Split ('.').LastOrDefault ();
            PrintName (fisrtName, lastName);
            }

        private void PrintName (string fName, string lName)
            {
            Console.WriteLine ($"First Name: {fName}");
            Console.WriteLine ($"Last Name: {lName}");
            Console.WriteLine ($"Full Name: {fName} {lName}");
            }
        }
    }
