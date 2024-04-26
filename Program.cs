using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", Imei: "11111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", Imei: "22222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");