namespace Cerna_Nelson
{
    partial class Vehiculos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.PnlNavegacion = new System.Windows.Forms.Panel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnPrimero = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIDVehiculo = new System.Windows.Forms.Label();
            this.PnlNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(238, 233);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(336, 204);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(336, 233);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(238, 204);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(347, 91);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(100, 20);
            this.TxtModelo.TabIndex = 4;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(197, 91);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(100, 20);
            this.TxtMarca.TabIndex = 5;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(270, 129);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(100, 20);
            this.TxtYear.TabIndex = 6;
            // 
            // PnlNavegacion
            // 
            this.PnlNavegacion.Controls.Add(this.lblRegistro);
            this.PnlNavegacion.Controls.Add(this.BtnUltimo);
            this.PnlNavegacion.Controls.Add(this.BtnPrimero);
            this.PnlNavegacion.Controls.Add(this.BtnSiguiente);
            this.PnlNavegacion.Controls.Add(this.BtnAnterior);
            this.PnlNavegacion.Location = new System.Drawing.Point(180, 283);
            this.PnlNavegacion.Name = "PnlNavegacion";
            this.PnlNavegacion.Size = new System.Drawing.Size(277, 78);
            this.PnlNavegacion.TabIndex = 7;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(121, 32);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(40, 13);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "X de N";
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.Location = new System.Drawing.Point(205, 20);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(51, 37);
            this.BtnUltimo.TabIndex = 10;
            this.BtnUltimo.Text = ">l";
            this.BtnUltimo.UseVisualStyleBackColor = true;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click_1);
            // 
            // BtnPrimero
            // 
            this.BtnPrimero.Location = new System.Drawing.Point(19, 20);
            this.BtnPrimero.Name = "BtnPrimero";
            this.BtnPrimero.Size = new System.Drawing.Size(45, 37);
            this.BtnPrimero.TabIndex = 0;
            this.BtnPrimero.Text = "l<";
            this.BtnPrimero.UseVisualStyleBackColor = true;
            this.BtnPrimero.Click += new System.EventHandler(this.BtnPrimero_Click_1);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(156, 20);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(43, 37);
            this.BtnSiguiente.TabIndex = 9;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click_1);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.Location = new System.Drawing.Point(70, 20);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(48, 37);
            this.BtnAnterior.TabIndex = 8;
            this.BtnAnterior.Text = "<";
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // lblIDVehiculo
            // 
            this.lblIDVehiculo.AutoSize = true;
            this.lblIDVehiculo.Location = new System.Drawing.Point(308, 32);
            this.lblIDVehiculo.Name = "lblIDVehiculo";
            this.lblIDVehiculo.Size = new System.Drawing.Size(0, 13);
            this.lblIDVehiculo.TabIndex = 12;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 470);
            this.Controls.Add(this.lblIDVehiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlNavegacion);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Name = "Vehiculos";
            this.Text = "Registro_Veiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.PnlNavegacion.ResumeLayout(false);
            this.PnlNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Panel PnlNavegacion;
        private System.Windows.Forms.Button BtnPrimero;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIDVehiculo;
    }
}

