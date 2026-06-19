namespace SistemaHistorialVentasProyectoFinal
{
    partial class frmListarHistorialVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHistorialVentas = new System.Windows.Forms.DataGridView();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCalcularGanancias = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTelaMasVendida = new System.Windows.Forms.Button();
            this.btnColorMásVendido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialVentas
            // 
            this.dgvHistorialVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialVentas.EnableHeadersVisualStyles = false;
            this.dgvHistorialVentas.Location = new System.Drawing.Point(-1, 72);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(216)))));
            this.dgvHistorialVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorialVentas.RowTemplate.Height = 24;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(800, 285);
            this.dgvHistorialVentas.TabIndex = 0;
            this.dgvHistorialVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVentas_CellDoubleClick);
            // 
            // lblTítulo
            // 
            this.lblTítulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTítulo.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(12, 9);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(434, 45);
            this.lblTítulo.TabIndex = 1;
            this.lblTítulo.Text = "Historial de ventas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(629, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 40);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCalcularGanancias
            // 
            this.btnCalcularGanancias.BackColor = System.Drawing.Color.White;
            this.btnCalcularGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularGanancias.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCalcularGanancias.FlatAppearance.BorderSize = 2;
            this.btnCalcularGanancias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCalcularGanancias.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularGanancias.Location = new System.Drawing.Point(430, 359);
            this.btnCalcularGanancias.Name = "btnCalcularGanancias";
            this.btnCalcularGanancias.Size = new System.Drawing.Size(154, 68);
            this.btnCalcularGanancias.TabIndex = 19;
            this.btnCalcularGanancias.Text = "Calcular Ganancias";
            this.btnCalcularGanancias.UseVisualStyleBackColor = false;
            this.btnCalcularGanancias.Click += new System.EventHandler(this.btnCalcularGanancias_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTelaMasVendida
            // 
            this.btnTelaMasVendida.BackColor = System.Drawing.Color.White;
            this.btnTelaMasVendida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaMasVendida.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTelaMasVendida.FlatAppearance.BorderSize = 2;
            this.btnTelaMasVendida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTelaMasVendida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaMasVendida.Location = new System.Drawing.Point(220, 359);
            this.btnTelaMasVendida.Name = "btnTelaMasVendida";
            this.btnTelaMasVendida.Size = new System.Drawing.Size(154, 68);
            this.btnTelaMasVendida.TabIndex = 20;
            this.btnTelaMasVendida.Text = "Tela más vendida";
            this.btnTelaMasVendida.UseVisualStyleBackColor = false;
            this.btnTelaMasVendida.Click += new System.EventHandler(this.btnTelaMasVendida_Click);
            // 
            // btnColorMásVendido
            // 
            this.btnColorMásVendido.BackColor = System.Drawing.Color.White;
            this.btnColorMásVendido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorMásVendido.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnColorMásVendido.FlatAppearance.BorderSize = 2;
            this.btnColorMásVendido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnColorMásVendido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorMásVendido.Location = new System.Drawing.Point(17, 359);
            this.btnColorMásVendido.Name = "btnColorMásVendido";
            this.btnColorMásVendido.Size = new System.Drawing.Size(154, 68);
            this.btnColorMásVendido.TabIndex = 21;
            this.btnColorMásVendido.Text = "Color más vendido";
            this.btnColorMásVendido.UseVisualStyleBackColor = false;
            this.btnColorMásVendido.Click += new System.EventHandler(this.btnColorMásVendido_Click);
            // 
            // frmListarHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColorMásVendido);
            this.Controls.Add(this.btnTelaMasVendida);
            this.Controls.Add(this.btnCalcularGanancias);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.dgvHistorialVentas);
            this.Name = "frmListarHistorialVentas";
            this.Text = "frmListarHistorialVentas";
            this.Load += new System.EventHandler(this.frmListarHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCalcularGanancias;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTelaMasVendida;
        private System.Windows.Forms.Button btnColorMásVendido;
    }
}