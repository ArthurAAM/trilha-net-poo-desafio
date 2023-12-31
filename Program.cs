using DesafioPOO.Models;

Console.WriteLine("Testes iPhone:");
Iphone iphone = new(numero: "(11) 98765-4321", modelo: "iPhone 14 Pro Max", imei: "390485-99-894647-7", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("Testes Nokia:");
Nokia nokia = new(numero: "(61) 91234-5678", modelo: "Nokia C2", imei: "652357-12-832893-5", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");