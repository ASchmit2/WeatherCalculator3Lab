using System;

namespace WeatherCalculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 3 ###");

            int temperature;
            int windSpeed;
            double windChill;
            int relativeHumidity;
            double heatIndex;
            string input = "";
            bool choice = true;

            while (choice)
            {
                Console.WriteLine("Enter the temperature");

                temperature = GetUserInput();

                if (temperature > 50)
                {
                    Console.WriteLine("Enter the relative humidity");

                    relativeHumidity = GetUserInput();

                    heatIndex = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (relativeHumidity * 0.094));

                    Console.WriteLine("The heat index is " + heatIndex);
                }
                else
                {
                    Console.WriteLine("Enter the wind speed");

                    windSpeed = GetUserInput();

                    windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                    Console.WriteLine("The wind chill is " + windChill);
                }
                Console.WriteLine("\nWould you like to quit? Type yes or no.");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    choice = false;
                }
            }
            Console.WriteLine("Program has ended...Thank you!");
        }
        static int GetUserInput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        
    }
}