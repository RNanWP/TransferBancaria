namespace TransferenciaBancaria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSaldoConta1;
        private System.Windows.Forms.Label lblSaldoConta2;
        private System.Windows.Forms.TextBox txtValorTransferencia;
        private System.Windows.Forms.Button btnTransferirConta2ParaConta1;
        private System.Windows.Forms.ComboBox cbContas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSaldoConta1 = new System.Windows.Forms.Label();
            this.lblSaldoConta2 = new System.Windows.Forms.Label();
            this.txtValorTransferencia = new System.Windows.Forms.TextBox();
            this.btnTransferirConta2ParaConta1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.btnTransferirConta1ParaConta2 = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.cbContas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSaldoConta1
            // 
            this.lblSaldoConta1.AutoSize = true;
            this.lblSaldoConta1.Location = new System.Drawing.Point(247, 115);
            this.lblSaldoConta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoConta1.Name = "lblSaldoConta1";
            this.lblSaldoConta1.Size = new System.Drawing.Size(103, 13);
            this.lblSaldoConta1.TabIndex = 0;
            this.lblSaldoConta1.Text = "Saldo Conta 1: R$ 0";
            // 
            // lblSaldoConta2
            // 
            this.lblSaldoConta2.AutoSize = true;
            this.lblSaldoConta2.Location = new System.Drawing.Point(247, 162);
            this.lblSaldoConta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoConta2.Name = "lblSaldoConta2";
            this.lblSaldoConta2.Size = new System.Drawing.Size(103, 13);
            this.lblSaldoConta2.TabIndex = 1;
            this.lblSaldoConta2.Text = "Saldo Conta 2: R$ 0";
            // 
            // txtValorTransferencia
            // 
            this.txtValorTransferencia.Location = new System.Drawing.Point(37, 269);
            this.txtValorTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTransferencia.Multiline = true;
            this.txtValorTransferencia.Name = "txtValorTransferencia";
            this.txtValorTransferencia.Size = new System.Drawing.Size(203, 20);
            this.txtValorTransferencia.TabIndex = 2;
            this.txtValorTransferencia.Text = "Valor da Transferência";
            // 
            // btnTransferirConta2ParaConta1
            // 
            this.btnTransferirConta2ParaConta1.Location = new System.Drawing.Point(72, 364);
            this.btnTransferirConta2ParaConta1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferirConta2ParaConta1.Name = "btnTransferirConta2ParaConta1";
            this.btnTransferirConta2ParaConta1.Size = new System.Drawing.Size(119, 53);
            this.btnTransferirConta2ParaConta1.TabIndex = 3;
            this.btnTransferirConta2ParaConta1.Text = "Transferir para conta 1";
            this.btnTransferirConta2ParaConta1.UseVisualStyleBackColor = true;
            this.btnTransferirConta2ParaConta1.Click += new System.EventHandler(this.btnTransferirConta2ParaConta1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Renan Santos de Oliveira - 2222200490";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(366, 306);
            this.txtValorSaque.Multiline = true;
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(203, 20);
            this.txtValorSaque.TabIndex = 6;
            this.txtValorSaque.Text = "Valor do Saque";
            // 
            // btnTransferirConta1ParaConta2
            // 
            this.btnTransferirConta1ParaConta2.Location = new System.Drawing.Point(72, 306);
            this.btnTransferirConta1ParaConta2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferirConta1ParaConta2.Name = "btnTransferirConta1ParaConta2";
            this.btnTransferirConta1ParaConta2.Size = new System.Drawing.Size(119, 53);
            this.btnTransferirConta1ParaConta2.TabIndex = 8;
            this.btnTransferirConta1ParaConta2.Text = "Transferir para conta 2";
            this.btnTransferirConta1ParaConta2.UseVisualStyleBackColor = true;
            this.btnTransferirConta1ParaConta2.Click += new System.EventHandler(this.btnTransferirConta1ParaConta2_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(408, 364);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(119, 53);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // cbContas
            // 
            this.cbContas.DisplayMember = "Saque de Conta";
            this.cbContas.Items.AddRange(new object[] {
            "Saque Conta 1",
            "Saque Conta 2"});
            this.cbContas.Location = new System.Drawing.Point(366, 268);
            this.cbContas.Name = "cbContas";
            this.cbContas.Size = new System.Drawing.Size(203, 21);
            this.cbContas.TabIndex = 10;
            this.cbContas.Text = "Saque de Conta";
            this.cbContas.ValueMember = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 448);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnTransferirConta1ParaConta2);
            this.Controls.Add(this.txtValorSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransferirConta2ParaConta1);
            this.Controls.Add(this.txtValorTransferencia);
            this.Controls.Add(this.lblSaldoConta2);
            this.Controls.Add(this.lblSaldoConta1);
            this.Controls.Add(this.cbContas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Transferência de Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Button btnTransferirConta1ParaConta2;
        private System.Windows.Forms.Button btnSacar;
    }
}
