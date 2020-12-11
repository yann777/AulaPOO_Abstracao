using System;
using POO_Abstracao.classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            
            boleto.Desconto(10);

            Cartao cartao = new Cartao();

            cartao.Desconto(0);

            Pagamento pagamento = new Pagamento();
            
        }
    }
}
