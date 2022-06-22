using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova3_semestre1
{
    public partial class frmMovimento : Form
    {
        bool achou = false;
        bool deposito;
        bool saque;
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 255);
            _listConta = contaBancaria.geraContas();

            _listConta.Add(new contaBancaria()
            {
                CodigoConta = "1",
                Tipo = 0,
                Saldo = 100,
                Limite = 200
            });
            _listConta.Add(new contaBancaria()
            {
                CodigoConta = "2",
                Tipo = 1,
                Saldo = 150,
                Limite = 300
            });
            _listConta.Add(new contaBancaria()
            {
                CodigoConta = "3",
                Tipo = 0,
                Saldo = 330,
                Limite = 790
            });
            _listConta.Add(new contaBancaria()
            {
                CodigoConta = "4",
                Tipo = 1,
                Saldo = 777,
                Limite = 888
            });


        }
        private void frmMovimento_Load(object sender, EventArgs e)
        {

        }

        private void rdComum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConta_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void txtConta_CursorChanged(object sender, EventArgs e)
        {

        }

        private void frmMovimento_Leave(object sender, EventArgs e)
        {
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (achou)
            {
                this.Size = new Size(685, 365);
                saque = false;
                deposito = true;
                txtConta.Enabled = false;
                txtLimite.Enabled = false;
                txtSaldo.Enabled = false;
                rdComum.Enabled = false;
                rdEspecial.Enabled = false;
                btnDepositar.Enabled = false;
                btnSair.Enabled = false;
                btnSacar.Enabled = false;
            }
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {

            string nconta = Convert.ToString(txtConta.Text.Trim());
            foreach (contaBancaria contaBancaria in _listConta)
            {
                if (contaBancaria.CodigoConta.Equals(nconta))
                {
                    txtSaldo.Text = contaBancaria.Saldo.ToString();
                    txtLimite.Text = contaBancaria.Limite.ToString();
                    if (contaBancaria.Tipo == 0)
                    {
                        rdComum.Checked = true;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                    }
                    this.Size = new Size(685, 365);
                    achou = true;
                    break;
                }
            }
            if (!achou)
            {
                this.Size = new Size(685, 255);
                MessageBox.Show("Conta não encontrada!", "Aviso do sistema");
                txtConta.Select();
            }
        }

        private void dtMovimento_Leave(object sender, EventArgs e)
        {
            if ((dtMovimento.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtMovimento.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Data Inválida!");
                dtMovimento.Focus();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtValor.Text.Trim()) < 0)
                {
                    MessageBox.Show("Erro! Valores negativos não são aceitos", "Aviso do sistema");
                    txtValor.Focus();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Erro no valor inserido (apenas números são aceitos)", "Erro");
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            foreach (contaBancaria contaBancaria in _listConta)
            {
                string nconta = Convert.ToString(txtConta.Text.Trim());
                if (contaBancaria.CodigoConta.Equals(nconta))
                {
                    if (deposito)
                    {
                        contaBancaria.Saldo += Convert.ToDouble(txtValor.Text.Trim());
                        txtSaldo.Text = Convert.ToString(contaBancaria.Saldo);
                        MessageBox.Show("Valor atualizado");
                        break;
                    }                    
                    
                    if (saque)
                    {
                        contaBancaria.Saldo -= Convert.ToDouble(txtValor.Text.Trim());
                        txtSaldo.Text = Convert.ToString(contaBancaria.Saldo);
                        MessageBox.Show("Valor atualizado");
                        break;                        
                    }

                }
            }

            this.Size = new Size(685, 255);
            txtLimite.Enabled = false;
            txtSaldo.Enabled = false;
            rdComum.Enabled = false;
            rdEspecial.Enabled = false;
            btnDepositar.Enabled = true;
            btnSair.Enabled = true;
            btnSacar.Enabled = true;
            txtConta.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (achou)
            {
                this.Size = new Size(685, 365);
                saque = true;
                deposito = false;
                txtConta.Enabled = false;
                txtLimite.Enabled = false;
                txtSaldo.Enabled = false;
                rdComum.Enabled = false;
                rdEspecial.Enabled = false;
                btnDepositar.Enabled = false;
                btnSair.Enabled = false;
                btnSacar.Enabled = false;
            }
        }
    }
}
