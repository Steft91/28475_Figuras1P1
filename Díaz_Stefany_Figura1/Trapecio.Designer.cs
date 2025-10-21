namespace Actividad2_StefanyDíaz
{
    partial class Trapecio
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
            this.txtBxBasMenor = new System.Windows.Forms.TextBox();
            this.txtBxBasMayor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnCalcTrapecio = new System.Windows.Forms.Button();
            this.txtBxAltTrapecio = new System.Windows.Forms.TextBox();
            this.txtBxLadoTrapecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxBasMenor
            // 
            this.txtBxBasMenor.Location = new System.Drawing.Point(272, 170);
            this.txtBxBasMenor.Name = "txtBxBasMenor";
            this.txtBxBasMenor.Size = new System.Drawing.Size(100, 22);
            this.txtBxBasMenor.TabIndex = 13;
            // 
            // txtBxBasMayor
            // 
            this.txtBxBasMayor.Location = new System.Drawing.Point(272, 117);
            this.txtBxBasMayor.Name = "txtBxBasMayor";
            this.txtBxBasMayor.Size = new System.Drawing.Size(100, 22);
            this.txtBxBasMayor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(183, 173);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(80, 16);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Base menor";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(183, 123);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(83, 16);
            this.lblBase.TabIndex = 9;
            this.lblBase.Text = "Base mayor:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(161, 89);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(306, 16);
            this.lblTittle.TabIndex = 8;
            this.lblTittle.Text = "Calcular área y perímetro de un trapecio isósceles";
            // 
            // btnCalcTrapecio
            // 
            this.btnCalcTrapecio.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalcTrapecio.Location = new System.Drawing.Point(234, 317);
            this.btnCalcTrapecio.Name = "btnCalcTrapecio";
            this.btnCalcTrapecio.Size = new System.Drawing.Size(112, 45);
            this.btnCalcTrapecio.TabIndex = 7;
            this.btnCalcTrapecio.Text = "Calcular";
            this.btnCalcTrapecio.UseVisualStyleBackColor = false;
            this.btnCalcTrapecio.Click += new System.EventHandler(this.btnCalcTrapecio_Click);
            // 
            // txtBxAltTrapecio
            // 
            this.txtBxAltTrapecio.Location = new System.Drawing.Point(272, 277);
            this.txtBxAltTrapecio.Name = "txtBxAltTrapecio";
            this.txtBxAltTrapecio.Size = new System.Drawing.Size(100, 22);
            this.txtBxAltTrapecio.TabIndex = 17;
            // 
            // txtBxLadoTrapecio
            // 
            this.txtBxLadoTrapecio.Location = new System.Drawing.Point(272, 224);
            this.txtBxLadoTrapecio.Name = "txtBxLadoTrapecio";
            this.txtBxLadoTrapecio.Size = new System.Drawing.Size(100, 22);
            this.txtBxLadoTrapecio.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxAltTrapecio);
            this.Controls.Add(this.txtBxLadoTrapecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxBasMenor);
            this.Controls.Add(this.txtBxBasMayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnCalcTrapecio);
            this.Name = "Trapecio";
            this.Text = "Trapecio";
            this.Load += new System.EventHandler(this.Trapecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxBasMenor;
        private System.Windows.Forms.TextBox txtBxBasMayor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnCalcTrapecio;
        private System.Windows.Forms.TextBox txtBxAltTrapecio;
        private System.Windows.Forms.TextBox txtBxLadoTrapecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}