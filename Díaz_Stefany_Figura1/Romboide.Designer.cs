namespace Actividad2_StefanyDíaz
{
    partial class Romboide
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
            this.txtBxAlturaRomboide = new System.Windows.Forms.TextBox();
            this.txtBxBaseRomboide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcRomboide = new System.Windows.Forms.Button();
            this.txtBxLadoRomboide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxAlturaRomboide
            // 
            this.txtBxAlturaRomboide.Location = new System.Drawing.Point(204, 185);
            this.txtBxAlturaRomboide.Name = "txtBxAlturaRomboide";
            this.txtBxAlturaRomboide.Size = new System.Drawing.Size(100, 22);
            this.txtBxAlturaRomboide.TabIndex = 13;
            // 
            // txtBxBaseRomboide
            // 
            this.txtBxBaseRomboide.Location = new System.Drawing.Point(204, 145);
            this.txtBxBaseRomboide.Name = "txtBxBaseRomboide";
            this.txtBxBaseRomboide.Size = new System.Drawing.Size(100, 22);
            this.txtBxBaseRomboide.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(130, 185);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 16);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Altura";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(130, 145);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(42, 16);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Base:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(140, 84);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(254, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y perímetro de un romboide";
            this.lblTittle.Click += new System.EventHandler(this.lblTittle_Click);
            // 
            // btnCalcRomboide
            // 
            this.btnCalcRomboide.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcRomboide.Location = new System.Drawing.Point(204, 271);
            this.btnCalcRomboide.Name = "btnCalcRomboide";
            this.btnCalcRomboide.Size = new System.Drawing.Size(112, 45);
            this.btnCalcRomboide.TabIndex = 7;
            this.btnCalcRomboide.Text = "Calcular";
            this.btnCalcRomboide.UseVisualStyleBackColor = false;
            this.btnCalcRomboide.Click += new System.EventHandler(this.btnCalcRomboide_Click);
            // 
            // txtBxLadoRomboide
            // 
            this.txtBxLadoRomboide.Location = new System.Drawing.Point(204, 223);
            this.txtBxLadoRomboide.Name = "txtBxLadoRomboide";
            this.txtBxLadoRomboide.Size = new System.Drawing.Size(100, 22);
            this.txtBxLadoRomboide.TabIndex = 15;
            this.txtBxLadoRomboide.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Romboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxLadoRomboide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxAlturaRomboide);
            this.Controls.Add(this.txtBxBaseRomboide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcRomboide);
            this.Name = "Romboide";
            this.Text = "Romboide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxAlturaRomboide;
        private System.Windows.Forms.TextBox txtBxBaseRomboide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcRomboide;
        private System.Windows.Forms.TextBox txtBxLadoRomboide;
        private System.Windows.Forms.Label label1;
    }
}