namespace Prova3_semestre1
{
    partial class frmMovimento
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
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.dtMovimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(12, 103);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(100, 40);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(244, 103);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(111, 40);
            this.btnSacar.TabIndex = 1;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(454, 243);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(114, 47);
            this.btnLancar.TabIndex = 2;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(454, 103);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(12, 59);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 23);
            this.txtConta.TabIndex = 4;
            this.txtConta.CursorChanged += new System.EventHandler(this.txtConta_CursorChanged);
            this.txtConta.EnabledChanged += new System.EventHandler(this.txtConta_EnabledChanged);
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            // 
            // txtLimite
            // 
            this.txtLimite.Enabled = false;
            this.txtLimite.Location = new System.Drawing.Point(323, 55);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 23);
            this.txtLimite.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(244, 267);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 6;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(519, 52);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(138, 23);
            this.txtSaldo.TabIndex = 7;
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Enabled = false;
            this.rdComum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdComum.Location = new System.Drawing.Point(161, 24);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(126, 25);
            this.rdComum.TabIndex = 8;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta comum";
            this.rdComum.UseVisualStyleBackColor = true;
            this.rdComum.CheckedChanged += new System.EventHandler(this.rdComum_CheckedChanged);
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Enabled = false;
            this.rdEspecial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdEspecial.Location = new System.Drawing.Point(161, 55);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(128, 25);
            this.rdEspecial.TabIndex = 9;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // dtMovimento
            // 
            this.dtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovimento.Location = new System.Drawing.Point(12, 267);
            this.dtMovimento.Name = "dtMovimento";
            this.dtMovimento.Size = new System.Drawing.Size(200, 23);
            this.dtMovimento.TabIndex = 10;
            this.dtMovimento.Leave += new System.EventHandler(this.dtMovimento_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nr. Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(323, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Limite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(244, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(519, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data";
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMovimento);
            this.Controls.Add(this.rdEspecial);
            this.Controls.Add(this.rdComum);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Name = "frmMovimento";
            this.Text = "frmMovimento";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.Leave += new System.EventHandler(this.frmMovimento_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDepositar;
        private Button btnSacar;
        private Button btnLancar;
        private Button btnSair;
        private TextBox txtConta;
        private TextBox txtLimite;
        private TextBox txtValor;
        private TextBox txtSaldo;
        private RadioButton rdComum;
        private RadioButton rdEspecial;
        private DateTimePicker dtMovimento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}