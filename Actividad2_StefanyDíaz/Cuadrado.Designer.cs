namespace Actividad2_StefanyDíaz
{
    partial class Cuadrado
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
            this.txtBxLado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcCuadrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxLado
            // 
            this.txtBxLado.Location = new System.Drawing.Point(340, 170);
            this.txtBxLado.Name = "txtBxLado";
            this.txtBxLado.Size = new System.Drawing.Size(100, 22);
            this.txtBxLado.TabIndex = 12;
            this.txtBxLado.TextChanged += new System.EventHandler(this.txtBxBase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(266, 170);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(41, 16);
            this.lblLado.TabIndex = 9;
            this.lblLado.Text = "Lado:";
            this.lblLado.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(276, 109);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(254, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y perímetro de un cuadrado";
            this.lblTittle.Click += new System.EventHandler(this.lblTittle_Click);
            // 
            // btnCalcCuadrado
            // 
            this.btnCalcCuadrado.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcCuadrado.Location = new System.Drawing.Point(328, 243);
            this.btnCalcCuadrado.Name = "btnCalcCuadrado";
            this.btnCalcCuadrado.Size = new System.Drawing.Size(112, 45);
            this.btnCalcCuadrado.TabIndex = 7;
            this.btnCalcCuadrado.Text = "Calcular";
            this.btnCalcCuadrado.UseVisualStyleBackColor = false;
            this.btnCalcCuadrado.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxLado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcCuadrado);
            this.Name = "Cuadrado";
            this.Text = "Cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxLado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcCuadrado;
    }
}