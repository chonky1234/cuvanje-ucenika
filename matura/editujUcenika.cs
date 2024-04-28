using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matura
{
    public partial class editujUcenika : Form
    {
        public string[] p = null;

        public editujUcenika()
        {
            InitializeComponent();

            StreamReader zoran = new StreamReader("ucenici.txt");
            int red = 0;
            while(!zoran.EndOfStream)
            {
                string line = zoran.ReadLine();
                string[] parts = line.Split(';');
                string[] p = { red.ToString(), parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8] };
                dgvTemplateovi.Rows.Add(p);

                red++;
            }
            zoran.Close();
        }

        private void dgvTemplateovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTemplateovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTemplateovi.SelectedRows.Count == 1)
                {
                    p = new string[] {dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[2].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[3].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[4].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[5].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[6].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[7].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[8].Value.ToString(),
                    dgvTemplateovi.SelectedRows[0].Cells[9].Value.ToString()};



                    textBox1.Text = dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString();
                    textBox2.Text = dgvTemplateovi.SelectedRows[0].Cells[2].Value.ToString();
                    textBox3.Text = dgvTemplateovi.SelectedRows[0].Cells[3].Value.ToString();
                    textBox4.Text = dgvTemplateovi.SelectedRows[0].Cells[4].Value.ToString();
                    textBox5.Text = dgvTemplateovi.SelectedRows[0].Cells[5].Value.ToString();
                    textBox6.Text = dgvTemplateovi.SelectedRows[0].Cells[6].Value.ToString();
                    textBox7.Text = dgvTemplateovi.SelectedRows[0].Cells[7].Value.ToString();
                    textBox8.Text = dgvTemplateovi.SelectedRows[0].Cells[8].Value.ToString();
                    textBox9.Text = dgvTemplateovi.SelectedRows[0].Cells[9].Value.ToString();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Niste lepo selektovali");
            }
        }
            

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






        private void btPotvrdi_Click(object sender, EventArgs e)
        {
            int linija = int.Parse(dgvTemplateovi.SelectedRows[0].Cells[0].Value.ToString());

            string p = dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString() + ';' +
                dgvTemplateovi.SelectedRows[0].Cells[1].Value.ToString();



            dgvTemplateovi.SelectedRows[0].Cells[1].Value = textBox1.Text;
            dgvTemplateovi.SelectedRows[0].Cells[2].Value = textBox2.Text;
            dgvTemplateovi.SelectedRows[0].Cells[3].Value = textBox3.Text;
            dgvTemplateovi.SelectedRows[0].Cells[4].Value = textBox4.Text;
            dgvTemplateovi.SelectedRows[0].Cells[5].Value = textBox5.Text;
            dgvTemplateovi.SelectedRows[0].Cells[6].Value = textBox6.Text;
            dgvTemplateovi.SelectedRows[0].Cells[7].Value = textBox7.Text;
            dgvTemplateovi.SelectedRows[0].Cells[8].Value = textBox8.Text;
            dgvTemplateovi.SelectedRows[0].Cells[9].Value = textBox9.Text;



            string test1 = textBox1.Text;
            string test2 = textBox2.Text;
            string test3 = textBox3.Text;
            string test4 = textBox4.Text;
            string test5 = textBox5.Text;
            string test6 = textBox6.Text;
            string test7 = textBox7.Text;
            string test8 = textBox8.Text;
            string test9 = textBox9.Text;


            List<string> petar = new List<string>();
            StreamReader sr = new StreamReader("ucenici.txt");
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                petar.Add(line);
            }
            sr.Close();

/*
            string zoran = File.ReadAllText("ucenici.txt");
            int t = 0;
            string b = "";
            for (int i = 0; i < zoran.Length; i++)
            {
                if (zoran[i] == '\r')
                {
                    petar.Add(b);
                    b = "";
                    t++;
                    i++;
                }
                else
                {
                    b += zoran[i];
                }    
            }
*/
     
            
            string s2 = textBox1.Text + ';' +
                textBox2.Text + ';' +
                textBox3.Text + ';' +
                textBox4.Text + ';' +
                textBox5.Text + ';' +
                textBox6.Text + ';' +
                textBox7.Text + ';' +
                textBox8.Text + ';' +
                textBox9.Text;



            string s = s2;//.Remove(s2.Length - 1, 1);

           // petar[linija] = "";
            petar[linija] = s;


            File.Delete("ucenici.txt");
            StreamWriter a = new StreamWriter("ucenici.txt", true);


            for (int i = 0; i < petar.Count; i++)
            {
                a.WriteLine(petar[i]);       
            }
            a.Close();
            int n = 77;
        }
    }
}
