using System;
using EstudosDeCasos.Entities;

namespace EstudosDeCasos
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount conta = new BusinessAccount(3700, "Mário", 320.00, 600.00);

            Console.WriteLine(conta.Saldo);
        }
    }
}
