using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Pruba_Act_4ta_2do_semestre_en_C_
{
    public partial class Form1 : Form
    {
        private Azul azul;
        private Rojo rojo;
        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            azul = new Azul();
            rojo = new Rojo();
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {

            
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
           
           string NewLine = lblResultado.Text;
        }

        private void btnAzul_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            azul.SeleccionarColor();
            lblResultado.Text = "El color azul es magnifico, queda bien con todo" + Environment.NewLine;

            Icolores colores = azul;
            colores.Elejir();
            lblResultado.Text += "para que usaras el color azul?";
        }

        private void btnRojo_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            rojo.SeleccionarColor();
            lblResultado.Text = "El color Rojo es magnifico, queda bien con todo" + Environment.NewLine;

            Icolores Colores = rojo;
            Colores.Elejir();
            lblResultado.Text += "para que usaras el color Rojo?";
        }
    }

}
