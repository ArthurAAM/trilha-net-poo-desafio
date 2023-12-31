using DesafioPOO.Models;

Console.WriteLine("Testes iPhone:");
Iphone iphone = new(numero: "", modelo:"", imei:"", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


Console.WriteLine("Testes Nokia:");
Nokia nokia = new(numero: "", modelo:"", imei:"", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");