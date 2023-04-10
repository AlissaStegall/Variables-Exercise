namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Alissa";
            int age = 28;
            char middleInitial = 'I';
            bool over21YearsOld = true;
            double currentTemp = 100;
            decimal currentGasPrice = 4.95m;

            Console.WriteLine($"Hello, World! My name is {name} I am {age} years old.");
            Console.WriteLine($"Which means it is {over21YearsOld} I am over the age of 21");
            Console.WriteLine($"My middle name starts with an {middleInitial} for Irene.");
            Console.WriteLine($"I am from Arizona where the current temp is {currentTemp} degrees fahrenheit");
            Console.WriteLine($"Gas prices are sky high here, currently at {currentGasPrice} dollars per gallon");
        }

    }

}
