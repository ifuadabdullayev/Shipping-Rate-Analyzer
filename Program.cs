using System;

namespace PackageExpress
{
    class Program
    {
        // Define constants for reusability and easier maintenance
        private const float MAX_WEIGHT = 50.0f;
        private const float MAX_DIMENSION_SUM = 50.0f;
        private const float QUOTE_DIVISOR = 100.0f;
        private const string WELCOME_MESSAGE = "Welcome to Package Express. Please follow the instructions below.";
        private const string WEIGHT_PROMPT = "Please enter the package weight:";
        private const string WIDTH_PROMPT = "Please enter the package width:";
        private const string HEIGHT_PROMPT = "Please enter the package height:";
        private const string LENGTH_PROMPT = "Please enter the package length:";
        private const string HEAVY_ERROR = "Package too heavy to be shipped via Package Express. Have a good day.";
        private const string SIZE_ERROR = "Package too big to be shipped via Package Express.";
        private const string THANK_YOU = "Thank you!";
        
        static void Main(string[] args)
        {
            // Start with welcome message
            Console.WriteLine(WELCOME_MESSAGE);
            
            // Get weight input from user
            Console.WriteLine(WEIGHT_PROMPT);
            float weight = float.Parse(Console.ReadLine());
            
            // Check weight limit
            if (weight > MAX_WEIGHT)
            {
                Console.WriteLine(HEAVY_ERROR);
                Console.ReadLine(); // Keep console open
                return;
            }
            
            // Get dimension inputs from user
            Console.WriteLine(WIDTH_PROMPT);
            float width = float.Parse(Console.ReadLine());
            
            Console.WriteLine(HEIGHT_PROMPT);
            float height = float.Parse(Console.ReadLine());
            
            Console.WriteLine(LENGTH_PROMPT);
            float length = float.Parse(Console.ReadLine());
            
            // Check dimension sum limit
            float dimensionSum = width + height + length;
            if (dimensionSum > MAX_DIMENSION_SUM)
            {
                Console.WriteLine(SIZE_ERROR);
                Console.ReadLine(); // Keep console open
                return;
            }
            
            // Calculate shipping quote
            float quote = (width * height * length * weight) / QUOTE_DIVISOR;
            
            // Display formatted quote to user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine(THANK_YOU);
            
            // Keep console window open
            Console.ReadLine();
        }
    }
}