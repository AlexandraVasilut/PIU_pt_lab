using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CopilClase
{
    public class Copii
    {
        private const char separator_fisier = ';';
        private string nume;
        private string prenume;
        private string initiala_tata;
        private string clasa;

        public Copii(string n, string p, string ini, string cl) //Constructor
        {
            this.nume = n;
            this.prenume = p;
            this.initiala_tata = ini;
            this.clasa = cl;
        }

        public Copii(string linieFisier)
        {
            var dateFisier = linieFisier.Split(separator_fisier);

            nume = dateFisier[0];
            prenume = dateFisier[1];
            initiala_tata = dateFisier[2];
            clasa = dateFisier[3]; 
        }

        public string Get_Nume() //get nume
        {
                return nume;
        }
        public string Get_Prenume() //get prenume
        {
                return prenume;
        }

        public string Get_InitialaTata()//get initiala tata
        {
            return initiala_tata;
        }

        public string Get_Clasa()//get clasa
        {
            return clasa;
        }

        public Copii()
        {
            nume = prenume = initiala_tata = clasa = string.Empty;
        }

        public string ConversieLaSir_Fisier()
        {
            string obiectCopiiPtFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}"),
                separator_fisier, 
                nume, 
                prenume, 
                initiala_tata, 
                clasa);

            return obiectCopiiPtFisier;
        }
    }
    
}