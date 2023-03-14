using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        int numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero =Convert.ToInt32(textBox1.Text);
            Negocio n = new Negocio();
            Datos d = new Datos();
            Negocio.Valor = numero;
            textBox2.Text = Convert.ToString(n.Resta());
            textBox3.Text = Convert.ToString(d.Suma());
        }
    }
}
