namespace Calculando
{
    partial class form_convertendo_temperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_convertendo_temperatura));
            this.btnClear = new System.Windows.Forms.Button();
            this.groupConverter = new System.Windows.Forms.GroupBox();
            this.radioConverterFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioConverterCelsius = new System.Windows.Forms.RadioButton();
            this.radioConverterKelvin = new System.Windows.Forms.RadioButton();
            this.groupTemperatura = new System.Windows.Forms.GroupBox();
            this.radioFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioCelsius = new System.Windows.Forms.RadioButton();
            this.radioKelvin = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupConverter.SuspendLayout();
            this.groupTemperatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(442, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 35);
            this.btnClear.TabIndex = 92;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupConverter
            // 
            this.groupConverter.Controls.Add(this.radioConverterFahrenheit);
            this.groupConverter.Controls.Add(this.radioConverterCelsius);
            this.groupConverter.Controls.Add(this.radioConverterKelvin);
            this.groupConverter.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConverter.ForeColor = System.Drawing.Color.White;
            this.groupConverter.Location = new System.Drawing.Point(10, 208);
            this.groupConverter.Name = "groupConverter";
            this.groupConverter.Size = new System.Drawing.Size(213, 135);
            this.groupConverter.TabIndex = 91;
            this.groupConverter.TabStop = false;
            this.groupConverter.Text = "Converter para";
            // 
            // radioConverterFahrenheit
            // 
            this.radioConverterFahrenheit.AutoSize = true;
            this.radioConverterFahrenheit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioConverterFahrenheit.ForeColor = System.Drawing.Color.White;
            this.radioConverterFahrenheit.Location = new System.Drawing.Point(24, 60);
            this.radioConverterFahrenheit.Name = "radioConverterFahrenheit";
            this.radioConverterFahrenheit.Size = new System.Drawing.Size(146, 28);
            this.radioConverterFahrenheit.TabIndex = 56;
            this.radioConverterFahrenheit.TabStop = true;
            this.radioConverterFahrenheit.Text = "Fahrenheit";
            this.radioConverterFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioConverterCelsius
            // 
            this.radioConverterCelsius.AutoSize = true;
            this.radioConverterCelsius.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioConverterCelsius.ForeColor = System.Drawing.Color.White;
            this.radioConverterCelsius.Location = new System.Drawing.Point(24, 26);
            this.radioConverterCelsius.Name = "radioConverterCelsius";
            this.radioConverterCelsius.Size = new System.Drawing.Size(104, 28);
            this.radioConverterCelsius.TabIndex = 55;
            this.radioConverterCelsius.TabStop = true;
            this.radioConverterCelsius.Text = "Celsius";
            this.radioConverterCelsius.UseVisualStyleBackColor = true;
            // 
            // radioConverterKelvin
            // 
            this.radioConverterKelvin.AutoSize = true;
            this.radioConverterKelvin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioConverterKelvin.ForeColor = System.Drawing.Color.White;
            this.radioConverterKelvin.Location = new System.Drawing.Point(24, 94);
            this.radioConverterKelvin.Name = "radioConverterKelvin";
            this.radioConverterKelvin.Size = new System.Drawing.Size(98, 28);
            this.radioConverterKelvin.TabIndex = 57;
            this.radioConverterKelvin.TabStop = true;
            this.radioConverterKelvin.Text = "Kelvin";
            this.radioConverterKelvin.UseVisualStyleBackColor = true;
            // 
            // groupTemperatura
            // 
            this.groupTemperatura.Controls.Add(this.radioFahrenheit);
            this.groupTemperatura.Controls.Add(this.radioCelsius);
            this.groupTemperatura.Controls.Add(this.radioKelvin);
            this.groupTemperatura.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTemperatura.ForeColor = System.Drawing.Color.White;
            this.groupTemperatura.Location = new System.Drawing.Point(10, 55);
            this.groupTemperatura.Name = "groupTemperatura";
            this.groupTemperatura.Size = new System.Drawing.Size(213, 129);
            this.groupTemperatura.TabIndex = 90;
            this.groupTemperatura.TabStop = false;
            this.groupTemperatura.Text = "A Temperatura";
            // 
            // radioFahrenheit
            // 
            this.radioFahrenheit.AutoSize = true;
            this.radioFahrenheit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioFahrenheit.ForeColor = System.Drawing.Color.White;
            this.radioFahrenheit.Location = new System.Drawing.Point(24, 55);
            this.radioFahrenheit.Name = "radioFahrenheit";
            this.radioFahrenheit.Size = new System.Drawing.Size(146, 28);
            this.radioFahrenheit.TabIndex = 53;
            this.radioFahrenheit.TabStop = true;
            this.radioFahrenheit.Text = "Fahrenheit";
            this.radioFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioCelsius
            // 
            this.radioCelsius.AutoSize = true;
            this.radioCelsius.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioCelsius.ForeColor = System.Drawing.Color.White;
            this.radioCelsius.Location = new System.Drawing.Point(24, 21);
            this.radioCelsius.Name = "radioCelsius";
            this.radioCelsius.Size = new System.Drawing.Size(104, 28);
            this.radioCelsius.TabIndex = 52;
            this.radioCelsius.TabStop = true;
            this.radioCelsius.Text = "Celsius";
            this.radioCelsius.UseVisualStyleBackColor = true;
            // 
            // radioKelvin
            // 
            this.radioKelvin.AutoSize = true;
            this.radioKelvin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioKelvin.ForeColor = System.Drawing.Color.White;
            this.radioKelvin.Location = new System.Drawing.Point(24, 89);
            this.radioKelvin.Name = "radioKelvin";
            this.radioKelvin.Size = new System.Drawing.Size(98, 28);
            this.radioKelvin.TabIndex = 54;
            this.radioKelvin.TabStop = true;
            this.radioKelvin.Text = "Kelvin";
            this.radioKelvin.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.lblResultado.Location = new System.Drawing.Point(229, 67);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(264, 88);
            this.lblResultado.TabIndex = 89;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Silver;
            this.btnPoint.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(371, 302);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(65, 35);
            this.btnPoint.TabIndex = 88;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Red;
            this.btnEqual.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(442, 220);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(51, 117);
            this.btnEqual.TabIndex = 87;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(229, 302);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(136, 35);
            this.btnZero.TabIndex = 86;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(371, 261);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(65, 35);
            this.btnNine.TabIndex = 85;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(300, 261);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(65, 35);
            this.btnEight.TabIndex = 84;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(229, 261);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(65, 35);
            this.btnSeven.TabIndex = 83;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(371, 221);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(65, 35);
            this.btnSix.TabIndex = 82;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(300, 221);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(65, 35);
            this.btnFive.TabIndex = 81;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(229, 220);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(65, 35);
            this.btnFour.TabIndex = 80;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(371, 180);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(65, 35);
            this.btnThree.TabIndex = 79;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(300, 179);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(65, 35);
            this.btnTwo.TabIndex = 78;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(229, 180);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(65, 35);
            this.btnOne.TabIndex = 77;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 28);
            this.btnBack.TabIndex = 93;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // form_convertendo_temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(502, 347);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupConverter);
            this.Controls.Add(this.groupTemperatura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_convertendo_temperatura";
            this.Text = "Convertendo Temperatura";
            this.groupConverter.ResumeLayout(false);
            this.groupConverter.PerformLayout();
            this.groupTemperatura.ResumeLayout(false);
            this.groupTemperatura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupConverter;
        private System.Windows.Forms.RadioButton radioConverterFahrenheit;
        private System.Windows.Forms.RadioButton radioConverterCelsius;
        private System.Windows.Forms.RadioButton radioConverterKelvin;
        private System.Windows.Forms.GroupBox groupTemperatura;
        private System.Windows.Forms.RadioButton radioFahrenheit;
        private System.Windows.Forms.RadioButton radioCelsius;
        private System.Windows.Forms.RadioButton radioKelvin;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnBack;
    }
}