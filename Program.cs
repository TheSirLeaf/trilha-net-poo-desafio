using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia1 = new Nokia(numero: "1111111", modelo: "Modelo legal", imei: "6969696969", memoria: 4096);
Smartphone iphone1 = new Iphone(numero: "0000000", modelo: "Modelo menos legal", imei: "11119999", memoria: 2048);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");