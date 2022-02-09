using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            int v = 1;
            for(int p = 1; p <= n; p++)
            {
                v *= a;
            }
            label1.Text = v.ToString();
        }
    }
}
