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
    public partial class templateovi : Form
    {
        public string[] p = null;
        public templateovi()
        {
            InitializeComponent();

            StreamReader zoran = new StreamReader("templateovi.txt");
            string s = zoran.ReadToEnd();
            string ime = "";
            string prezime = "";
            string skola = "";
            string odeljenje = "";
            string tipmature = "";
            string jezik = "";
            string prvipredmet = "";
            string drugipredmet = "";
            string trecipredmet = "";
            int b = 0;
            int z = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\n')
                {
                    string[] p = {z.ToString(), ime, prezime, skola, odeljenje, tipmature, jezik, prvipredmet, drugipredmet, trecipredmet };
                    dgvTemplateovi.Rows.Add(p);
                    z++;
                }
                if (s[i] == ';')
                {
                    b++;
                    continue;
                }

                if (b == 0)
                {
                    ime += s[i];
                }
                else if (b == 1)
                {
                    prezime += s[i];
                }
                else if (b == 2)
                {
                    skola += s[i];
                }
                else if (b == 3)
                {
                    odeljenje += s[i];
                }
                else if (b == 4)
                {
                    tipmature += s[i];
                }
                else if (b == 5)
                {
                    jezik += s[i];
                }
                else if (b == 6)
                {
                    prvipredmet += s[i];
                }
                else if (b == 7)
                {
                    drugipredmet += s[i];
                }
                else if (b == 8)
                {
                    trecipredmet += s[i];
                }
            }
            zoran.Close();
        }

        public void ubaci(string[] s)
        {
            dgvTemplateovi.Rows.Add(s);
        }

        private void templateovi_Load(object sender, EventArgs e)
        {

        }

        private void dgvTemplateovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btStaviTemplate_Click(object sender, EventArgs e)
        {
            /*string[] p = {dgvTemplateovi.SelectedCells[1].ToString(),
            dgvTemplateovi.SelectedCells[2].ToString(),
            dgvTemplateovi.SelectedCells[3].ToString(),
            dgvTemplateovi.SelectedCells[4].ToString(),
            dgvTemplateovi.SelectedCells[5].ToString(),
            dgvTemplateovi.SelectedCells[6].ToString(),
            dgvTemplateovi.SelectedCells[7].ToString(),
            dgvTemplateovi.SelectedCells[8].ToString(),
            dgvTemplateovi.SelectedCells[9].ToString(), };*/



            p = new string[] {dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[2].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[3].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[4].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[5].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[6].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[7].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[8].Value.ToString(),
            dgvTemplateovi.SelectedRows[0].Cells[9].Value.ToString()};

            //Form1.strahinja.iskoristiTemplate(p);
        }
    }
}
