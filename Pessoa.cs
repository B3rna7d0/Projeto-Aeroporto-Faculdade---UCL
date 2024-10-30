namespace Aeroporto_Projeto{

class Pessoa {
    private string nome;
    private int idade;

    public Pessoa (string nome, int idade){
        this.nome = nome;
        this.idade = idade;
    }
    public string GetNome(){
        return nome;
    }
    public void SetNome(string nome){
        this.nome = nome;
    }
    public int GetIdade(){
        return idade;
    }
    public void SetIdade(int idade){
        this.idade = idade;
    }
}
}