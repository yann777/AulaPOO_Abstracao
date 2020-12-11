using System;

namespace POO_Abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        protected float valor;

        public string Cancelar(){
            return "";
        }
        // public string Desconto(float valor){
        //     if(valor>500){
        //         return "Desconto de 30%";
        //     }
        //     else{
        //         return "Sem Desconto";
        //     }
        // }
        public abstract string Desconto(int valor);
    }
}