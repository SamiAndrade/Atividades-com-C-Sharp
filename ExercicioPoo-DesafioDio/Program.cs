using DesafioPOO.Models;

Smartphone celular1 = new Nokia("1199999999", "Nokia", "111222333444555", 16);
Smartphone celular2 = new Iphone("1199999999", "Iphone 13", "111222333444555", 64);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Snake");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");