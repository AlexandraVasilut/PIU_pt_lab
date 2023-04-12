using Modele;
using System;
using System.Configuration;
using System.Globalization;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Copil copil = new Copil();
            //string numeFisier = ConfigurationManager.ApppSettings["NumeFisier"];
            int nrCopii = 0; 
            
            string opt;
            do
            {
                Console.WriteLine("A. Adaugare copil de la tastatura.");
                Console.WriteLine("B. Afisare copii.");
                //Console.WriteLine("C. Cautare copii dupa nume.");
                Console.WriteLine("F. Afisare copii din fisier.");
                Console.WriteLine("S. Salvare copil in fisier.");
                Console.WriteLine("X. Inchidere program.");
                Console.WriteLine("Alegeti o optiune: ");
                opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "A":
                        int idCopil = nrCopii + 1;
                        Console.WriteLine("Introdu numele copilului: ", idCopil);
                        string nume = Console.ReadLine();
                        Console.WriteLine("Introdu prenumele copilului: ", idCopil);
                        string prenume = Console.ReadLine();
                        Console.WriteLine("Introduceti initiala tatalui: ", idCopil);
                        string initiala_tata = Console.ReadLine();
                        Console.WriteLine("Introduceti clasa din care face parte copilul: ", idCopil);
                        string clasa = Console.ReadLine();
                        copil = new Copil(idCopil, nume, prenume, initiala_tata, clasa);
                        nrCopii++;

                        break;

                    case "B":
                        string infoCopil = copil.Get_Nume();
                        Console.WriteLine("Copilul {0}", infoCopil);

                        break;

                    /*case "C":
                        Console.Write("Dati numele copilului pe care il cautati: ");
                        string copil_cautat = Console.ReadLine();
                        Copil[] lista = adminCopii.GetCopii(out nrCopii);
                        cautareCopiiNume(lista, initiala_tata);

                        break;*/

                    /*case "F":
                        Copil[] copii = adminCopii.GetCopii(out nrCopii);
                        AfisareCopii(copii, nrCopii);

                        break;

                    /*case "S":
                        idCopil = nrCopii + 1;
                        nrCopii++;
                        copil = new Copil(idCopil, "Ioana", "Radu");
                        //adaugare student in fisier
                        adminCopii.AddCopil(copil);

                        break;*/

                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiunea nu exista!");

                        break;
                }
            } while (opt.ToUpper() != "X");
            Console.ReadKey();
        }

        //afisare copil
        public static void AfisareCopil(Copil[] copii, int nrCopii)
        {
            Console.WriteLine("Copiii sunt:");
            for (int contor = 0; contor < nrCopii; contor++)
            {
                string infoCopil = string.Format("Copilul cu id-ul #{0} are numele: {1}, Prenume: {2}, InitialaTata: {3}, Clasa: {4}",
                    copii[contor].Get_idCopil(),               
                    copii[contor].Get_Nume() ?? " NECUNOSCUT ",
                    copii[contor].Get_Prenume() ?? " NECUNOSCUT ",
                    copii[contor].Get_InitialaTata() ?? " NECUNOSCUT ",
                    copii[contor].Get_Clasa() ?? " NECUNOSCUT ");
                Console.WriteLine(infoCopil);
            }
        }
    }
}
