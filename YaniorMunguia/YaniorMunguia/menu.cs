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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Multiplos();
            formulario1.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Descuento();
            formulario1.Show();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Interes();
            formulario1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
