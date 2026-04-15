namespace loteria
{
    partial class Form2
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
            this.boton_Click = new System.Windows.Forms.Button();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblnumero3 = new System.Windows.Forms.Label();
            this.tablaJugadas = new System.Windows.Forms.DataGridView();
            this.tablaFrecuencia = new System.Windows.Forms.DataGridView();
            this.lblJugador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_Click
            // 
            this.boton_Click.Location = new System.Drawing.Point(129, 197);
            this.boton_Click.Name = "boton_Click";
            this.boton_Click.Size = new System.Drawing.Size(332, 211);
            this.boton_Click.TabIndex = 0;
            this.boton_Click.Text = "boton_Click";
            this.boton_Click.UseVisualStyleBackColor = true;
            // 
            // lblnumero1
            // 
            this.lblnumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero1.Location = new System.Drawing.Point(12, 29);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(150, 100);
            this.lblnumero1.TabIndex = 1;
            this.lblnumero1.Text = "lblnumero1";
            this.lblnumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnumero2
            // 
            this.lblnumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero2.Location = new System.Drawing.Point(198, 29);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(150, 100);
            this.lblnumero2.TabIndex = 2;
            this.lblnumero2.Text = "lblnumero2";
            this.lblnumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnumero3
            // 
            this.lblnumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero3.Location = new System.Drawing.Point(395, 29);
            this.lblnumero3.Name = "lblnumero3";
            this.lblnumero3.Size = new System.Drawing.Size(150, 100);
            this.lblnumero3.TabIndex = 3;
            this.lblnumero3.Text = "lblnumero3";
            this.lblnumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablaJugadas
            // 
            this.tablaJugadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaJugadas.Location = new System.Drawing.Point(0, 505);
            this.tablaJugadas.Name = "tablaJugadas";
            this.tablaJugadas.Size = new System.Drawing.Size(799, 172);
            this.tablaJugadas.TabIndex = 4;
            // 
            // tablaFrecuencia
            // 
            this.tablaFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFrecuencia.Location = new System.Drawing.Point(579, 12);
            this.tablaFrecuencia.Name = "tablaFrecuencia";
            this.tablaFrecuencia.Size = new System.Drawing.Size(220, 487);
            this.tablaFrecuencia.TabIndex = 5;
            // 
            // lblJugador
            // 
            this.lblJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJugador.Location = new System.Drawing.Point(227, 424);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(131, 23);
            this.lblJugador.TabIndex = 6;
            this.lblJugador.Text = "lblJugador";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.tablaFrecuencia);
            this.Controls.Add(this.tablaJugadas);
            this.Controls.Add(this.lblnumero3);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.boton_Click);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tablaJugadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFrecuencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_Click;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label lblnumero3;
        private System.Windows.Forms.DataGridView tablaJugadas;
        private System.Windows.Forms.DataGridView tablaFrecuencia;
        private System.Windows.Forms.Label lblJugador;
    }
}