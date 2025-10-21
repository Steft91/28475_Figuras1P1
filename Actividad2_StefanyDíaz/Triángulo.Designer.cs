namespace Actividad2_StefanyDíaz
{
    partial class Triángulo
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
            this.txtBxAlturaTri = new System.Windows.Forms.TextBox();
            this.txtBxBaseTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcularTri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxAlturaTri
            // 
            this.txtBxAlturaTri.Location = new System.Drawing.Point(271, 203);
            this.txtBxAlturaTri.Name = "txtBxAlturaTri";
            this.txtBxAlturaTri.Size = new System.Drawing.Size(100, 22);
            this.txtBxAlturaTri.TabIndex = 13;
            // 
            // txtBxBaseTri
            // 
            this.txtBxBaseTri.Location = new System.Drawing.Point(271, 150);
            this.txtBxBaseTri.Name = "txtBxBaseTri";
            this.txtBxBaseTri.Size = new System.Drawing.Size(100, 22);
            this.txtBxBaseTri.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(197, 203);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 16);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(197, 150);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(42, 16);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Base:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(164, 100);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(310, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y perímetro de un triángulo equilátero";
            this.lblTittle.Click += new System.EventHandler(this.lblTittle_Click);
            // 
            // btnCalcularTri
            // 
            this.btnCalcularTri.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcularTri.Location = new System.Drawing.Point(271, 276);
            this.btnCalcularTri.Name = "btnCalcularTri";
            this.btnCalcularTri.Size = new System.Drawing.Size(112, 45);
            this.btnCalcularTri.TabIndex = 7;
            this.btnCalcularTri.Text = "Calcular";
            this.btnCalcularTri.UseVisualStyleBackColor = false;
            this.btnCalcularTri.Click += new System.EventHandler(this.btnCalcularTri_Click);
            // 
            // Triángulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxAlturaTri);
            this.Controls.Add(this.txtBxBaseTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcularTri);
            this.Name = "Triángulo";
            this.Text = "Triángulo";
            this.Load += new System.EventHandler(this.Triángulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxAlturaTri;
        private System.Windows.Forms.TextBox txtBxBaseTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcularTri;
    }
}