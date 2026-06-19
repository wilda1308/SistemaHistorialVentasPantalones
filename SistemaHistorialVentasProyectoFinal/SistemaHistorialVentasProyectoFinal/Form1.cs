using SistemaHistorialVentasProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHistorialVentasProyectoFinal
{
    public partial class FrmMain: Form
    {
        internal static List<Ventas> Historial = new List<Ventas>();

        public FrmMain()
        {
            InitializeComponent();
        }
        

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmAgregarVenta();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmListarHistorialVentas();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmHome();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
