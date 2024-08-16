// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Inicio de la lectura de datos");

        // Llamada asíncrona
        string result = await DownloadDataAsync();

        Console.WriteLine($"leyendo datos: {result}");
        Console.WriteLine("Datos leeidos.");
    }

    static async Task<string> DownloadDataAsync()
    {
        
        await Task.Delay(5000); // Retrasa la tarea 5 segundos 

        // Devuelve un resultado simulado de la descarga
        return "Datos descargados.";

        await Task.Delay(3000);

        return "Leyendo datos.";
    }
    
}
