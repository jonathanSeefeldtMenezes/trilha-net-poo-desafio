using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "102030", modelo: "Tijolão", imei: "0123456789X", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone(numero: "112233", modelo: "Telha", imei: "112233665544Z", memoria: 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceApp");
