using System.Collections.Generic;

class Concessionaria{
  
  private string localizacao;
  private string gerente;
  private int anodeFundacao;
  private double val;
  protected List<Veiculo> carrosDisponiveis = new List<Veiculo>();

  public Concessionaria(string l, string g, int ano){
  localizacao = l;
  gerente = g;
  anodeFundacao = ano;
}

  public string GetLocalizacao(){
    return localizacao;
  }
  public string GetGerente(){
    return gerente;
  }
  public int GetAnoFundacao(){
    return anodeFundacao;
  }

  public void SetLocalizacao(string l){
    localizacao = l;
  }
  public void SetGerente(string g){
    gerente = g;
  }
  public void SetAnoFundacao(int ano){
    anodeFundacao = ano;
  }

  public void AdicionarCarro(Veiculo x){
    carrosDisponiveis.Add(x);
  }

  public double CalcularPortfolio(){
    for (int i = 0; i < carrosDisponiveis.Count; i++){      
      val += carrosDisponiveis[i].valor;
    }
    return val;
  }



}