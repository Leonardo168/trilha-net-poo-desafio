using DesafioPOO.Models;

System.Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(99) 9999-9999", modelo: "G42", imei: "111111111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(88) 8888-8888", modelo: "iPhone 17 Pro Max", imei: "222222222222222", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");