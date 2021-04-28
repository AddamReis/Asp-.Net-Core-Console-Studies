namespace EstudosDeCasos.Entities
{
    class Account
    {
        public int Numero { get; private set; }
        public string  Titular { get; private set; }
        public double  Saldo { get; protected set; }

        public Account()
        {
        }

        public Account(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }
    }
}
