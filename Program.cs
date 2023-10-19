using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(number: "8723", model: "Nokia Model 1", imei: "819263182", memory: 64);
nokia.ReceiveCall();
nokia.InstallApp("Tik Tok");

Smartphone iphone = new Iphone(number: "6245", model: "Apple Model 1", imei: "653234234", memory: 128);
iphone.ReceiveCall();
iphone.InstallApp("Tik Tok");
