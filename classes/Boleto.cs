using System;

namespace POO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public void Registrar(){
            Console.WriteLine("Registrado");
        }

        public override string Desconto(int valor)
        {
            return "";
        }
    }
}