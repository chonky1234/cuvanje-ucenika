using System;
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
    public partial class Form1 : Form
    {
        public static unesi strahinja = new unesi();
        public static templateovi temp = new templateovi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btUnesiUcenika_Click(object sender, EventArgs e)
        {

            strahinja.Show();
        }

        private void btUcitajTemplate_Click(object sender, EventArgs e)
        {
            temp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
