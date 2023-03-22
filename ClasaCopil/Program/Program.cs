using System;
using System.Configuration;
//using CopilClase;
//using NivelStocareDate;

namespace EvidentaCopii_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            do
            {
                Console.WriteLine("A. Adaugare copil de la tastatura.");
                Console.WriteLine("B. Afisare copii.");
                Console.WriteLine("C. Cautare copii dupa nume.");
                Console.WriteLine("F. Afisare copii din fisier.");
                Console.WriteLine("S. Salvare copii in fisier.");
                Console.WriteLine("X. Inchidere program.");
                Console.WriteLine("Alegeti o optiune: ");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "A":
                        int idCopil = AdaugareCopilTastatura();

                        break;

                    case "B":
                        string infoCopil = copil.Info();
                        Console.WriteLine("Copilul {0}", infoCopil);

                        break;

                    case "C":
                        Console.Write("Dati numele copilului pe care il cautati: ");
                        string copil_cautat = Console.ReadLine();
                        Copil[] lista = adminCopii.GetCopii(out nrCopii);
                        cautareCopiiNume(lista, initiala_tata);

                        break;

                    case "F":
                        Copil[] lista_copil = adminCopii.GetCopil(out nrCopii);
                        AfisareCopii(lista_copii, nrCopii);

                        break;

                    case "S":
                        idCopil = nrCopii + 1;
                        nrCopii++;
                        copil = new Copil(idCopil, "Ioana", "Radu");
                        //adaugare student in fisier
                        adminCopii.AddCopil(copil);

                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiunea nu exista!");

                        break;
                }
            } while (opt.ToUpper() != "X");

            Console.ReadKey();
        }

        //citire copii de la tastatura
        public static Copil CitireCopilTastatura()
        {
            Console.WriteLine("Introdu numele copilului: ");
            string nume = Console.ReadLine();
            Console.WriteLine("Introdu prenumele copilului: ");
            string prenume = Console.ReadLine();
            Console.WriteLine("Introduceti initiala tatalui: ");
            string initiala_tata = Console.ReadLine();
            Console.WriteLine("Introduceti clasa din care face parte copilul: ");
            string clasa = Console.ReadLine();
            Copil copil = new Copil(nume, prenume, initiala_tata, clasa);

            return copil;
        }

        //afisare copil
        public static void AfisareCopil(Copil copil)
        {
            Console.WriteLine("Copilul este:");
            string infoCopil = string.Format("Nume: {0}, Prenume: {1}, InitialaTata: {2}, Clasa: {3}",
                   copil.Get_Nume() ?? " Necunoscut ",
                   copil.Get_Prenume() ?? " Necunoscut ",
                   copil.Get_InitialaTata() ?? " Necunoscut ",
                   copil.GetClasa());

            Console.WriteLine(infoCopil);
            }
        }

    public static void AfisareCopii(Copii[] lista_copii, int nrCopii)
    {
        Console.WriteLine("Copiii sunt: ");
        for (int contor = 0; contor < nrCopii; contor++)
            AfisareCopii(lista_copii[contor]);
    }
}

