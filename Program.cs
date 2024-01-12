using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia (numero: "98765", modelo: "Nokia K-9", imei:"11111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");
Console.WriteLine("The New System........\n");

Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone (numero: "258987", modelo: "Iphone 83", imei:"99999999", memoria: 82);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");