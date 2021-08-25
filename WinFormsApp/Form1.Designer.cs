
namespace WinFormsApp
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sueldoBasico = new System.Windows.Forms.TextBox();
            this.txt_antiguedad = new System.Windows.Forms.TextBox();
            this.txt_horasExtras = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo basico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antiguedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado";
            // 
            // txt_sueldoBasico
            // 
            this.txt_sueldoBasico.Location = new System.Drawing.Point(168, 76);
            this.txt_sueldoBasico.Name = "txt_sueldoBasico";
            this.txt_sueldoBasico.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldoBasico.TabIndex = 4;
            // 
            // txt_antiguedad
            // 
            this.txt_antiguedad.Location = new System.Drawing.Point(168, 106);
            this.txt_antiguedad.Name = "txt_antiguedad";
            this.txt_antiguedad.Size = new System.Drawing.Size(100, 20);
            this.txt_antiguedad.TabIndex = 5;
            // 
            // txt_horasExtras
            // 
            this.txt_horasExtras.Location = new System.Drawing.Point(168, 141);
            this.txt_horasExtras.Name = "txt_horasExtras";
            this.txt_horasExtras.Size = new System.Drawing.Size(100, 20);
            this.txt_horasExtras.TabIndex = 6;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(168, 212);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 7;
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(73, 176);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 8;
            this.btn_resultado.Text = "Calcular";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_horasExtras);
            this.Controls.Add(this.txt_antiguedad);
            this.Controls.Add(this.txt_sueldoBasico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo de sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sueldoBasico;
        private System.Windows.Forms.TextBox txt_antiguedad;
        private System.Windows.Forms.TextBox txt_horasExtras;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_resultado;
    }
}

