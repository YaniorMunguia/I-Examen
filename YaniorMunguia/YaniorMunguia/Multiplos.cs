using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaniorMunguia
{
    public partial class Multiplos : Form
    {
        public Multiplos()
        {
            InitializeComponent();
        }

        private static void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0)
                        lb2.Items.Add("Yanior ->" + i);
                    if (i % 5 == 0)
                        lb2.Items.Add("Munguia ->" + i);
                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            lb2.Items.Add("Yanior Munguia ->" + i);
                        }
                    }

                }
            }

        }
    }
}