namespace Aeroporto_Projeto;

using System;

class Voo {
    private Aviao aviao;
    private int totalDePassageiros;
    private string localDeIda;
    private string localDeSaida;
    private DateTime horarioDeSaida;
    private DateTime horarioDeChegada;
    private Voo vooDeVolta;

    public Voo(Aviao aviao, int totalDePassageiros, string localDeIda, string localDeSaida, DateTime horarioDeSaida, DateTime horarioDeChegada){
        this.aviao = aviao;
        this.totalDePassageiros = totalDePassageiros;
        this.localDeIda = localDeIda;
        this.localDeSaida = localDeSaida;
        this.horarioDeSaida = horarioDeSaida;
        this.horarioDeChegada = horarioDeChegada;
    }
    public Voo(Aviao aviao, int totalDePassageiros, string localDeIda, string localDeSaida, DateTime horarioDeSaida, DateTime horarioDeChegada, Voo vooDeVolta){
        this.aviao = aviao;
        this.totalDePassageiros = totalDePassageiros;
        this.localDeIda = localDeIda;
        this.localDeSaida = localDeSaida;
        this.horarioDeSaida = horarioDeSaida;
        this.horarioDeChegada = horarioDeChegada;
        this.vooDeVolta = vooDeVolta;
    }
}