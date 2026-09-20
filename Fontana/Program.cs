using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fontana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string nome;
            bool a;
            Console.WriteLine("quante piazze vuoi inseire?");

            do
            {
                a = int.TryParse(Console.ReadLine(), out n);
            } while (!a);
            {
                Console.WriteLine("valore non valido");
            }

            Cpiazza[] piazza = new Cpiazza[n];

            for (int i = 0; i < piazza.Length; i++)
            {
                Console.WriteLine("inserisci il nome della piazza");
                string nomeP = Console.ReadLine();

                Console.WriteLine("inserisci il consumo d'acqua");
                a = float.TryParse(Console.ReadLine(), out float cacqua);

                Console.WriteLine("Inserisci lo stato notturno della fontana (0 = spento | 1 = acceso)");
                a = int.TryParse(Console.ReadLine(), out int s);

                if ()



            }
        }
    }
}
