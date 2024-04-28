using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace matura
{
    class ucenik
    {
        public static int br;
        string ime;
        string prezime;
        string skola;
        string odeljenje;
        string tipmature;
        string jezik;
        string prvipredmet;
        string drugipredmet;
        string trecipredmet;



        public ucenik(string ime,string prezime,string skola,string odeljenje, string tipmature, string jezik,string prvipredmet,string drugipredmet,string trecipredmet)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.skola = skola;
            this.odeljenje = odeljenje;
            this.tipmature = tipmature;
            this.jezik = jezik;
            this.prvipredmet = prvipredmet;
            this.drugipredmet = drugipredmet;
            this.trecipredmet = trecipredmet;
        }

        public void sacuvajUcenika()
        {
            br++;
            StreamWriter pera = new StreamWriter("ucenici.txt", true);

            /*int p = 0;
            string zoran = pera.ToString();

            for (int i = 0; i < zoran.Length; i++)
            {

            }*/

            string bezN;
            if (this.ime[0] == '\n')
            {
                bezN = this.ime.Remove(0, 1);
            }
            else
            {
                bezN = this.ime;
            }    
            
            pera.WriteLine(bezN + ";" + this.prezime + ";" + this.skola + ";" + this.odeljenje + ";" + this.tipmature + ";" + this.jezik + ";" + this.prvipredmet + ";" + this.drugipredmet + ";" + this.trecipredmet);
            pera.Close();
        }
    }
}
