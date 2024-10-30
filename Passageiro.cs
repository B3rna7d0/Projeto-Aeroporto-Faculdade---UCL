namespace Aeroporto_Projeto
{

    class Passageiro : Pessoa {
        private Passagem passagem;
        private double pesoBagagem;

        public Passageiro(string nome, int idade, Passagem passagem, double pesoBagagem) : base (nome, idade){
            this.passagem = passagem;
            this.pesoBagagem = pesoBagagem;
        }
    }

}