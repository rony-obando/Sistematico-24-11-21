using AppCore.Interfaces;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioPrestamo.Formularios
{
    public partial class CalendarioFrm : Form
    {
        List<int> borar=new List<int>();
        public ICalendarioService calendarioService;
        public CalendarioFrm(ICalendarioService calen)
        {
            calendarioService = calen;
            InitializeComponent();
        }

        private void CalendarioFrm_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(Enum.GetValues(typeof(Estado)).Cast<object>().ToArray());
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NewFrm newFrm = new NewFrm();
            newFrm.calendario = calendarioService;
            newFrm.ShowDialog();
            dgvMostrar.DataSource = borar;
            dgvMostrar.DataSource = calendarioService.FinAll();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = calendarioService.ViewFiltrados(cmbEstado.SelectedIndex);
        }
    }
}
