using System;

class Mascota
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Edad { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mascota mascota1 = new Mascota()
        {
            Nombre = "Max",
            Tipo = "Perro",
            Edad =5
        };

        Mascota mascota2 = new Mascota()
        {
            Nombre = "Mariposa",
            Tipo = "Gato",
            Edad = 1
        };

        Mascota mascota3 = new Mascota()
        {
            Nombre = "Tepol",
            Tipo = "Pez",
            Edad = 2
        };

        mascota1.MostrarInformacion();
        mascota2.MostrarInformacion();
        mascota3.MostrarInformacion();

        Console.ReadLine();
    }
}





