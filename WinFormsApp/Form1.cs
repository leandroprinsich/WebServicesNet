using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            var oMiServicioWeb = new ServiceReference1.ServiciosWebSoapClient();
            txt_resultado.Text = oMiServicioWeb.CalcularSueldo(
                Convert.ToDouble(txt_sueldoBasico.Text),
                Convert.ToDouble(txt_antiguedad.Text),
                Convert.ToDouble(txt_horasExtras.Text)
                ).ToString();
        }
    }
}
