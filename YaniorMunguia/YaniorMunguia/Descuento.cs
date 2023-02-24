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
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void bt1_Click(object sender, EventArgs e)
        {
            string n1 = Convert.ToString(txb1.Text);
            string n2 = Convert.ToString(txb2.Text);
            string n3 = Convert.ToString(txb3.Text);


            double pr1 = Convert.ToDouble(txbp1.Text);
            double cn1 = Convert.ToDouble(txbc1.Text);
            double pr2 = Convert.ToDouble(txbp2.Text);
            double cn2 = Convert.ToDouble(txbc2.Text);
            double pr3 = Convert.ToDouble(txbp3.Text);
            double cn3 = Convert.ToDouble(txbc3.Text);

            double resultado = await facturaAsync(pr1, cn1, pr2, cn2, pr3, cn3);
            double des = resultado * 0.15;
            double total = resultado - des;

            lb1.Items.Add(n1);
            lb1.Items.Add(n2);
            lb1.Items.Add(n3);

            lb1.Items.Add("SubTotal =  " + resultado);
            lb1.Items.Add("Descuento = " + des);
            lb1.Items.Add("Total =     " + total);

        }
        private async Task<double> facturaAsync(double p1, double c1, double p2, double c2, double p3, double c3)
        {
            double Subtotal = await Task.Run(() =>
           
           {
               double des, total;
                return ((p1 * c1) + (p2 * c2) + (p3 * c3));
               des = Subtotal * 0.15;
               total = Subtotal - des;

            });
           
            return Subtotal;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
