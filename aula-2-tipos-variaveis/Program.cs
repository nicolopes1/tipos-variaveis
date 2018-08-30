using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 1;
            // i = "s";

            var x = 2;
            // x = "666";

            char c = 'A';
            string c2 = "AAAA";

            // string nome = "Nicollas";
            var nome2 = "Nicollas";

            float f = 1.5f;
            var f2 = 1.6f;

            double d = 1.5;
            var d2 = 1.6;

            bool bo = true;
            bool bo2 = false;

            var boo = true;
            var boo2 = false;

            bool bolean = bool.Parse("false");
            bool bolean2 = Convert.ToBoolean("false");

            Animal a = new Animal();
            Leao l = new Leao();

            l = (Leao)a;

            a = l;

            Console.WriteLine(boo);
            Console.WriteLine(boo2);
        }
    }

    public class Animal
    {

    }

    public class Leao : Animal
    {

    }
}
