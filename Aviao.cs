namespace Aeroporto_Projeto{

    class Aviao {
        private string nome;
        private double peso;
        private int capacidade;
        private int tanque;
        private int capacidadeMalas; // Em KG

        public Aviao(string nome, double peso, int capacidade, int tanque, int capacidadeMalas)
        {
            this.nome = nome;
            this.peso = peso;
            this.capacidade = capacidade;
            this.tanque = tanque;
            this.capacidadeMalas = capacidadeMalas;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public double GetPeso()
        {
            return peso;
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public int GetCapacidade()
        {
            return capacidade;
        }

        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }


        public int GetTanque()
        {
            return tanque;
        }

        public void SetTanque(int tanque)
        {
            this.tanque = tanque;
        }

        public int GetCapacidadeMalas()
        {
            return capacidadeMalas;
        }

        public void SetCapacidadeMalas(int capacidadeMalas)
        {
            this.capacidadeMalas = capacidadeMalas;
        }
    }
}
