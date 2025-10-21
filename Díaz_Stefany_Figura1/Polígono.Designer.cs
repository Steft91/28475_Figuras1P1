namespace Actividad2_StefanyDíaz
{
    partial class Polígono
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
            this.txtBxNumLados = new System.Windows.Forms.TextBox();
            this.txtBxLadoPoli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcPoli = new System.Windows.Forms.Button();
            this.txtBxApotema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxNumLados
            // 
            this.txtBxNumLados.Location = new System.Drawing.Point(243, 206);
            this.txtBxNumLados.Name = "txtBxNumLados";
            this.txtBxNumLados.Size = new System.Drawing.Size(100, 22);
            this.txtBxNumLados.TabIndex = 13;
            // 
            // txtBxLadoPoli
            // 
            this.txtBxLadoPoli.Location = new System.Drawing.Point(243, 153);
            this.txtBxLadoPoli.Name = "txtBxLadoPoli";
            this.txtBxLadoPoli.Size = new System.Drawing.Size(100, 22);
            this.txtBxLadoPoli.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(161, 209);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(76, 16);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Num Lados";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(169, 153);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(41, 16);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Lado:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(179, 92);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(249, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y perímetro de un polígono";
            // 
            // btnCalcPoli
            // 
            this.btnCalcPoli.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcPoli.Location = new System.Drawing.Point(243, 304);
            this.btnCalcPoli.Name = "btnCalcPoli";
            this.btnCalcPoli.Size = new System.Drawing.Size(112, 45);
            this.btnCalcPoli.TabIndex = 7;
            this.btnCalcPoli.Text = "Calcular";
            this.btnCalcPoli.UseVisualStyleBackColor = false;
            this.btnCalcPoli.Click += new System.EventHandler(this.btnCalcPoli_Click);
            // 
            // txtBxApotema
            // 
            this.txtBxApotema.Location = new System.Drawing.Point(243, 255);
            this.txtBxApotema.Name = "txtBxApotema";
            this.txtBxApotema.Size = new System.Drawing.Size(100, 22);
            this.txtBxApotema.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apotema";
            // 
            // Polígono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxApotema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxNumLados);
            this.Controls.Add(this.txtBxLadoPoli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcPoli);
            this.Name = "Polígono";
            this.Text = "Polígono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNumLados;
        private System.Windows.Forms.TextBox txtBxLadoPoli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcPoli;
        private System.Windows.Forms.TextBox txtBxApotema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}