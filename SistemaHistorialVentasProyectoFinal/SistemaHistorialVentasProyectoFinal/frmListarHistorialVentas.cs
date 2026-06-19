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
    public partial class frmListarHistorialVentas: Form
    {
        public frmListarHistorialVentas()
        {
            InitializeComponent();
        }

        private void frmListarHistorialVentas_Load(object sender, EventArgs e)
        {
            dgvHistorialVentas.DataSource = null;
            dgvHistorialVentas.DataSource = FrmMain.Historial;
        }

        private void dgvHistorialVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string nuevoNombreCliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre del cliente", "Cambiar Nombre del cliente");
                dgvHistorialVentas.Rows[e.RowIndex].Cells[1].Value = nuevoNombreCliente;
            }
            else if (e.ColumnIndex == 2)
            {
                string nuevaTallaPantalon = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva talla de pantalón", "Cambiar tallaje de pantalón");
                dgvHistorialVentas.Rows[e.RowIndex].Cells[2].Value = nuevaTallaPantalon;
            }
            else if (e.ColumnIndex == 3)
            {
                string nuevaTelaPantalon = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva tela de pantalón", "Cambiar tela de pantalón");
                dgvHistorialVentas.Rows[e.RowIndex].Cells[3].Value = nuevaTelaPantalon;
            }
            else if (e.ColumnIndex == 4)
            {
                string nuevaColorPantalon = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo color de pantalón", "Cambiar color de pantalón");
                dgvHistorialVentas.Rows[e.RowIndex].Cells[4].Value = nuevaColorPantalon;
            }
            else if (e.ColumnIndex == 5)
            {
                string nuevaCantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nueva cantidad", "Cambiar cantidad");
                dgvHistorialVentas.Rows[e.RowIndex].Cells[5].Value = nuevaCantidad;
            }
            else if (e.ColumnIndex == 6)
            {
                string nuevoPrecio = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo precio", "Cambiar precio");
                dgvHistorialVentas.Rows[e.RowIndex].Cells[6].Value = nuevoPrecio;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHistorialVentas.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para eliminar del historial de ventas.", "No se pueden eliminar datos :(");
                return;
            }
            var Venta = (Ventas)dgvHistorialVentas.CurrentRow.DataBoundItem;
            if(MessageBox.Show($"¿Desea eliminar la venta {Venta.Codigo}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmMain.Historial.Remove(Venta);
                frmListarHistorialVentas_Load(null, null);
            }
        }

        private void btnCalcularGanancias_Click(object sender, EventArgs e)
        {
            try
            {
                double Ganancias = 0;
                int columnaTotal = 8;
                foreach (DataGridViewRow fila in dgvHistorialVentas.Rows)
                {
                    if (fila.IsNewRow) continue;
                    if (fila.Cells[columnaTotal].Value != null)
                    {
                        Ganancias += Convert.ToDouble(fila.Cells[columnaTotal].Value);
                    }
                }

                MessageBox.Show($"Ganancia total: {Ganancias}", "Calculo de ganacias de todas las ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTelaMasVendida_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> TelaCounts = new Dictionary<string, int>();
            foreach(DataGridViewRow fila in dgvHistorialVentas.Rows)
            {
                if (fila.IsNewRow) continue;

                string tela = fila.Cells["Tela"].Value?.ToString();
                int cantidad = 0;

                int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantidad);

                if (!string.IsNullOrEmpty(tela))
                {
                    if (TelaCounts.ContainsKey(tela))
                    {
                        TelaCounts[tela] += cantidad;
                    }
                    else TelaCounts[tela] = cantidad;
                }
            }
            
            if(TelaCounts.Count == 0)
            {
                MessageBox.Show("No hay datos suficientes para calcular la tela más vendida.");
                return;
            }

            var telaMasVendida = TelaCounts.OrderByDescending(t => t.Value).First(); //Buscar la tela más vendida dentro el conteo que realizamos previamente.

            MessageBox.Show($"La tela más vendida es: {telaMasVendida.Key} \nY con una cantidad total de: {telaMasVendida.Value} telas vendidas.", "\t\t\t\t***TELA MÁS VENDIDA***", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnColorMásVendido_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> ColorCounts = new Dictionary<string, int>();
            foreach(DataGridViewRow fila in dgvHistorialVentas.Rows)
            {
                string color = fila.Cells["Color"].Value?.ToString();
                int cantidad = 0;

                int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantidad);

                if (!string.IsNullOrEmpty(color))
                {
                    if (ColorCounts.ContainsKey(color))
                    {
                        ColorCounts[color] += cantidad;
                    }
                    else ColorCounts[color] = cantidad;
                }
            }
            if(ColorCounts.Count == 0)
            {
                MessageBox.Show("No hay datos suficientes para calcular el color más vendido.");
                return;
            }
            var colorMasVendido = ColorCounts.OrderByDescending(t => t.Value).First();
            MessageBox.Show($"El color más vendido es: {colorMasVendido.Key} \nY con una cantidad total de: {colorMasVendido.Value} colores vendidos.", "\t\t\t\t***COLOR MÁS VENDIDO***", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
