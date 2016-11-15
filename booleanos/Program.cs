using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//Así añadimos la clase y evitamos escribirla en el método.
using static System.Convert;

namespace booleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Introduce un entero:");
            int miInt = ToInt32(ReadLine());
            bool esMenorQue10 = miInt < 10;
            bool entre0Y10 = ((0 < miInt) && (miInt < 5));
            WriteLine($"¿Entero menor que 10?: {esMenorQue10}");
            WriteLine($"¿Entero entre 0 y 5?: {entre0Y10}");
            WriteLine($"¿Se cumple alguna opción?: {esMenorQue10^entre0Y10}");
            ReadKey();
        }
    }
}
