namespace Actividad2_StefanyDíaz
{
    partial class Círculo
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
            this.txtBxRadio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcCirculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxRadio
            // 
            this.txtBxRadio.Location = new System.Drawing.Point(217, 156);
            this.txtBxRadio.Name = "txtBxRadio";
            this.txtBxRadio.Size = new System.Drawing.Size(100, 22);
            this.txtBxRadio.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(143, 156);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(47, 16);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Radio:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(153, 95);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(261, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y circunferencia de un círculo";
            this.lblTittle.Click += new System.EventHandler(this.lblTittle_Click);
            // 
            // btnCalcCirculo
            // 
            this.btnCalcCirculo.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcCirculo.Location = new System.Drawing.Point(217, 229);
            this.btnCalcCirculo.Name = "btnCalcCirculo";
            this.btnCalcCirculo.Size = new System.Drawing.Size(112, 45);
            this.btnCalcCirculo.TabIndex = 7;
            this.btnCalcCirculo.Text = "Calcular";
            this.btnCalcCirculo.UseVisualStyleBackColor = false;
            this.btnCalcCirculo.Click += new System.EventHandler(this.btnCalcCirculo_Click);
            // 
            // Círculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcCirculo);
            this.Name = "Círculo";
            this.Text = "Círculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcCirculo;
    }
}