namespace Formulario
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
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertFahrenheit = new System.Windows.Forms.Button();
            this.txtFahrenheitAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConvertCelsius = new System.Windows.Forms.Button();
            this.txtCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.txtKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.lblFahrenheit1 = new System.Windows.Forms.Label();
            this.lblCelsius1 = new System.Windows.Forms.Label();
            this.lblKelvin1 = new System.Windows.Forms.Label();
            this.lblFahrenheit2 = new System.Windows.Forms.Label();
            this.lblCelsius2 = new System.Windows.Forms.Label();
            this.lblKelvin2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.Location = new System.Drawing.Point(156, 57);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(159, 35);
            this.txtFahrenheit.TabIndex = 0;
            // 
            // btnConvertFahrenheit
            // 
            this.btnConvertFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFahrenheit.Location = new System.Drawing.Point(321, 57);
            this.btnConvertFahrenheit.Name = "btnConvertFahrenheit";
            this.btnConvertFahrenheit.Size = new System.Drawing.Size(75, 35);
            this.btnConvertFahrenheit.TabIndex = 1;
            this.btnConvertFahrenheit.Text = "->";
            this.btnConvertFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenheit.Click += new System.EventHandler(this.btnConvertFahrenheit_Click);
            // 
            // txtFahrenheitAFahrenheit
            // 
            this.txtFahrenheitAFahrenheit.Enabled = false;
            this.txtFahrenheitAFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheitAFahrenheit.Location = new System.Drawing.Point(402, 57);
            this.txtFahrenheitAFahrenheit.Name = "txtFahrenheitAFahrenheit";
            this.txtFahrenheitAFahrenheit.Size = new System.Drawing.Size(159, 35);
            this.txtFahrenheitAFahrenheit.TabIndex = 2;
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Enabled = false;
            this.txtFahrenheitACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(567, 57);
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(159, 35);
            this.txtFahrenheitACelsius.TabIndex = 3;
            // 
            // txtFahrenheitAKelvin
            // 
            this.txtFahrenheitAKelvin.Enabled = false;
            this.txtFahrenheitAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheitAKelvin.Location = new System.Drawing.Point(732, 57);
            this.txtFahrenheitAKelvin.Name = "txtFahrenheitAKelvin";
            this.txtFahrenheitAKelvin.Size = new System.Drawing.Size(159, 35);
            this.txtFahrenheitAKelvin.TabIndex = 4;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsius.Location = new System.Drawing.Point(156, 98);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(159, 35);
            this.txtCelsius.TabIndex = 5;
            // 
            // btnConvertCelsius
            // 
            this.btnConvertCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertCelsius.Location = new System.Drawing.Point(321, 98);
            this.btnConvertCelsius.Name = "btnConvertCelsius";
            this.btnConvertCelsius.Size = new System.Drawing.Size(75, 35);
            this.btnConvertCelsius.TabIndex = 6;
            this.btnConvertCelsius.Text = "->";
            this.btnConvertCelsius.UseVisualStyleBackColor = true;
            this.btnConvertCelsius.Click += new System.EventHandler(this.btnConvertCelsius_Click);
            // 
            // txtCelsiusAFahrenheit
            // 
            this.txtCelsiusAFahrenheit.Enabled = false;
            this.txtCelsiusAFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusAFahrenheit.Location = new System.Drawing.Point(402, 98);
            this.txtCelsiusAFahrenheit.Name = "txtCelsiusAFahrenheit";
            this.txtCelsiusAFahrenheit.Size = new System.Drawing.Size(159, 35);
            this.txtCelsiusAFahrenheit.TabIndex = 7;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Enabled = false;
            this.txtCelsiusACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(567, 98);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(159, 35);
            this.txtCelsiusACelsius.TabIndex = 8;
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Enabled = false;
            this.txtCelsiusAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(732, 98);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(159, 35);
            this.txtCelsiusAKelvin.TabIndex = 9;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvin.Location = new System.Drawing.Point(156, 139);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(159, 35);
            this.txtKelvin.TabIndex = 10;
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertKelvin.Location = new System.Drawing.Point(321, 139);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(75, 35);
            this.btnConvertKelvin.TabIndex = 11;
            this.btnConvertKelvin.Text = "->";
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.btnConvertKelvin_Click);
            // 
            // txtKelvinAFahrenheit
            // 
            this.txtKelvinAFahrenheit.Enabled = false;
            this.txtKelvinAFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinAFahrenheit.Location = new System.Drawing.Point(402, 139);
            this.txtKelvinAFahrenheit.Name = "txtKelvinAFahrenheit";
            this.txtKelvinAFahrenheit.Size = new System.Drawing.Size(159, 35);
            this.txtKelvinAFahrenheit.TabIndex = 12;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Enabled = false;
            this.txtKelvinACelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinACelsius.Location = new System.Drawing.Point(567, 139);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.Size = new System.Drawing.Size(159, 35);
            this.txtKelvinACelsius.TabIndex = 13;
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Enabled = false;
            this.txtKelvinAKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(732, 139);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(159, 35);
            this.txtKelvinAKelvin.TabIndex = 14;
            // 
            // lblFahrenheit1
            // 
            this.lblFahrenheit1.AutoSize = true;
            this.lblFahrenheit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit1.Location = new System.Drawing.Point(1, 57);
            this.lblFahrenheit1.Name = "lblFahrenheit1";
            this.lblFahrenheit1.Size = new System.Drawing.Size(128, 29);
            this.lblFahrenheit1.TabIndex = 15;
            this.lblFahrenheit1.Text = "Fahrenheit";
            // 
            // lblCelsius1
            // 
            this.lblCelsius1.AutoSize = true;
            this.lblCelsius1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius1.Location = new System.Drawing.Point(1, 98);
            this.lblCelsius1.Name = "lblCelsius1";
            this.lblCelsius1.Size = new System.Drawing.Size(93, 29);
            this.lblCelsius1.TabIndex = 16;
            this.lblCelsius1.Text = "Celsius";
            // 
            // lblKelvin1
            // 
            this.lblKelvin1.AutoSize = true;
            this.lblKelvin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin1.Location = new System.Drawing.Point(1, 139);
            this.lblKelvin1.Name = "lblKelvin1";
            this.lblKelvin1.Size = new System.Drawing.Size(79, 29);
            this.lblKelvin1.TabIndex = 17;
            this.lblKelvin1.Text = "Kelvin";
            // 
            // lblFahrenheit2
            // 
            this.lblFahrenheit2.AutoSize = true;
            this.lblFahrenheit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit2.Location = new System.Drawing.Point(416, 9);
            this.lblFahrenheit2.Name = "lblFahrenheit2";
            this.lblFahrenheit2.Size = new System.Drawing.Size(128, 29);
            this.lblFahrenheit2.TabIndex = 18;
            this.lblFahrenheit2.Text = "Fahrenheit";
            // 
            // lblCelsius2
            // 
            this.lblCelsius2.AutoSize = true;
            this.lblCelsius2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius2.Location = new System.Drawing.Point(603, 9);
            this.lblCelsius2.Name = "lblCelsius2";
            this.lblCelsius2.Size = new System.Drawing.Size(93, 29);
            this.lblCelsius2.TabIndex = 19;
            this.lblCelsius2.Text = "Celsius";
            // 
            // lblKelvin2
            // 
            this.lblKelvin2.AutoSize = true;
            this.lblKelvin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin2.Location = new System.Drawing.Point(774, 9);
            this.lblKelvin2.Name = "lblKelvin2";
            this.lblKelvin2.Size = new System.Drawing.Size(79, 29);
            this.lblKelvin2.TabIndex = 20;
            this.lblKelvin2.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 189);
            this.Controls.Add(this.lblKelvin2);
            this.Controls.Add(this.lblCelsius2);
            this.Controls.Add(this.lblFahrenheit2);
            this.Controls.Add(this.lblKelvin1);
            this.Controls.Add(this.lblCelsius1);
            this.Controls.Add(this.lblFahrenheit1);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtKelvinAFahrenheit);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtCelsiusAFahrenheit);
            this.Controls.Add(this.btnConvertCelsius);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheitAKelvin);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.txtFahrenheitAFahrenheit);
            this.Controls.Add(this.btnConvertFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Conversor Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConvertFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitAKelvin;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvertCelsius;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnConvertKelvin;
        private System.Windows.Forms.TextBox txtKelvinAFahrenheit;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.Label lblFahrenheit1;
        private System.Windows.Forms.Label lblCelsius1;
        private System.Windows.Forms.Label lblKelvin1;
        private System.Windows.Forms.Label lblFahrenheit2;
        private System.Windows.Forms.Label lblCelsius2;
        private System.Windows.Forms.Label lblKelvin2;
    }
}

