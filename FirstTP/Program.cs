using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTP
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;
            int y = 2;
            int z = 3;
            int total = (x + y) * z;
            Console.WriteLine("Les 3 variables x, y et z correspondent à : " + x + ", " + y + " et " + z);
            Console.WriteLine("Le produit de la somme de x et y par z donne " +total);
            Console.ReadLine();
        }
    }
}
