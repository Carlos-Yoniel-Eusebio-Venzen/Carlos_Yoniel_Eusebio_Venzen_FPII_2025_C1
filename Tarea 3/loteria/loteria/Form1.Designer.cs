namespace loteria
{
    partial class Form1
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
            this.boton = new System.Windows.Forms.Button();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblnumero3 = new System.Windows.Forms.Label();
            this.tablaJugadas = new System.Windows.Forms.DataGridView();
            this.lblJugador = new System.Windows.Forms.Label();
            this.tablaFrecuencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(52, 153);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(324, 172);
            this.boton.TabIndex = 0;
            this.boton.Text = "Jugar";
            this.boton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // lblnumero1
            // 
            this.lblnumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero1.Location = new System.Drawing.Point(12, 12);
            this.lblnumero1.MaximumSize = new System.Drawing.Size(120, 70);
            this.lblnumero1.MinimumSize = new System.Drawing.Size(120, 70);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(120, 70);
            this.lblnumero1.TabIndex = 1;
            this.lblnumero1.Text = "lblnumero1";
            this.lblnumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnumero2
            // 
            this.lblnumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero2.Location = new System.Drawing.Point(152, 12);
            this.lblnumero2.MaximumSize = new System.Drawing.Size(120, 70);
            this.lblnumero2.MinimumSize = new System.Drawing.Size(120, 70);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(120, 70);
            this.lblnumero2.TabIndex = 1;
            this.lblnumero2.Text = "lblnumero2";
            this.lblnumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnumero3
            // 
            this.lblnumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero3.Location = new System.Drawing.Point(291, 12);
            this.lblnumero3.MaximumSize = new System.Drawing.Size(120, 70);
            this.lblnumero3.MinimumSize = new System.Drawing.Size(120, 70);
            this.lblnumero3.Name = "lblnumero3";
            this.lblnumero3.Size = new System.Drawing.Size(120, 70);
            this.lblnumero3.TabIndex = 1;
            this.lblnumero3.Text = "lblnumero3";
            this.lblnumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablaJugadas
            // 
            this.tablaJugadas.AllowUserToResizeRows = false;
            this.tablaJugadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaJugadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadas.Location = new System.Drawing.Point(-2, 517);
            this.tablaJugadas.Name = "tablaJugadas";
            this.tablaJugadas.ReadOnly = true;
            this.tablaJugadas.Size = new System.Drawing.Size(670, 150);
            this.tablaJugadas.TabIndex = 2;
            // 
            // lblJugador
            // 
            this.lblJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJugador.Location = new System.Drawing.Point(174, 346);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(85, 21);
            this.lblJugador.TabIndex = 3;
            this.lblJugador.Text = "IDJugador";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablaFrecuencia
            // 
            this.tablaFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFrecuencia.Location = new System.Drawing.Point(417, 12);
            this.tablaFrecuencia.Name = "tablaFrecuencia";
            this.tablaFrecuencia.Size = new System.Drawing.Size(251, 499);
            this.tablaFrecuencia.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 665);
            this.Controls.Add(this.tablaFrecuencia);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.tablaJugadas);
            this.Controls.Add(this.lblnumero3);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.boton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFrecuencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.DataGridView tablaJugadas;
        private System.Windows.Forms.Label lblJugador;
        protected System.Windows.Forms.Label lblnumero3;
        private System.Windows.Forms.DataGridView tablaFrecuencia;
    }
}

