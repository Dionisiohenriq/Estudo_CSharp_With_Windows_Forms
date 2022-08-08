namespace Banco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoDeposito = new System.Windows.Forms.TextBox();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.contaGroup = new System.Windows.Forms.GroupBox();
            this.botaoSaca = new System.Windows.Forms.Button();
            this.textoSaca = new System.Windows.Forms.TextBox();
            this.contaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(195, 39);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(125, 27);
            this.textoTitular.TabIndex = 1;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(195, 72);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(125, 27);
            this.textoNumero.TabIndex = 2;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(195, 105);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(125, 27);
            this.textoSaldo.TabIndex = 3;
            // 
            // textoDeposito
            // 
            this.textoDeposito.Location = new System.Drawing.Point(6, 39);
            this.textoDeposito.Name = "textoDeposito";
            this.textoDeposito.Size = new System.Drawing.Size(125, 27);
            this.textoDeposito.TabIndex = 4;
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(6, 72);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(94, 29);
            this.botaoDeposita.TabIndex = 5;
            this.botaoDeposita.Text = "button1";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // contaGroup
            // 
            this.contaGroup.Controls.Add(this.textoSaca);
            this.contaGroup.Controls.Add(this.botaoSaca);
            this.contaGroup.Controls.Add(this.textoSaldo);
            this.contaGroup.Controls.Add(this.textoTitular);
            this.contaGroup.Controls.Add(this.botaoDeposita);
            this.contaGroup.Controls.Add(this.textoNumero);
            this.contaGroup.Controls.Add(this.textoDeposito);
            this.contaGroup.Location = new System.Drawing.Point(12, 12);
            this.contaGroup.Name = "contaGroup";
            this.contaGroup.Size = new System.Drawing.Size(428, 191);
            this.contaGroup.TabIndex = 0;
            this.contaGroup.TabStop = false;
            this.contaGroup.Text = "Conta";
            // 
            // botaoSaca
            // 
            this.botaoSaca.Location = new System.Drawing.Point(6, 156);
            this.botaoSaca.Name = "botaoSaca";
            this.botaoSaca.Size = new System.Drawing.Size(94, 29);
            this.botaoSaca.TabIndex = 7;
            this.botaoSaca.Text = "button1";
            this.botaoSaca.UseVisualStyleBackColor = true;
            this.botaoSaca.Click += new System.EventHandler(this.botaoSaca_Click);
            // 
            // textoSaca
            // 
            this.textoSaca.Location = new System.Drawing.Point(6, 123);
            this.textoSaca.Name = "textoSaca";
            this.textoSaca.Size = new System.Drawing.Size(125, 27);
            this.textoSaca.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(668, 427);
            this.Controls.Add(this.contaGroup);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contaGroup.ResumeLayout(false);
            this.contaGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textoTitular;
        private TextBox textoNumero;
        private TextBox textoSaldo;
        private TextBox textoDeposito;
        private Button botaoDeposita;
        private GroupBox contaGroup;
        private TextBox textoSaca;
        private Button botaoSaca;
    }
}