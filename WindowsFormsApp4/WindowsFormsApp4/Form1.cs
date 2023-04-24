using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool platnost(string rodnecislo)
        {
            rodnecislo = maskedTextBox1.Text;
            int rodnecislovintu = 0;
            foreach(char znak in rodnecislo)
            {
                int pomocna = 1000000000;
                    if (znak != '/' && znak != '_')
                    {
                        rodnecislovintu += ((int)znak) * pomocna;
                        pomocna /= 10;
                    }
            }
            
            if(rodnecislovintu % 11 == 0 && (((rodnecislo[2] - 48 * 10) + rodnecislo[3] - 48) <= 12 || (((rodnecislo[2] - 48 * 10) + rodnecislo[3] - 48) <= 62 && ((rodnecislo[2] - 48 * 10) + rodnecislo[3] - 48) >= 51) && ((rodnecislo[4] - 48) * 10 + rodnecislo[5] - 48) <= 31))
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rodnecislo = maskedTextBox1.Text;
            label1.Text = platnost(rodnecislo).ToString();
        }
        
    }
}
