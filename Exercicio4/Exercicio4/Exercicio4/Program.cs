using Exercicio4;

Carro carro1 = new Carro("Ford", "Mustang");
Carro carro2 = new Carro("Chevrolet", "Camaro");
Carro carro3 = new Carro("Volkswagen", "Fusca");

//aumenta e diminui a vlcd
carro1.Acelerar(290);
carro1.Desacelerar(80);

carro2.Acelerar(280);
carro2.Desacelerar(90);

carro3.Acelerar(90);
carro3.Desacelerar(50);

Console.ReadKey();
