using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferenciaBancaria
{
    public partial class Form1 : Form
    {
        private ContaBancaria conta1;
        private ContaBancaria conta2;

        public Form1()
        {
            InitializeComponent();
            conta1 = new ContaBancaria(2222200490L, "Renan Oliveira");
            conta2 = new ContaBancaria(2222200491L, "Maria Silva");

            conta1.Depositar(1000); // Depósito inicial na Conta 1
            conta2.Depositar(500);   // Depósito inicial na Conta 2
            AtualizarSaldos();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (cbContas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma conta.");
                return;
            }

            decimal valor;
            if (decimal.TryParse(txtValorSaque.Text, out valor))
            {
                ContaBancaria contaSelecionada = cbContas.SelectedItem.ToString() == "Conta 1" ? conta1 : conta2;

                if (contaSelecionada.Sacar(valor))
                {
                    MessageBox.Show($"Saque de {valor:C2} realizado com sucesso da {contaSelecionada.Titular}!");
                }
                else
                {
                    MessageBox.Show("Falha no saque: saldo insuficiente.");
                }

                AtualizarSaldos();
                txtValorSaque.Clear();
            }
            else
            {
                MessageBox.Show("Valor inválido para saque.");
            }
        }

        private void txtValorSaque_Enter(object sender, EventArgs e)
        {
            if (txtValorSaque.Text == "Valor do Saque")
            {
                txtValorSaque.Text = "";
                txtValorSaque.ForeColor = Color.Black;
            }
        }

        private void txtValorSaque_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(txtValorSaque.Text, out valor))
            {
                txtValorSaque.Text = valor.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtValorSaque.Text = "Valor do Saque";
            }
        }

        private void txtValorTransferencia_Enter(object sender, EventArgs e)
        {
            if (txtValorTransferencia.Text == "Valor da Transferência")
            {
                txtValorTransferencia.Text = "";
                txtValorTransferencia.ForeColor = Color.Black;
            }
        }

        private void txtValorTransferencia_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(txtValorTransferencia.Text, out valor))
            {
                txtValorTransferencia.Text = valor.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtValorTransferencia.Text = "Valor da Transferência";
            }
        }

        private void AtualizarSaldos()
        {
            lblSaldoConta1.Text = $"Saldo 1: {conta1.ConsultarSaldo():C2}";
            lblSaldoConta2.Text = $"Saldo 2: {conta2.ConsultarSaldo():C2}";
        }

        private void btnTransferirConta1ParaConta2_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(txtValorTransferencia.Text, out valor))
            {
                if (conta1.Transferir(conta2, valor))
                {
                    MessageBox.Show("Transferência de Conta 1 para Conta 2 realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha na transferência: saldo insuficiente.");
                }
                AtualizarSaldos();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.");
            }
        }

        private void btnTransferirConta2ParaConta1_Click(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(txtValorTransferencia.Text, out valor))
            {
                if (conta2.Transferir(conta1, valor))
                {
                    MessageBox.Show("Transferência de Conta 2 para Conta 1 realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha na transferência: saldo insuficiente.");
                }
                AtualizarSaldos();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

