namespace EstudosDeCasos.Entities
{
    class BusinessAccount : Account
    {
        public double LimiteCredito { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int numero, string titular, double saldo, double limiteCredito) 
            : base(numero, titular, saldo)
        {
            LimiteCredito = limiteCredito;
        }

        public void Emprestimo(double valorEmprestimo)
        {
            if(valorEmprestimo <= LimiteCredito)
            {
                Saldo += valorEmprestimo;
            }
        }
    }
}
