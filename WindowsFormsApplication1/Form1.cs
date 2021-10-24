using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            if (a == b && b == c)
            {
                MessageBox.Show("Eşkenar Üçgen", "Üçgen Çeşidi");
            }
            else if (a != b && b != c)
            {
                MessageBox.Show("Çeşitkenar Üçgen", "Üçgen Çeşidi");
            }
            else
            {
                MessageBox.Show("İkizkenar Üçgen", "Üçgen Çeşidi");
            }

        }
    }
}
