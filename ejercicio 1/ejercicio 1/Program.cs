// See https://aka.ms/new-console-template for more information
using System;

// Definición de la interfaz ICalculable
public interface ICalculable
{
    decimal CalcularSalario();
}

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Direccion { get; set; }
    public int Salario { get; set; }

    // Constructor que inicializa los atributos
    public Persona(string nombre, int edad, string direccion)
    {
        Nombre = nombre;
        Edad = edad;
        Direccion = direccion;
    }

    // Constructor sin parámetros
    public Persona()
    {
        Nombre = "Willian";
        Edad = 17;
        Direccion = "cl 22";
        Salario = 3000000;
    }

    // información de la persona en consola
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"Salario: {Salario}");
    }
}

public class Empleado : Persona, ICalculable
{
    public int SalarioBase { get; set; }
    public int DiasTrabajados { get; set; }

    // Constructor con parámetros
    public Empleado(string nombre, int edad, string direccion, int salarioBase, int diasTrabajados)
        : base(nombre, edad, direccion)
    {
        SalarioBase = salarioBase;
        DiasTrabajados = diasTrabajados;
    }

    // interfaz ICalculable
    public decimal CalcularSalario()
    {
        
        return (SalarioBase / 30m) * DiasTrabajados;
    }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Salario Base: {SalarioBase}");
        Console.WriteLine($"Días Trabajados: {DiasTrabajados}");
        Console.WriteLine($"Salario Calculado: {CalcularSalario()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Leer información para Persona
        Console.WriteLine("Ingrese la información de la Persona:");
        Console.Write("Nombre: ");
        string nombrePersona = Console.ReadLine();

        Console.Write("Edad: ");
        int edadPersona = int.Parse(Console.ReadLine());

        Console.Write("Dirección: ");
        string direccionPersona = Console.ReadLine();

        // Crear una instancia de la clase Persona usando la información proporcionada
        Persona persona = new Persona(nombrePersona, edadPersona, direccionPersona);
        Console.WriteLine("\nInformación de la Persona:");
        persona.MostrarInformacion();

        // Leer información para Empleado
        Console.WriteLine("\nIngrese la información del Empleado:");
        Console.Write("Nombre: ");
        string nombreEmpleado = Console.ReadLine();

        Console.Write("Edad: ");
        int edadEmpleado = int.Parse(Console.ReadLine());

        Console.Write("Dirección: ");
        string direccionEmpleado = Console.ReadLine();

        Console.Write("Salario Base: ");
        int salarioBase = int.Parse(Console.ReadLine());

        Console.Write("Días Trabajados: ");
        int diasTrabajados = int.Parse(Console.ReadLine());

        // Crear una instancia de la clase Empleado usando la información proporcionada
        Empleado empleado = new Empleado(nombreEmpleado, edadEmpleado, direccionEmpleado, salarioBase, diasTrabajados);
        Console.WriteLine("\nInformación del Empleado:");
        empleado.MostrarInformacion();
    }
}






