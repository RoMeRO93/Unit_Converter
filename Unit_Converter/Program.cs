using System;

class UnitConverterApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to Unit Converter App!");

        bool continueConverting = true;

        while (continueConverting)
        {
            Console.WriteLine("\nWhat would you like to convert?");
            Console.WriteLine("1. Length");
            Console.WriteLine("2. Temperature");
            Console.WriteLine("3. Mass");
            Console.WriteLine("4. Volume");
            Console.WriteLine("5. Currency");
            Console.WriteLine("6. Time");
            Console.WriteLine("7. Speed");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertLength();
                    break;
                case "2":
                    ConvertTemperature();
                    break;
                case "3":
                    ConvertMass();
                    break;
                case "4":
                    ConvertVolume();
                    break;
                case "5":
                    ConvertCurrency();
                    break;
                case "6":
                    ConvertTime();
                    break;
                case "7":
                    ConvertSpeed();
                    break;
                case "8":
                    continueConverting = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nThank you for using the Unit Converter App!");
    }

    static void ConvertLength()
    {
        Console.WriteLine("\nLength Converter");
        Console.WriteLine("1. Meters to Feet");
        Console.WriteLine("2. Feet to Meters");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = value * 3.28084;
                Console.WriteLine($"{value} meters = {convertedValue} feet");
                break;
            case "2":
                convertedValue = value / 3.28084;
                Console.WriteLine($"{value} feet = {convertedValue} meters");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }

    static void ConvertTemperature()
    {
        Console.WriteLine("\nTemperature Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = (value * 9 / 5) + 32;
                Console.WriteLine($"{value} degrees Celsius = {convertedValue} degrees Fahrenheit");
                break;
            case "2":
                convertedValue = (value - 32) * 5 / 9;
                Console.WriteLine($"{value} degrees Fahrenheit = {convertedValue} degrees Celsius");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }

    static void ConvertMass()
    {
        Console.WriteLine("\nMass Converter");
        Console.WriteLine("1. Kilograms to Pounds");
        Console.WriteLine("2. Pounds to Kilograms");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = value * 2.20462;
                Console.WriteLine($"{value} kilograms = {convertedValue} pounds");
                break;
            case "2":
                convertedValue = value / 2.20462;
                Console.WriteLine($"{value} pounds = {convertedValue} kilograms");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }

    static void ConvertVolume()
    {
        Console.WriteLine("\nVolume Converter");
        Console.WriteLine("1. Liters to Gallons");
        Console.WriteLine("2. Gallons to Liters");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = value * 0.264172;
                Console.WriteLine($"{value} liters = {convertedValue} gallons");
                break;
            case "2":
                convertedValue = value / 0.264172;
                Console.WriteLine($"{value} gallons = {convertedValue} liters");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }

    static void ConvertCurrency()
    {
        Console.WriteLine("\nCurrency Converter");
        Console.WriteLine("1. USD to EUR");
        Console.WriteLine("2. EUR to USD");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = value * 0.88; // Exchange rate as of current date
                Console.WriteLine($"{value} USD = {convertedValue} EUR");
                break;
            case "2":
                convertedValue = value / 0.88; // Exchange rate as of current date
                Console.WriteLine($"{value} EUR = {convertedValue} USD");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }

    static void ConvertTime()
    {
        Console.WriteLine("\nTime Converter");
        Console.WriteLine("1. Minutes to Hours");
        Console.WriteLine("2. Hours to Minutes");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = value / 60;
                Console.WriteLine($"{value} minutes = {convertedValue} hours");
                break;
            case "2":
                convertedValue = value * 60;
                Console.WriteLine($"{value} hours = {convertedValue} minutes");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }

    static void ConvertSpeed()
    {
        Console.WriteLine("\nSpeed Converter");
        Console.WriteLine("1. Kilometers per Hour to Miles per Hour");
        Console.WriteLine("2. Miles per Hour to Kilometers per Hour");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double convertedValue = 0;

        switch (choice)
        {
            case "1":
                convertedValue = value * 0.621371;
                Console.WriteLine($"{value} kilometers per hour = {convertedValue} miles per hour");
                break;
            case "2":
                convertedValue = value / 0.621371;
                Console.WriteLine($"{value} miles per hour = {convertedValue} kilometers per hour");
                break;
            default:
                Console.WriteLine("Invalid choice. Conversion failed.");
                break;
        }
    }
}
