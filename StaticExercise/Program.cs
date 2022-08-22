

using StaticExercise;

Console.WriteLine("Hello! Please enter the number you would like to convert from Fahrenheit to Celsius");

var numCheck = double.TryParse(Console.ReadLine(), out var userFahrTemp);

while(!numCheck)
{
    Console.WriteLine("Please enter a number: ");
    numCheck = double.TryParse(Console.ReadLine(), out userFahrTemp);
}

Console.WriteLine($"{userFahrTemp} to Celsius is: ");
Console.WriteLine($"{TempConverter.FahrenheitToCelsius(userFahrTemp)}°C");

Console.WriteLine("------------------------------------");

Console.WriteLine("Enter the number you would like to convert from Celsius to Fahrenheit");

numCheck = double.TryParse(Console.ReadLine(), out var userCelsTemp);

while(!numCheck)
{
    Console.WriteLine("Please enter a number: ");
    numCheck = double.TryParse(Console.ReadLine(), out userCelsTemp);
}


Console.WriteLine($"{userCelsTemp} to Fahrenheit is: ");
Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(userCelsTemp)}°F");