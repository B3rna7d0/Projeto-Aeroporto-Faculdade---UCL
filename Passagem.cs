namespace Aeroporto_Projeto
{
    class Passagem
    {
        private Voo voo;
        private string assento;
        private int id;
        private double preco;
        private bool fezCheckIn;

        public Passagem(Voo voo, string assento, int id, double preco, bool fezCheckIn)
        {
            this.voo = voo;
            this.assento = assento;
            this.id = id;
            this.preco = preco;
            this.fezCheckIn = fezCheckIn;
        }

        public Voo GetVoo()
        {
            return voo;
        }

        public void SetVoo(Voo voo)
        {
            this.voo = voo;
        }

        public string GetAssento()
        {
            return assento;
        }

        public void SetAssento(string assento)
        {
            this.assento = assento;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public bool GetFezCheckIn()
        {
            return fezCheckIn;
        }

        public void SetFezCheckIn(bool fezCheckIn)
        {
            this.fezCheckIn = fezCheckIn;
        }
    }
}
