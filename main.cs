using System;

class Program {
  public static void Main (string[] args) {
    Nacional carro1 = new Nacional ("vermelho","ford","fiesta",2021,10000);
    Importado carro2 = new Importado ("preto","ferrari","Italia",2021,80000);
    Concessionaria Conc = new Concessionaria ("Serra","Marlon",1995);

    carro1.definirValorVeiculo(1000);
    carro2.definirValorVeiculo(100000);

    Console.WriteLine("O valor real do veiculo1 é :" + carro1.valor);
    Console.WriteLine("O valor real do veiculo2 é :" + carro2.valor);

    Conc.AdicionarCarro(carro1);
    Conc.AdicionarCarro(carro2);

    Console.WriteLine("O valor do portfolio é :" + Conc.CalcularPortfolio());
    


    


  }
}