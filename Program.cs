// See https://aka.ms/new-console-template for more information
using PooExamples.Vehicles;




Car miCarroPequeño = new Car(4,40,"Compacto");
Car miCarroDeportivo = new Car(8,70, "Sport");
Car miCarroDeCarreras = new Car(12,30, "Super Auto");
Car miCarroFake = new Car(3,30, "Fake");

miCarroPequeño.FillGas(15);
miCarroDeportivo.FillGas(22);
miCarroDeCarreras.FillGas(35);

miCarroFake.Run(30);
miCarroPequeño.Run(100);
miCarroDeportivo.Run(50);
miCarroDeCarreras.Run(200);


miCarroPequeño.Stop();
miCarroDeportivo.Stop();
miCarroDeCarreras.Stop();

Console.ReadLine();
