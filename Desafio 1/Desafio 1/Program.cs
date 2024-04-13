using System;
class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }
    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }
    public double Sumar(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Restar(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN; 
        }
        return num1 / num2;
    }
}
class CalculadoraCientifica : Calculadora
{
    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
    }
    public double Potencia(double baseNum, double exponente)
    {
        return Math.Pow(baseNum, exponente);
    }

    public double Raiz(double num)
    {
        return Math.Sqrt(num);
    }

    public double Modulo(double num1, double num2)
    {
        return num1 % num2;
    }

    public double Logaritmo(double num)
    {
        return Math.Log(num);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadoraNormal = new Calculadora("Casio", "12345");
        Console.WriteLine("Suma: " + calculadoraNormal.Sumar(5, 3));
        Console.WriteLine("Resta: " + calculadoraNormal.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + calculadoraNormal.Multiplicar(5, 3));
        Console.WriteLine("División: " + calculadoraNormal.Dividir(5, 3));
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica("HP", "98765");
        Console.WriteLine("Potencia: " + calculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada: " + calculadoraCientifica.Raiz(25));
        Console.WriteLine("Módulo: " + calculadoraCientifica.Modulo(10, 3));
        Console.WriteLine("Logaritmo natural: " + calculadoraCientifica.Logaritmo(10));
    }
}
