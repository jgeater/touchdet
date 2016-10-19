using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace touchdect

{
    class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);
        const int SM_MAXIMUMTOUCHES = 95;
        static void Main(string[] args)
        {

            Console.WriteLine(GetSystemMetrics(SM_MAXIMUMTOUCHES));
            //Console.ReadKey();
        }
    }
}
