using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Enums;
using AppCore.Interfaces;


namespace CalendarioPrestamo.Formularios
{
    public partial class NewFrm : Form
    {
        public ICalendarioService calendario;
        public NewFrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                CalenPrestamo calen = new CalenPrestamo()
                {
                    FechaPago = dateTimePicker1.Value,
                    Estado = (Estado)estado.SelectedIndex,
                    PrincipalPagado = princpagado.Value,
                    InteresPagado = interpagado.Value,
                    CuotaPagada = cuotpagada.Value,
                    Tasa = tasa.Value,
                    FechaVencimiento = fechavencimientos.Value,
                    MontoPrestamo = monto.Value,
                    Terminos = terminos.Value
                };
                calendario.Add(calen);
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void canc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
