using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele 
{

    public class Copil
    {
        private const char separator_fisier = ';';
        private int ID = 0;
        private string nume;
        private string prenume;
        private string initiala_tata;
        private string clasa;
        private int idCopil; //identificator unic student

        public Copil() //constructor implicit
        {
            nume = prenume = initiala_tata = clasa = string.Empty;
        }

        public Copil(int idCopil, string nume, string prenume, string initiala_tata, string clasa) //Constructor cu parametri
        {
            this.idCopil = idCopil;
            this.nume = nume;
            this.prenume = prenume;
            this.initiala_tata = initiala_tata;
            this.clasa = clasa;
        }

        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Copil(string linieFisier)
        {
            var dateFisier = linieFisier.Split(separator_fisier);
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idCopil = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[0];
            prenume = dateFisier[1];
            initiala_tata = dateFisier[2];
            clasa = dateFisier[3];
        }

        public int Get_idCopil()
        {
            return idCopil;//get idCopil
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

        public string ConversieLaSir_Fisier()
        {
            string obiectCopiiPtFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                separator_fisier,
                idCopil.ToString(),
                nume,
                prenume,
                initiala_tata,
                clasa
                    );

            return obiectCopiiPtFisier;
        }
    }
}
