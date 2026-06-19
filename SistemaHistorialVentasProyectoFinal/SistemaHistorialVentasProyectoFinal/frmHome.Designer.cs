namespace SistemaHistorialVentasProyectoFinal
{
    partial class frmHome
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
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Picture1Informacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1Informacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(34, 36);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(387, 100);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Sistema de historial de ventas";
            // 
            // lblInformacion
            // 
            this.lblInformacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(36, 154);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(362, 95);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Solo con acciones pequeñas como ingresar datos almacenaras información y listarla" +
    ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::SistemaHistorialVentasProyectoFinal.Properties.Resources.Imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(427, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Picture1Informacion
            // 
            this.Picture1Informacion.Enabled = false;
            this.Picture1Informacion.Image = global::SistemaHistorialVentasProyectoFinal.Properties.Resources.Home__2_;
            this.Picture1Informacion.Location = new System.Drawing.Point(63, 287);
            this.Picture1Informacion.Name = "Picture1Informacion";
            this.Picture1Informacion.Size = new System.Drawing.Size(295, 173);
            this.Picture1Informacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture1Informacion.TabIndex = 2;
            this.Picture1Informacion.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(223)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Picture1Informacion);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblTítulo);
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1Informacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.PictureBox Picture1Informacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}