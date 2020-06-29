namespace Cerna_Nelson
{
    partial class Buscador_de_veiculos
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
            this.GrdBuscador = new System.Windows.Forms.DataGridView();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdBuscador
            // 
            this.GrdBuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdBuscador.Location = new System.Drawing.Point(25, 30);
            this.GrdBuscador.Name = "GrdBuscador";
            this.GrdBuscador.Size = new System.Drawing.Size(728, 525);
            this.GrdBuscador.TabIndex = 0;
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(183, 4);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.Size = new System.Drawing.Size(379, 20);
            this.Txtbuscar.TabIndex = 1;
            this.Txtbuscar.TextChanged += new System.EventHandler(this.Txtbuscar_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SELECCIONAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(617, 562);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR:";
            // 
            // Buscador_de_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.GrdBuscador);
            this.Name = "Buscador_de_veiculos";
            this.Text = "Buscador_de_veiculos";
            this.Load += new System.EventHandler(this.Buscador_de_veiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdBuscador;
        private System.Windows.Forms.TextBox Txtbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
    }
}