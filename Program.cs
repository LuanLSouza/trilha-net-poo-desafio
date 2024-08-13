using DesafioPOO.Models;
Iphone iphone1 = new Iphone("123323", "15pro", "asidi123", 256);
Nokia nokia1 = new Nokia("1234124", "s23", "b12h3bh1", 128);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("calc");

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("mercado livre");
// TODO: Realizar os testes com as classes Nokia e Iphone
