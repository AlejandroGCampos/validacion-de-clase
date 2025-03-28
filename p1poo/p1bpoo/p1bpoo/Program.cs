
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");
//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");
//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
//CarroDeCombustion miFerrari = new CarroDeCombustion(2004, "Rojo", "Ferrari");
//Motocicleta miMoto = new Motocicleta(2013, "Gris", "Yamaha mt-09");
//Camion miCamion = new Camion(2010, "Blanco", "Kenworth");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

//miFerrari.InformacionVehiculo();
//miFerrari.cargarGasolina();
//Console.WriteLine("El nivel de gasolina es: {0}", miFerrari.NivelGasolina());


Chofer piloto1 = new Chofer("Ale", 25, "A");
Chofer piloto2 = new Chofer("Lupe", 21, "M");


Console.WriteLine("----------------------------------");
Console.WriteLine("Piloto 1: ");
piloto1.mostrarInformacion();
Console.WriteLine("\n");
Console.WriteLine("Piloto 2: ");
piloto2.mostrarInformacion();
Console.WriteLine("----------------------------------");
Console.WriteLine("\n");

Vehiculo sedan = new Vehiculo(2025, "Azul", "Honda");
string respuesta;
respuesta = sedan.asignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);
sedan.acelerar(25);
Console.WriteLine("\n");


Motocicleta honda = new Motocicleta(2025, "Rojo", "Honda");
string respuesta2;
respuesta2 = honda.asignarPiloto(piloto2);
Console.WriteLine(respuesta2);
respuesta2 = honda.Encender();
Console.WriteLine(respuesta2);
honda.acelerar(35);