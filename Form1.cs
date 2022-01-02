using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string gkul = "qwe", xkul;
        public int gpar = 123, xpar;

        private void par_TextChanged(object sender, EventArgs e)
        {

        }

        //giris g = new giris();
        //string ad1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xkul = Convert.ToString(kul.Text);
            xpar = Convert.ToInt32(par.Text);


            if (gkul.Equals(xkul) && gpar == xpar)
            {
                giris gi = new giris();
                MessageBox.Show("sisteme girisiniz doğrudur sisteme geiriliyor...");
                gi.ShowDialog();
            }
            else
            {

                MessageBox.Show("hatalı giris...");

            }

        }
    }
}
