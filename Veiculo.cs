class Veiculo{

public string cor{get; protected set;}
public string marca{get; protected set;}
public string modelo{get; protected set;}
public int anoFabricacao{get; protected set;}
public double valor {get; protected set;}


public Veiculo(string c, string mar, string mod , int ano){
  cor = c;
  marca = mar;
  modelo = mod;
  anoFabricacao = ano;
  valor = 0;
}


public Veiculo(string c, string mar, string mod , int ano, double val){
  cor = c;
  marca = mar;
  modelo = mod;
  anoFabricacao = ano;
  valor = val;
}

public virtual void definirValorVeiculo(double CustoFixo){}




}