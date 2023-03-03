namespace Calculando
{
    partial class Form_calculando
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_calculando));
            this.lblOpcao = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.boxOpcoes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(12, 23);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(379, 20);
            this.lblOpcao.TabIndex = 0;
            this.lblOpcao.Text = "Escolha a Calculadora que você quer usar";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(151, 117);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 50);
            this.btnOk.TabIndex = 50;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // boxOpcoes
            // 
            this.boxOpcoes.FormattingEnabled = true;
            this.boxOpcoes.Items.AddRange(new object[] {
            "Calculadora",
            "Convertendo Temperatura",
            "Convertendo Moeda"});
            this.boxOpcoes.Location = new System.Drawing.Point(16, 64);
            this.boxOpcoes.Name = "boxOpcoes";
            this.boxOpcoes.Size = new System.Drawing.Size(375, 24);
            this.boxOpcoes.TabIndex = 2;
            // 
            // Form_calculando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(435, 207);
            this.Controls.Add(this.boxOpcoes);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblOpcao);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_calculando";
            this.Text = "Calculando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox boxOpcoes;
    }
}

