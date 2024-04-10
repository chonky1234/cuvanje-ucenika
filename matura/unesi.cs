using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace matura
{
    public partial class unesi : Form
    {
        public int u = 0;
        public string[] redovi = File.ReadAllLines("ucenici.txt");
        public unesi()
        {
            InitializeComponent();
        }

        public void iskoristiTemplate(string[] s)
        {
            txtIme.Text = s[0];
            txtPrezime.Text = s[1];
            cbSkola.Text = s[2];
            txtOdeljenje.Text = s[3];
            cbTipMature.Text = s[4];
            cbJezik.Text = s[5];
            cbPrviPredmet.Text = s[6];
            cbDrugiPredmet.Text = s[7];
            cbTreciPredmet.Text = s[8];
        }


        private void btSacuvaj_Click(object sender, EventArgs e)
        {
            ucenik djak = new ucenik(txtIme.Text, txtPrezime.Text, cbSkola.Text, txtOdeljenje.Text,cbTipMature.Text, cbJezik.Text, cbPrviPredmet.Text, cbDrugiPredmet.Text, cbTreciPredmet.Text);
            djak.sacuvajUcenika();
        }

        private void cbJezik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPrviPredmet.Text = cbJezik.Text;
        }

        private void btSacuvajTemplate_Click(object sender, EventArgs e)
        {
            string[] s = {template.br.ToString(), txtIme.Text, txtPrezime.Text, cbSkola.Text, txtOdeljenje.Text, cbTipMature.Text, cbJezik.Text, cbPrviPredmet.Text, cbDrugiPredmet.Text, cbTreciPredmet.Text };

            Form1.temp.ubaci(s);

            template stefan = new template(txtIme.Text, txtPrezime.Text, cbSkola.Text, txtOdeljenje.Text, cbTipMature.Text, cbJezik.Text, cbPrviPredmet.Text, cbDrugiPredmet.Text, cbTreciPredmet.Text);
            stefan.sacuvajTemplate();
        }

        private void cbTipMature_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void unesi_Load(object sender, EventArgs e)
        {

        }

        private void cbTreciPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cbSkola_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSkola.SelectedItem == "Prva Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }
            if (cbSkola.SelectedItem == "Druga Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");                
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }
            if (cbSkola.SelectedItem == "Treca Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }
            if (cbSkola.SelectedItem == "Cetvrta Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }
            if (cbSkola.SelectedItem == "Peta Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }
            if (cbSkola.SelectedItem == "Sesta Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }
            if (cbSkola.SelectedItem == "Sedma Beogradska Gimnazija")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }




            if (cbSkola.SelectedItem == "Elektrotehnica skola Tesla")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Elektrotehnicar racunara");
                cbTreciPredmet.Items.Add("Elektrotehnicar informacionih tehnologija");
                cbTreciPredmet.Items.Add("Elektrotehnicar elektrotehnike");
                cbTreciPredmet.Items.Add("Elektrotehnicar energetike");
            }

            if (cbSkola.SelectedItem == "Sveti Sava")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
            }

            if (cbSkola.SelectedItem == "Graficka Skola")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Biologija");
                cbTreciPredmet.Items.Add("Istorija");
                cbTreciPredmet.Items.Add("Geografija");
                cbDrugiPredmet.Items.Clear();
            }

            if (cbSkola.SelectedItem == "Medicinska skola")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Hemija");
                cbTreciPredmet.Items.Add("Biologija");
                cbDrugiPredmet.Items.Clear();
            }

            if (cbSkola.SelectedItem == "Masinska skola")
            {
                cbTreciPredmet.Items.Clear();
                cbTreciPredmet.Items.Add("Fizika");
                cbTreciPredmet.Items.Add("Programiranje");
                cbTreciPredmet.Items.Add("Hemija");
                cbTreciPredmet.Items.Add("Elektrotehnicar racunara");
                cbTreciPredmet.Items.Add("Elektrotehnicar informacionih tehnologija");
                cbTreciPredmet.Items.Add("Elektrotehnicar elektrotehnike");
                cbTreciPredmet.Items.Add("Elektrotehnicar energetike");
            }


            /*Prva Beogradska Gimnazija
Druga  Beogradska Gimnazija
Treca  Beogradska Gimnazija
Cetvrta  Beogradska Gimnazija
Peta  Beogradska Gimnazija
Sesta  Beogradska Gimnazija
Sedma  Beogradska Gimnazija
Elektrotehnica skola Tesla
Sveti Sava
Graficka Skola
Medicinska Skola
Masinska skola
*/


        }

        private void btUcenikDesno_Click(object sender, EventArgs e)
        {
            


            /*txtIme.Text = s[0];
        txtPrezime.Text = s[1];
        cbSkola.Text = s[2];
        txtOdeljenje.Text = s[3];
        cbTipMature.Text = s[4];
        cbJezik.Text = s[5];
        cbPrviPredmet.Text = s[6];
        cbDrugiPredmet.Text = s[7];
        cbTreciPredmet.Text = s[8];*/
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbSkola.Text = "";
            txtOdeljenje.Text = "";
            cbTipMature.Text = "";
            cbJezik.Text = "";
            cbPrviPredmet.Text = "";
            cbDrugiPredmet.Text = "";
            cbTreciPredmet.Text = "";

            //u++;
            u = (u + 1) % redovi.Length;
            int b = 0;
            for (int i = 0; i < redovi[u].Length; i++)
            {
                if (redovi[u][i] == ';')
                {
                    b++;
                    continue;
                }

                if (b == 0)
                {
                    txtIme.Text += redovi[u][i];
                }
                else if (b == 1)
                {
                    txtPrezime.Text += redovi[u][i];
                }
                else if (b == 2)
                {
                    cbSkola.Text += redovi[u][i];
                }
                else if (b == 3)
                {
                    txtOdeljenje.Text += redovi[u][i];
                }
                else if (b == 4)
                {
                    cbTipMature.Text += redovi[u][i];
                }
                else if (b == 5)
                {
                    cbJezik.Text += redovi[u][i];
                }
                else if (b == 6)
                {
                    cbPrviPredmet.Text += redovi[u][i];
                }
                else if (b == 7)
                {
                    cbDrugiPredmet.Text += redovi[u][i];
                }
                else if (b == 8)
                {
                    cbTreciPredmet.Text += redovi[u][i];
                }
            }

            
        }

        private void btUcenikLevo_Click(object sender, EventArgs e)
        {
        

            /*txtIme.Text = s[0];
        txtPrezime.Text = s[1];
        cbSkola.Text = s[2];
        txtOdeljenje.Text = s[3];
        cbTipMature.Text = s[4];
        cbJezik.Text = s[5];
        cbPrviPredmet.Text = s[6];
        cbDrugiPredmet.Text = s[7];
        cbTreciPredmet.Text = s[8];*/
            txtIme.Text = "";
            txtPrezime.Text = "";
            cbSkola.Text = "";
            txtOdeljenje.Text = "";
            cbTipMature.Text = "";
            cbJezik.Text = "";
            cbPrviPredmet.Text = "";
            cbDrugiPredmet.Text = "";
            cbTreciPredmet.Text = "";

            u = (u - 1 + redovi.Length) % redovi.Length;
            int b = 0;
            for (int i = 0; i < redovi[u].Length; i++)
            {
                if (redovi[u][i] == ';')
                {
                    b++;
                    continue;
                }

                if (b == 0)
                {
                    txtIme.Text += redovi[u][i];
                }
                else if (b == 1)
                {
                    txtPrezime.Text += redovi[u][i];
                }
                else if (b == 2)
                {
                    cbSkola.Text += redovi[u][i];
                }
                else if (b == 3)
                {
                    txtOdeljenje.Text += redovi[u][i];
                }
                else if (b == 4)
                {
                    cbTipMature.Text += redovi[u][i];
                }
                else if (b == 5)
                {
                    cbJezik.Text += redovi[u][i];
                }
                else if (b == 6)
                {
                    cbPrviPredmet.Text += redovi[u][i];
                }
                else if (b == 7)
                {
                    cbDrugiPredmet.Text += redovi[u][i];
                }
                else if (b == 8)
                {
                    cbTreciPredmet.Text += redovi[u][i];
                }
            }
        }
    }
}
