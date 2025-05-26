using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silnia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(stopien.Text);
            int silnia = 1;
            //licze silnie
            for(int i = 1; i <= s; i++)
            {
                silnia *= i;
            }
            wynik.Text = silnia.ToString();
        }
    }
}
