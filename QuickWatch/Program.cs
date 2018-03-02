using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickWatch
    {
    class Program
        {
        static void Main (string[] args)
            {
            List<string> list = new List<string> ();
            list.Add ("hello");
            list.Add ("goodbye");

            #region Quick Watch
            int a, b;
            a = 1;
            b = 2;

            for (int i = 0; i < 10; i++)
                {
                a = a + b;
                }
            #endregion

            #region Watch
            //int a, b, c;
            //a = 1;
            //b = 2;
            //c = 0;

            //for (int i = 0; i < 10; i++)
            //    {
            //    a++;
            //    b *= 2;
            //    c = a + b;
                //}

            #endregion
            }
        }
    }
