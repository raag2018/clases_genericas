using clases_genericas;

// Usando Caja con un entero
Caja<int> cajaDeEnteros = new Caja<int>(123);
Console.WriteLine(cajaDeEnteros.ObtenerContenido()); // Salida: 123

// Usando Caja con una cadena
Caja<string> cajaDeCadenas = new Caja<string>("Hola");
Console.WriteLine(cajaDeCadenas.ObtenerContenido()); // Salida: Hola

Caja<Persona> cajaDePersonas = new Caja<Persona>(new Persona { Nombre = "Juan" });
Console.WriteLine(cajaDePersonas.ObtenerContenido().Nombre);