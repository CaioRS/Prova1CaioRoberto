class Nacional:Veiculo{

  public Nacional (string c, string mar, string mod , int ano, double val) : base(c, mar, mod , ano, val){}

  public override void definirValorVeiculo(double CustoFixo){
    valor = CustoFixo *1.5 + 0.2*CustoFixo + CustoFixo/10;
  }


}