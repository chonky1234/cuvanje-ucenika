using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace matura
{
    public class template
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



        public template(string ime, string prezime, string skola, string odeljenje, string tipmature, string jezik, string prvipredmet, string drugipredmet, string trecipredmet)
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

        public void sacuvajTemplate()
        {
            br++;
            //string[] s = this.ime + ";" + this.prezime + ";" + this.skola + ";" + this.odeljenje + ";" + this.tipmature + ";" + this.jezik + ";" + this.prvipredmet + ";" + this.drugipredmet + ";" + this.trecipredmet
            StreamWriter zika = new StreamWriter("templateovi.txt", true);
            zika.WriteLine(this.ime + ";" + this.prezime + ";" + this.skola + ";" + this.odeljenje + ";" + this.tipmature + ";" + this.jezik + ";" + this.prvipredmet + ";" + this.drugipredmet + ";" + this.trecipredmet + ";");
            zika.Close();
        }
    }
}
