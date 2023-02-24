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
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            double m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12;
            double i = 0.015, IS = 0, t = 1;
            double c = double.Parse(txb1.Text);
            IS = c * i * t;
            m1 = c + IS;
            lb1.Items.Add("Enero: -->" +IS);
            IS = m1 * i * t;
            m2 = m1 + IS;
            lb1.Items.Add("Febrero: -->" + IS);
            IS = m2 * i * t;
            m3 = m2 + IS;
            lb1.Items.Add("Marzo: -->" + IS);
            IS = m3 * i * t;
            m4 = m3 + IS;
            lb1.Items.Add("Abril: -->" + IS);
            IS = m4 * i * t;
            m5 = m4 + IS;
            lb1.Items.Add("Mayo: -->" + IS);
            IS = m5 * i * t;
            m6 = m5 + IS;
            lb1.Items.Add("Junio: -->" + IS);
            IS = m6 * i * t;
            m7 = m6 + IS;
            lb1.Items.Add("Julio: -->" + IS);
            IS = m7 * i * t;
            m8 = m7 + IS;
            lb1.Items.Add("Agosto: -->" + IS);
            IS = m8 * i * t;
            m9 = m8 + IS;
            lb1.Items.Add("Septiembre: -->" + IS);
            IS = m9 * i * t;
            m10 = m9 + IS;
            lb1.Items.Add("Ocubre: -->" + IS);
            IS = m10 * i * t;
            m11 = m10 + IS;
            lb1.Items.Add("Noviembre: -->" + IS);
            IS = m11 * i * t;
            m12 = m11 + IS;
            lb1.Items.Add("Diciembre: -->" + IS);
           

        }

       
    }
}
