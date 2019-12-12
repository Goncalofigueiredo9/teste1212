using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] n = new int[5];
            int[] s = new int[2];
            for (int i=0;i<5;i++)
            {
                bool existe;
                do
                {
                    Random rnd = new Random();
                    n[i] = rnd.Next(1, 51);
                    existe = false;
                    for (int j = 0; j < i; j++)
                        if (n[i] == n[j]) existe = true;
                }
                while (existe);
            }
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();

            for (int i = 0; i < 2; i++)
            {
                bool existe;
                do
                {
                    Random rnd = new Random();
                    n[i] = rnd.Next(1, 13);
                    existe = false;
                    for (int j = 0; j < i; j++)
                        if (n[i] == n[j]) existe = true;
                }
                while (existe);
            }
            n6.Text = n[0].ToString();
            n7.Text = n[1].ToString();

        }
    }
}
