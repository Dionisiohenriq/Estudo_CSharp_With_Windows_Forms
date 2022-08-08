using System.Globalization;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            conta.Numero = 1;

            var cliente = new Cliente("Victor");
            conta.Titular = cliente;

            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = conta.Numero.ToString();
            textoSaldo.Text = conta.Saldo.ToString(CultureInfo.InvariantCulture);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            var valorDigitado = textoDeposito.Text;
            this.conta.Deposita(valorDigitado);
            this.textoSaldo.Text = this.conta.Saldo.ToString(CultureInfo.InvariantCulture);
            MessageBox.Show("Deposito efetuado com sucesso!");
        }

        private void botaoSaca_Click(object sender, EventArgs e)
        {
            var valorDigitado = textoSaca.Text;
            this.conta.Saca(valorDigitado);
            this.textoSaldo.Text = this.conta.Saldo.ToString(CultureInfo.InvariantCulture);
            MessageBox.Show("Saque efetuado com sucesso!");
        }
    }
}