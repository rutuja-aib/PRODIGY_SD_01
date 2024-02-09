
using System;

class Program
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit + 459.67) * 5 / 9;
    }

    static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static double KelvinToFahrenheit(double kelvin)
    {
        return kelvin * 9 / 5 - 459.67;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter temperature value: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter original unit (Celsius, Fahrenheit, or Kelvin): ");
        string originalUnit = Console.ReadLine().ToLower();

        switch (originalUnit)
        {
            case "celsius":
                double fahrenheit = CelsiusToFahrenheit(temperature);
                double kelvin = CelsiusToKelvin(temperature);
                Console.WriteLine($"{temperature} degrees Celsius is equal to {fahrenheit} degrees Fahrenheit and {kelvin} Kelvin.");
                break;
            case "fahrenheit":
                double celsius = FahrenheitToCelsius(temperature);
                kelvin = FahrenheitToKelvin(temperature);
                Console.WriteLine($"{temperature} degrees Fahrenheit is equal to {celsius} degrees Celsius and {kelvin} Kelvin.");
                break;
            case "kelvin":
                celsius = KelvinToCelsius(temperature);
                fahrenheit = KelvinToFahrenheit(temperature);
                Console.WriteLine($"{temperature} Kelvin is equal to {celsius} degrees Celsius and {fahrenheit} degrees Fahrenheit.");
                break;
            default:
                Console.WriteLine("Invalid unit. Please enter Celsius, Fahrenheit, or Kelvin.");
                break;
        }
    }
}