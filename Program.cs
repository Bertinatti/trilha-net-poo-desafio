using DesafioPOO.Models;

// Testando a implementação para a classe Nokia
Nokia nokia = new Nokia(numero: "(11) 99999-9999", modelo: "Nokia Xperia XA1 PLUS", imei: "99999999", memoria: "128 GB");
nokia.Ligar();
nokia.InstalarAplicativo("WhastApp");
nokia.ReceberLigacao();

Console.WriteLine();

// Testando a implementação para a classe Iphone
Iphone iphone = new Iphone(numero: "(11) 99999-9999", modelo: "Iphone 14 PLUS", imei: "66666666", memoria: "512 GB" );
iphone.Ligar();
iphone.InstalarAplicativo("Facebook App.");
iphone.ReceberLigacao();