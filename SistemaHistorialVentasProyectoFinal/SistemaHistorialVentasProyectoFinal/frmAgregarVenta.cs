using Microsoft.VisualBasic.ApplicationServices;
using SistemaHistorialVentasProyectoFinal.Models;
using SistemaHistorialVentasProyectoFinal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHistorialVentasProyectoFinal
{
    public partial class frmAgregarVenta : Form
    {
        static int CodigoActual = 0;
        public frmAgregarVenta()
        {
            InitializeComponent();
            lblCodigoVentaAuto.Text = CodigoActual.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string genero;
            try
            {
                if (string.IsNullOrWhiteSpace(lblCodigoVentaAuto.Text))
                    throw new Exception("Error en el codigo, el código es obligatorio.");

                if (rbFemenino.Checked)
                {
                    genero = "femenino";
                }
                else if (rbMasculino.Checked)
                {
                    genero = "masculino";
                }
                else
                {
                    genero = null;
                }

                var Venta = new Ventas
                {
                    Codigo = CodigoActual,
                    Cliente = txtNombreCliente.Text,
                    Talla = cbTallaPantalon.SelectedItem.ToString(),
                    Tela = cbTelaPantalon.SelectedItem.ToString(),
                    Color = cbColorPantalon.SelectedItem.ToString(),
                    Cantidad = int.Parse(txtCantidad.Text),
                    Precio = decimal.Parse(txtPrecio.Text),
                    Genero = genero

                };

                FrmMain.Historial.Add(Venta);
                CodigoActual++;

                MessageBox.Show("Venta registrada con exito :)\n", "Éxito :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Cantidad o precio con formato incorrecto.\n" + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAgregarVenta_Load(object sender, EventArgs e)
        {
            cbColorPantalon.SelectedIndexChanged += SeleccionCambio;
            rbFemenino.CheckedChanged += SeleccionCambio;
            rbMasculino.CheckedChanged += SeleccionCambio;

        }

        private void SeleccionCambio(object sender, EventArgs e)
        {
            mostrarImagen();
        }

        private void mostrarImagen()
        {
            string color = cbColorPantalon.SelectedItem?.ToString();
            string genero = rbMasculino.Checked ? "masculino" : rbFemenino.Checked ? "femenino" : null;

            if (string.IsNullOrEmpty(color) || string.IsNullOrEmpty(genero))
            {
                pbImagenes.Image = null;
                return;
            }

            string ClaveImagen = $"{color}_{genero}.png";

            if (listaImagenes.Images.ContainsKey(ClaveImagen))
            {
                pbImagenes.Image = listaImagenes.Images[ClaveImagen];
                pbImagenes.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbImagenes.Image = null;

            }
        }
    }
}
