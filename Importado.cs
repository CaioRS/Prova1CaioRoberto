class Importado:Veiculo{

  public Importado (string c, string mar, string mod , int ano, double val) : base(c, mar, mod , ano, val){}

  public override void definirValorVeiculo(double CustoFixo){
    valor = CustoFixo *3.0 + 0.6*CustoFixo + CustoFixo/5;
  }


}