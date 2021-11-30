using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cmascota Mascotas = new Cmascota();
        private void Registrar_Click(object sender, EventArgs e)
        {
            Mascotas.nombremas = Nm.Text;
            Mascotas.edadmas = Convert.ToInt32(Em.Text);
            Mascotas.tipomas = Tm.Text;
            Mascotas.raza = Ra.Text;
            Mascotas.masfer = Mf.Text;
            Mascotas.vauno = Vu.Text;
            Mascotas.vados = Vd.Text;
            Mascotas.vatres = Vt.Text;

            Nm.Text = "";
            Em.Text = "";
            Tm.Text = "";
            Ra.Text = "";
            Mf.Text = "";
            Vu.Text = "";
            Vd.Text = "";
            Vt.Text = "";
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            String resultado = "Nombre/mascota: "+ Mascotas.nombremas + "Edad/mascota: " + Mascotas.edadmas + "Tipo/mascota: " + Mascotas.tipomas + "Raza/mascota: " + Mascotas.raza + "Mascota/enferma: " + Mascotas.masfer + "Vacuna#1: " + Mascotas.vauno + "Vacuna#2: " + Mascotas.vados + "Vacuna#3: " + Mascotas.vatres;
            MessageBox.Show(resultado);
        }
    }
}
