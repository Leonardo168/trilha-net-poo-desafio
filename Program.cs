using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(99) 9999-9999", modelo: "G42", imei: "111111111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
