namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(string valor)
        {
            if (Double.TryParse(valor, out var val))
                this.Saldo += val;
        }

        public void Saca(string valorDigitado)
        {
            if (Double.TryParse(valorDigitado, out var val) && this.Saldo > 0 && (this.Saldo - val > 0))
                this.Saldo -= val;
        }
    }
}
