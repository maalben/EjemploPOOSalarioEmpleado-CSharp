namespace EjemploPOOSalarioEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblpagosalud = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Salario Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(135, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa las horas trabajadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(135, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el valor de cada hora:";
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txthorastrabajadas.Location = new System.Drawing.Point(439, 109);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(82, 53);
            this.txthorastrabajadas.TabIndex = 3;
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtvalorhora.Location = new System.Drawing.Point(439, 172);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(190, 53);
            this.txtvalorhora.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btncalcular.Location = new System.Drawing.Point(265, 258);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(210, 53);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lbltotal.Location = new System.Drawing.Point(60, 390);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(104, 51);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "total";
            this.lbltotal.Visible = false;
            // 
            // lblpagosalud
            // 
            this.lblpagosalud.AutoSize = true;
            this.lblpagosalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblpagosalud.Location = new System.Drawing.Point(60, 339);
            this.lblpagosalud.Name = "lblpagosalud";
            this.lblpagosalud.Size = new System.Drawing.Size(238, 51);
            this.lblpagosalud.TabIndex = 7;
            this.lblpagosalud.Text = "Pago salud";
            this.lblpagosalud.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpagosalud);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblpagosalud;
    }
}

