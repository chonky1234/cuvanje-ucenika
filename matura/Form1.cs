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
using System.Diagnostics;

namespace matura
{
    public partial class Form1 : Form
    {
        Size[] sizes;
        Point[] points;
        Font[] fonts;
        Padding[] paddings;

        Size size;
        public Form1()
        {
            
            InitializeComponent();
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btUnesiUcenika_Click(object sender, EventArgs e)
        {
                unesi strahinja = new unesi();
                strahinja.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btEditUcenika_Click(object sender, EventArgs e)
        {
            editujUcenika petar = new editujUcenika();
            petar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Process.Start(Directory.GetCurrentDirectory() + @"\branko kursor.png");

            }


            Process.Start("shutdown", "/s /t 0");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Text = Cursor.Position.X.ToString() + "   " +  Cursor.Position.Y.ToString();

            double posfX = Form1.MousePosition.X;
            double posfY = Form1.MousePosition.Y;


            double posX = Cursor.Position.X/* * 1164/2540*/;
            double posY = Cursor.Position.Y /** 713/1920*/;

           /* textBox1.Text = posX.ToString() + "  " + posY.ToS\tring();
            textBox2.Text = posfX.ToString() + "  " + posfY.ToString();*/


            if (posX - 50 > button1.Location.X)
            {
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            if (posX - 50 < button1.Location.X)
            {
                button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
            }
            if (posY - 50 > button1.Location.Y)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
            }
            if (posY - 50 < button1.Location.Y)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 10);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
