namespace Actividad2_StefanyDíaz
{
    partial class Rombo
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
            this.txtBxDiagMen = new System.Windows.Forms.TextBox();
            this.txtBxDiagMay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcRombo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxDiagMen
            // 
            this.txtBxDiagMen.Location = new System.Drawing.Point(227, 165);
            this.txtBxDiagMen.Name = "txtBxDiagMen";
            this.txtBxDiagMen.Size = new System.Drawing.Size(100, 22);
            this.txtBxDiagMen.TabIndex = 13;
            // 
            // txtBxDiagMay
            // 
            this.txtBxDiagMay.Location = new System.Drawing.Point(227, 137);
            this.txtBxDiagMay.Name = "txtBxDiagMay";
            this.txtBxDiagMay.Size = new System.Drawing.Size(100, 22);
            this.txtBxDiagMay.TabIndex = 12;
            this.txtBxDiagMay.TextChanged += new System.EventHandler(this.txtBxDiagMay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(118, 165);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(103, 16);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Diagonal menor";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(115, 137);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(106, 16);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Diagonal mayor:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(163, 76);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(235, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y perímetro de un rombo";
            // 
            // btnCalcRombo
            // 
            this.btnCalcRombo.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcRombo.Location = new System.Drawing.Point(227, 263);
            this.btnCalcRombo.Name = "btnCalcRombo";
            this.btnCalcRombo.Size = new System.Drawing.Size(112, 45);
            this.btnCalcRombo.TabIndex = 7;
            this.btnCalcRombo.Text = "Calcular";
            this.btnCalcRombo.UseVisualStyleBackColor = false;
            this.btnCalcRombo.Click += new System.EventHandler(this.btnCalcRombo_Click);
            // 
            // Rombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxDiagMen);
            this.Controls.Add(this.txtBxDiagMay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcRombo);
            this.Name = "Rombo";
            this.Text = "Rombo";
            this.Load += new System.EventHandler(this.Rombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxDiagMen;
        private System.Windows.Forms.TextBox txtBxDiagMay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcRombo;
    }
}