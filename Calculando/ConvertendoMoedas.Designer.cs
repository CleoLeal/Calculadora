namespace Calculando
{
    partial class form_convertendo_moedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_convertendo_moedas));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupConverter = new System.Windows.Forms.GroupBox();
            this.radioConverterEuro = new System.Windows.Forms.RadioButton();
            this.radioConverterReal = new System.Windows.Forms.RadioButton();
            this.radioConverterDolar = new System.Windows.Forms.RadioButton();
            this.groupMoeda = new System.Windows.Forms.GroupBox();
            this.radioEuro = new System.Windows.Forms.RadioButton();
            this.radioReal = new System.Windows.Forms.RadioButton();
            this.radioDolar = new System.Windows.Forms.RadioButton();
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
            this.groupConverter.SuspendLayout();
            this.groupMoeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(6, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 23);
            this.btnBack.TabIndex = 94;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(329, 135);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(38, 28);
            this.btnClear.TabIndex = 93;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupConverter
            // 
            this.groupConverter.Controls.Add(this.radioConverterEuro);
            this.groupConverter.Controls.Add(this.radioConverterReal);
            this.groupConverter.Controls.Add(this.radioConverterDolar);
            this.groupConverter.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConverter.ForeColor = System.Drawing.Color.White;
            this.groupConverter.Location = new System.Drawing.Point(5, 158);
            this.groupConverter.Margin = new System.Windows.Forms.Padding(2);
            this.groupConverter.Name = "groupConverter";
            this.groupConverter.Padding = new System.Windows.Forms.Padding(2);
            this.groupConverter.Size = new System.Drawing.Size(160, 105);
            this.groupConverter.TabIndex = 92;
            this.groupConverter.TabStop = false;
            this.groupConverter.Text = "Converter para";
            // 
            // radioConverterEuro
            // 
            this.radioConverterEuro.AutoSize = true;
            this.radioConverterEuro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioConverterEuro.ForeColor = System.Drawing.Color.White;
            this.radioConverterEuro.Location = new System.Drawing.Point(18, 49);
            this.radioConverterEuro.Margin = new System.Windows.Forms.Padding(2);
            this.radioConverterEuro.Name = "radioConverterEuro";
            this.radioConverterEuro.Size = new System.Drawing.Size(67, 23);
            this.radioConverterEuro.TabIndex = 56;
            this.radioConverterEuro.TabStop = true;
            this.radioConverterEuro.Text = "Euro";
            this.radioConverterEuro.UseVisualStyleBackColor = true;
            // 
            // radioConverterReal
            // 
            this.radioConverterReal.AutoSize = true;
            this.radioConverterReal.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioConverterReal.ForeColor = System.Drawing.Color.White;
            this.radioConverterReal.Location = new System.Drawing.Point(18, 21);
            this.radioConverterReal.Margin = new System.Windows.Forms.Padding(2);
            this.radioConverterReal.Name = "radioConverterReal";
            this.radioConverterReal.Size = new System.Drawing.Size(63, 23);
            this.radioConverterReal.TabIndex = 55;
            this.radioConverterReal.TabStop = true;
            this.radioConverterReal.Text = "Real";
            this.radioConverterReal.UseVisualStyleBackColor = true;
            // 
            // radioConverterDolar
            // 
            this.radioConverterDolar.AutoSize = true;
            this.radioConverterDolar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioConverterDolar.ForeColor = System.Drawing.Color.White;
            this.radioConverterDolar.Location = new System.Drawing.Point(18, 76);
            this.radioConverterDolar.Margin = new System.Windows.Forms.Padding(2);
            this.radioConverterDolar.Name = "radioConverterDolar";
            this.radioConverterDolar.Size = new System.Drawing.Size(70, 23);
            this.radioConverterDolar.TabIndex = 57;
            this.radioConverterDolar.TabStop = true;
            this.radioConverterDolar.Text = "Dólar";
            this.radioConverterDolar.UseVisualStyleBackColor = true;
            // 
            // groupMoeda
            // 
            this.groupMoeda.Controls.Add(this.radioEuro);
            this.groupMoeda.Controls.Add(this.radioReal);
            this.groupMoeda.Controls.Add(this.radioDolar);
            this.groupMoeda.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMoeda.ForeColor = System.Drawing.Color.White;
            this.groupMoeda.Location = new System.Drawing.Point(5, 34);
            this.groupMoeda.Margin = new System.Windows.Forms.Padding(2);
            this.groupMoeda.Name = "groupMoeda";
            this.groupMoeda.Padding = new System.Windows.Forms.Padding(2);
            this.groupMoeda.Size = new System.Drawing.Size(160, 105);
            this.groupMoeda.TabIndex = 91;
            this.groupMoeda.TabStop = false;
            this.groupMoeda.Text = "A Moeda";
            // 
            // radioEuro
            // 
            this.radioEuro.AutoSize = true;
            this.radioEuro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioEuro.ForeColor = System.Drawing.Color.White;
            this.radioEuro.Location = new System.Drawing.Point(18, 45);
            this.radioEuro.Margin = new System.Windows.Forms.Padding(2);
            this.radioEuro.Name = "radioEuro";
            this.radioEuro.Size = new System.Drawing.Size(67, 23);
            this.radioEuro.TabIndex = 53;
            this.radioEuro.TabStop = true;
            this.radioEuro.Text = "Euro";
            this.radioEuro.UseVisualStyleBackColor = true;
            // 
            // radioReal
            // 
            this.radioReal.AutoSize = true;
            this.radioReal.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioReal.ForeColor = System.Drawing.Color.White;
            this.radioReal.Location = new System.Drawing.Point(18, 17);
            this.radioReal.Margin = new System.Windows.Forms.Padding(2);
            this.radioReal.Name = "radioReal";
            this.radioReal.Size = new System.Drawing.Size(63, 23);
            this.radioReal.TabIndex = 52;
            this.radioReal.TabStop = true;
            this.radioReal.Text = "Real";
            this.radioReal.UseVisualStyleBackColor = true;
            // 
            // radioDolar
            // 
            this.radioDolar.AutoSize = true;
            this.radioDolar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.radioDolar.ForeColor = System.Drawing.Color.White;
            this.radioDolar.Location = new System.Drawing.Point(18, 72);
            this.radioDolar.Margin = new System.Windows.Forms.Padding(2);
            this.radioDolar.Name = "radioDolar";
            this.radioDolar.Size = new System.Drawing.Size(70, 23);
            this.radioDolar.TabIndex = 54;
            this.radioDolar.TabStop = true;
            this.radioDolar.Text = "Dólar";
            this.radioDolar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.lblResultado.Location = new System.Drawing.Point(169, 43);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(198, 72);
            this.lblResultado.TabIndex = 90;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Silver;
            this.btnPoint.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(275, 234);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(49, 28);
            this.btnPoint.TabIndex = 89;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Red;
            this.btnEqual.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(329, 168);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(38, 95);
            this.btnEqual.TabIndex = 88;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(169, 234);
            this.btnZero.Margin = new System.Windows.Forms.Padding(2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(102, 28);
            this.btnZero.TabIndex = 87;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(275, 201);
            this.btnNine.Margin = new System.Windows.Forms.Padding(2);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(49, 28);
            this.btnNine.TabIndex = 86;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(222, 201);
            this.btnEight.Margin = new System.Windows.Forms.Padding(2);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(49, 28);
            this.btnEight.TabIndex = 85;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(169, 201);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(49, 28);
            this.btnSeven.TabIndex = 84;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(275, 168);
            this.btnSix.Margin = new System.Windows.Forms.Padding(2);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(49, 28);
            this.btnSix.TabIndex = 83;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(222, 168);
            this.btnFive.Margin = new System.Windows.Forms.Padding(2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(49, 28);
            this.btnFive.TabIndex = 82;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(169, 168);
            this.btnFour.Margin = new System.Windows.Forms.Padding(2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(49, 28);
            this.btnFour.TabIndex = 81;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(275, 135);
            this.btnThree.Margin = new System.Windows.Forms.Padding(2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(49, 28);
            this.btnThree.TabIndex = 80;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(222, 134);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(49, 28);
            this.btnTwo.TabIndex = 79;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(169, 135);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(49, 28);
            this.btnOne.TabIndex = 78;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // form_convertendo_moedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(376, 272);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupConverter);
            this.Controls.Add(this.groupMoeda);
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
            this.Name = "form_convertendo_moedas";
            this.Text = "Convertendo Moedas";
            this.groupConverter.ResumeLayout(false);
            this.groupConverter.PerformLayout();
            this.groupMoeda.ResumeLayout(false);
            this.groupMoeda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupConverter;
        private System.Windows.Forms.RadioButton radioConverterEuro;
        private System.Windows.Forms.RadioButton radioConverterReal;
        private System.Windows.Forms.RadioButton radioConverterDolar;
        private System.Windows.Forms.GroupBox groupMoeda;
        private System.Windows.Forms.RadioButton radioEuro;
        private System.Windows.Forms.RadioButton radioReal;
        private System.Windows.Forms.RadioButton radioDolar;
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
    }
}