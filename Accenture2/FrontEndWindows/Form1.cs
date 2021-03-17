using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndWindows
{
    public partial class Form1 : Form
    {
        EducacionIT.Empleado empleado = new EducacionIT.Empleado();
        public Form1()
        {
            InitializeComponent();
            EducacionIT.Empleado.Aumento = 5000;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EducacionIT.Pais pais = new EducacionIT.Pais();
            
            empleado.Dni = Convert.ToInt32(txtDni.Text);
            empleado.Apellido = txtApellido.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.FechaIngreso = dtpFechaIngreso.Value;
            empleado.Sueldo = Convert.ToDouble(txtSueldo.Text);
            empleado.Pais = pais; 
            lblDatos.Text = empleado.TraerDatos();
        }

        private void btnSueldoFinal_Click(object sender, EventArgs e)
        {
            lblSueldoFinal.Text = empleado.TraerSueldoFinal().ToString();
        }
    }
}
