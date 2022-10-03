using DesafioPOO.Models;

Smartphone nokia = new Nokia("11 99999-9999", "Nokia 3310", "123456789", 32);
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();
Smartphone iphone = new Iphone("11 99999-9999", "iPhone 11", "123456789", 64);
iphone.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();
