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
            bool a;
            Console.WriteLine("quante piazze vuoi inseire?");

            do
            {
                a = int.TryParse(Console.ReadLine(), out n);
                if (!a || n <= 0)
                {
                    Console.WriteLine("valore non valido");
                    a = false;
                }
            }while (!a) ;

            Cpiazza[] piazza = new Cpiazza[n];

            for (int i = 0; i < piazza.Length; i++)
            {
                string nomeP;
                do
                {
                    Console.WriteLine("inserisci il nome della piazza");
                    nomeP = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeP))
                    {
                        Console.WriteLine("il nome non deve essere vuoto");
                    }
                } while (string.IsNullOrWhiteSpace(nomeP));

                string citta;
                do
                {
                    Console.WriteLine("inserisci la citta della piazza");
                    citta = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(citta))
                    {
                        Console.WriteLine("la citta non deve essere vuota");
                    }
                } while (string.IsNullOrWhiteSpace(citta));


                float diametro = 0;
                do
                {
                    Console.Write("Diametro della piazza (metri): ");
                    a = float.TryParse(Console.ReadLine(), out diametro);
                    if (!a || diametro <= 0)
                    {
                        Console.WriteLine("Il diametro non deve essere negativo");
                        a = false;
                    }
                } while (!a);


                string nomeF;
                do
                {
                    Console.Write("Nome della fontana: ");
                    nomeF = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nomeF))
                    {
                        Console.WriteLine("Il nome della fontana non deve essere vuoto");
                    }
                } while (string.IsNullOrWhiteSpace(nomeF));


                string autore;
                do
                {
                    Console.Write("Autore della fontana: ");
                    autore = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(autore))
                    {
                        Console.WriteLine("L'autore non deve essere vuoto");
                    }
                } while (string.IsNullOrWhiteSpace(autore));


                float cacqua = 0;
                do
                {
                    Console.WriteLine("inserisci il consumo d'acqua");
                    a = float.TryParse(Console.ReadLine(), out cacqua);
                    if (!a || cacqua <= 0)
                    {
                        Console.WriteLine("il consumo non deve essere negativo");
                        a = false;
                    }
                } while (!a);

                int s;
                bool S;
                do
                {
                    Console.WriteLine("Inserisci lo stato notturno della fontana (0 = spento | 1 = acceso)");
                    a = int.TryParse(Console.ReadLine(), out s);
                    if (!a || s < 0 || s > 1)
                    {
                        Console.WriteLine("Comandi non validi");
                        a = false;
                    }
                } while (!a);

                if (s == 0)
                {
                    S = false;
                }
                else
                {
                    S = true;
                }


                piazza[i] = new Cpiazza(diametro, citta, nomeP, nomeF, cacqua, S, autore);

                piazza[i].AggiungiManutenzione("manutenzione di base realizzata");
            }


                Console.WriteLine("ecco le fontane\n");
                for (int j = 0; j < piazza.Length; j++)
                {
                    Console.WriteLine(piazza[j].InfoPiazza());

                    Console.WriteLine("metodo personalizzato della fontana\n");
                    Console.WriteLine($"Consumo d'acqua mensile: {piazza[j].CalcolaConsumoMensile()}");

                }


            }
        }
    }
