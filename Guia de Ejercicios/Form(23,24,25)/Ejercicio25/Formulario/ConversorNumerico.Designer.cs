namespace Formulario
{
    partial class ConversorNumerico
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
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.lblBinarioADecimal = new System.Windows.Forms.Label();
            this.lblDecimalABinario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBinario
            // 
            this.txtBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinario.Location = new System.Drawing.Point(215, 23);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(202, 30);
            this.txtBinario.TabIndex = 0;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinToDec.Location = new System.Drawing.Point(423, 23);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(115, 32);
            this.btnBinToDec.TabIndex = 1;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoDec.Location = new System.Drawing.Point(544, 23);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(202, 30);
            this.txtResultadoDec.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(215, 59);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(202, 30);
            this.txtDecimal.TabIndex = 3;
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecToBin.Location = new System.Drawing.Point(423, 59);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(115, 30);
            this.btnDecToBin.TabIndex = 4;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoBin.Location = new System.Drawing.Point(544, 59);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(202, 30);
            this.txtResultadoBin.TabIndex = 5;
            // 
            // lblBinarioADecimal
            // 
            this.lblBinarioADecimal.AutoSize = true;
            this.lblBinarioADecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinarioADecimal.Location = new System.Drawing.Point(12, 26);
            this.lblBinarioADecimal.Name = "lblBinarioADecimal";
            this.lblBinarioADecimal.Size = new System.Drawing.Size(163, 25);
            this.lblBinarioADecimal.TabIndex = 6;
            this.lblBinarioADecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalABinario
            // 
            this.lblDecimalABinario.AutoSize = true;
            this.lblDecimalABinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalABinario.Location = new System.Drawing.Point(12, 62);
            this.lblDecimalABinario.Name = "lblDecimalABinario";
            this.lblDecimalABinario.Size = new System.Drawing.Size(163, 25);
            this.lblDecimalABinario.TabIndex = 7;
            this.lblDecimalABinario.Text = "Decimal a Binario";
            // 
            // ConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 111);
            this.Controls.Add(this.lblDecimalABinario);
            this.Controls.Add(this.lblBinarioADecimal);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConversorNumerico";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.Label lblBinarioADecimal;
        private System.Windows.Forms.Label lblDecimalABinario;
    }
}

