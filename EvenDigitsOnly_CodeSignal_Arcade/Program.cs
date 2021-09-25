using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDigitsOnly_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 24682;
            bool x = evenDigitsOnly(n);
            Console.WriteLine(x);

        }

        static bool evenDigitsOnly(int n)
        {
            int y = 0;
            int g = 0;
            string x = Convert.ToString(n);
            for (int i = 0; i < x.Length; i++)
            {
                if (Convert.ToInt32(x[i]) % 2 == 0)
                {
                    y = 1;   
                }
                else
                {
                    g = 1;
                }
            }
            if (y == 1 && g == 0)
            {
                return true;
            }
            return false;
        }
    }
}
