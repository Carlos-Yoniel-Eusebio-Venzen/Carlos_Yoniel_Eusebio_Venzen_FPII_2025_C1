namespace loteria
{
    partial class Form1
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.tablaHistorial = new System.Windows.Forms.DataGridView();
            this.tablaJugadores = new System.Windows.Forms.DataGridView();
            this.tablaResultados = new System.Windows.Forms.DataGridView();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero1.Location = new System.Drawing.Point(33, 35);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(120, 80);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "lblNumero1";
            this.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero2
            // 
            this.lblNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero2.Location = new System.Drawing.Point(213, 35);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(120, 80);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "lblNumero2";
            this.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero3
            // 
            this.lblNumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumero3.Location = new System.Drawing.Point(376, 35);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(120, 80);
            this.lblNumero3.TabIndex = 2;
            this.lblNumero3.Text = "lblNumero3";
            this.lblNumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablaHistorial
            // 
            this.tablaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHistorial.Location = new System.Drawing.Point(1, 538);
            this.tablaHistorial.Name = "tablaHistorial";
            this.tablaHistorial.Size = new System.Drawing.Size(953, 150);
            this.tablaHistorial.TabIndex = 3;
            // 
            // tablaJugadores
            // 
            this.tablaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadores.Location = new System.Drawing.Point(746, 0);
            this.tablaJugadores.Name = "tablaJugadores";
            this.tablaJugadores.Size = new System.Drawing.Size(208, 532);
            this.tablaJugadores.TabIndex = 4;
            // 
            // tablaResultados
            // 
            this.tablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResultados.Location = new System.Drawing.Point(1, 382);
            this.tablaResultados.Name = "tablaResultados";
            this.tablaResultados.Size = new System.Drawing.Size(739, 150);
            this.tablaResultados.TabIndex = 5;
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidadJugadores.Location = new System.Drawing.Point(184, 336);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(173, 23);
            this.lblCantidadJugadores.TabIndex = 6;
            this.lblCantidadJugadores.Text = "lblCantidadJugadores";
            this.lblCantidadJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(302, 155);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(194, 161);
            this.btnAgregarJugador.TabIndex = 7;
            this.btnAgregarJugador.Text = "button1";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(33, 155);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(194, 161);
            this.btnJugar.TabIndex = 8;
            this.btnJugar.Text = "button2";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(542, 172);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 30);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "Escribe el nombre";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(542, 226);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(198, 30);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.Text = "Numero de apuesta";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(542, 286);
            this.txtDinero.Multiline = true;
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(198, 30);
            this.txtDinero.TabIndex = 11;
            this.txtDinero.Text = "Dinero apostado";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(955, 688);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.tablaResultados);
            this.Controls.Add(this.tablaJugadores);
            this.Controls.Add(this.tablaHistorial);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblNumero3;
        private System.Windows.Forms.DataGridView tablaHistorial;
        private System.Windows.Forms.DataGridView tablaJugadores;
        private System.Windows.Forms.DataGridView tablaResultados;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDinero;
    }
}