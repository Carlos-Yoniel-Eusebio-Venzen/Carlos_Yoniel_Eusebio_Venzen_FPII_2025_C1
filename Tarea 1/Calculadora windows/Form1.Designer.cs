namespace Calculadora_windows
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonBorrarTodo = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonRaizCuadrada = new System.Windows.Forms.Button();
            this.buttonExponencial = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonIGual = new System.Windows.Forms.Button();
            this.buttonMasOMenos = new System.Windows.Forms.Button();
            this.buttonCero = new System.Windows.Forms.Button();
            this.buttonPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(13, 13);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(367, 36);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(73, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(133, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(73, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(133, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 51);
            this.button6.TabIndex = 4;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 51);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(73, 120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 51);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(133, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 51);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitar.Location = new System.Drawing.Point(133, 60);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(51, 51);
            this.buttonQuitar.TabIndex = 12;
            this.buttonQuitar.Text = "<-";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonBorrarTodo
            // 
            this.buttonBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarTodo.Location = new System.Drawing.Point(73, 60);
            this.buttonBorrarTodo.Name = "buttonBorrarTodo";
            this.buttonBorrarTodo.Size = new System.Drawing.Size(51, 51);
            this.buttonBorrarTodo.TabIndex = 11;
            this.buttonBorrarTodo.Text = "C";
            this.buttonBorrarTodo.UseVisualStyleBackColor = true;
            this.buttonBorrarTodo.Click += new System.EventHandler(this.buttonBorrarTodo_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(13, 60);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(51, 51);
            this.buttonBorrar.TabIndex = 10;
            this.buttonBorrar.Text = "CE";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonRaizCuadrada
            // 
            this.buttonRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaizCuadrada.Location = new System.Drawing.Point(269, 60);
            this.buttonRaizCuadrada.Name = "buttonRaizCuadrada";
            this.buttonRaizCuadrada.Size = new System.Drawing.Size(51, 51);
            this.buttonRaizCuadrada.TabIndex = 11;
            this.buttonRaizCuadrada.Tag = "√";
            this.buttonRaizCuadrada.Text = "√";
            this.buttonRaizCuadrada.UseVisualStyleBackColor = true;
            this.buttonRaizCuadrada.Click += new System.EventHandler(this.ClickOperador);
            // 
            // buttonExponencial
            // 
            this.buttonExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExponencial.Location = new System.Drawing.Point(329, 60);
            this.buttonExponencial.Name = "buttonExponencial";
            this.buttonExponencial.Size = new System.Drawing.Size(51, 51);
            this.buttonExponencial.TabIndex = 12;
            this.buttonExponencial.Tag = "²";
            this.buttonExponencial.Text = "x²";
            this.buttonExponencial.UseVisualStyleBackColor = true;
            this.buttonExponencial.Click += new System.EventHandler(this.ClickOperador);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(269, 120);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(51, 51);
            this.buttonDivision.TabIndex = 11;
            this.buttonDivision.Tag = "/";
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.ClickOperador);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicacion.Location = new System.Drawing.Point(329, 120);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(51, 51);
            this.buttonMultiplicacion.TabIndex = 12;
            this.buttonMultiplicacion.Tag = "X";
            this.buttonMultiplicacion.Text = "X";
            this.buttonMultiplicacion.UseVisualStyleBackColor = true;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.ClickOperador);
            // 
            // buttonSuma
            // 
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuma.Location = new System.Drawing.Point(269, 187);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(51, 51);
            this.buttonSuma.TabIndex = 11;
            this.buttonSuma.Tag = "+";
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.ClickOperador);
            // 
            // buttonResta
            // 
            this.buttonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResta.Location = new System.Drawing.Point(329, 187);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(51, 51);
            this.buttonResta.TabIndex = 12;
            this.buttonResta.Tag = "-";
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.ClickOperador);
            // 
            // buttonIGual
            // 
            this.buttonIGual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIGual.Location = new System.Drawing.Point(269, 250);
            this.buttonIGual.Name = "buttonIGual";
            this.buttonIGual.Size = new System.Drawing.Size(111, 51);
            this.buttonIGual.TabIndex = 11;
            this.buttonIGual.Text = "=";
            this.buttonIGual.UseVisualStyleBackColor = true;
            this.buttonIGual.Click += new System.EventHandler(this.buttonIGual_Click);
            // 
            // buttonMasOMenos
            // 
            this.buttonMasOMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasOMenos.Location = new System.Drawing.Point(13, 311);
            this.buttonMasOMenos.Name = "buttonMasOMenos";
            this.buttonMasOMenos.Size = new System.Drawing.Size(51, 51);
            this.buttonMasOMenos.TabIndex = 1;
            this.buttonMasOMenos.Text = "+/-";
            this.buttonMasOMenos.UseVisualStyleBackColor = true;
            this.buttonMasOMenos.Click += new System.EventHandler(this.buttonMasOMenos_Click);
            // 
            // buttonCero
            // 
            this.buttonCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCero.Location = new System.Drawing.Point(73, 311);
            this.buttonCero.Name = "buttonCero";
            this.buttonCero.Size = new System.Drawing.Size(51, 51);
            this.buttonCero.TabIndex = 2;
            this.buttonCero.Text = "0";
            this.buttonCero.UseVisualStyleBackColor = true;
            this.buttonCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonPunto
            // 
            this.buttonPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPunto.Location = new System.Drawing.Point(133, 311);
            this.buttonPunto.Name = "buttonPunto";
            this.buttonPunto.Size = new System.Drawing.Size(51, 51);
            this.buttonPunto.TabIndex = 3;
            this.buttonPunto.Text = ".";
            this.buttonPunto.UseVisualStyleBackColor = true;
            this.buttonPunto.Click += new System.EventHandler(this.buttonPunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 374);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonExponencial);
            this.Controls.Add(this.buttonIGual);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonRaizCuadrada);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonBorrarTodo);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonPunto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCero);
            this.Controls.Add(this.buttonMasOMenos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonBorrarTodo;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonRaizCuadrada;
        private System.Windows.Forms.Button buttonExponencial;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonIGual;
        private System.Windows.Forms.Button buttonMasOMenos;
        private System.Windows.Forms.Button buttonCero;
        private System.Windows.Forms.Button buttonPunto;
    }
}

