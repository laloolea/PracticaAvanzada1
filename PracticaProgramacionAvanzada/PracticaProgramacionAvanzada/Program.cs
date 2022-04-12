using System;
using System.Collections.Generic;

namespace PracticaProgramacionAvanzada
{
    internal delegate WritingInstrument exampleContravariance(Pen pen);

    class Program
    {
        static void Main(string[] args)
        {
            Delegates ejemplos = new Delegates();

            List<int> numbers= new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            Console.WriteLine("Original numbers list: ");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("1.-Create a function that lists the even numbers");

            List<int> EvenNumbers =ejemplos.CheckEvenNumbers(numbers);
            Console.WriteLine("Even numbers list: ");

            foreach (int i in EvenNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("2.-Create a function that lists the odd numbers");

            List<int> oddNumbers = ejemplos.CheckOddNumbers(numbers);
            Console.WriteLine("Odd numbers list: ");
            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("3.-Create a function that orders a list that enters with parameter in ascending order");
           
            List<int> ascending = ejemplos.AscendingOrder(numbers);
            foreach (int i in ascending)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("4.-Create a function that orders a list that enters with parameter in descending order");

            List<int> descending = ejemplos.DescendingOrder(numbers);
            foreach (int i in descending)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("5.- Create a function that checks if the value is a multiple of 3");
            int numberToCheck = 6;
            Console.WriteLine($"The value {numberToCheck} is multiple of 3: " + ejemplos.CheckMultiply3(numberToCheck));
            numberToCheck = 5;
            Console.WriteLine($"The value {numberToCheck} is multiple of 3: " + ejemplos.CheckMultiply3(numberToCheck));

            Console.WriteLine("6.- Create delegate that writes a text in the console that is passed by parameter");

            ejemplos.PrintText("Hello world how are you");

            Console.WriteLine("7.- Create a function that gets the maximum, minimum, and average value");


            List<int> listMaxMinAverage = new List<int>()
            {
                10,2,4,6,1,2222,333,2,1,-4
            };
            Console.WriteLine($"The list to check the max value: ");

            foreach (int i in listMaxMinAverage)
            {
                Console.WriteLine(i);
            }

            int maxValue = ejemplos.MaxValue(listMaxMinAverage);
            Console.WriteLine($"The max value of the list is {maxValue}");

            Console.WriteLine("8.- Create a function that gets the Minimum value");
            int minValue = ejemplos.MinValue(listMaxMinAverage);
            Console.WriteLine($"The max value of the list is {minValue}");

            Console.WriteLine("9.- Create a function that obtains the average value");

            double average = ejemplos.AverageValue(listMaxMinAverage);
            Console.WriteLine($"The Average value of the list is: {average}");

            Console.WriteLine("10.- Create a function that calculates the RMS value of a list of numbers \nList to check: ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine($"The RMS value of the list is: {ejemplos.RMSValue(numbers)}");

            Console.WriteLine("11.- Create a free example of Invariant, covariance and contravariance. ");


            Invariance ejemploInvariance = new Invariance();
            ejemploInvariance.listaNumeros = new List<int>() { 1, 2, 3, 4, 5 };
            //This is invariance, i cant give a different tipe than the specified, if you wanna change type use IEnumerable

            //Covariance
            WritingInstrument measureInstrument = new Pen();// I can use the constructor from a derivated class from the specified type

            //Contravariance
            exampleContravariance delegateContravariance = WritePermanent;
  
            delegateContravariance += Write;
            delegateContravariance += WritePermanent;
            delegateContravariance += WriteMore;
            //This delegate is expecting type Pen but in the last one it receives a Writing Instrument!
        
           


            Console.WriteLine("12.- Create a free example of delegates Action<T>, Func<in T, out TResult> and Predicate < T > ");

            Console.WriteLine("Example Action");
            ejemplos.Greeting("John");


            Console.WriteLine("Example Func");
            string name="Eduardo";
            string lastName = "Olea";

            Console.WriteLine($"Hello {name} {lastName} your initials are: " + ejemplos.GetInitials(name,lastName));
            

            Console.WriteLine("Example Predicate");
            int age = 25;
            Console.WriteLine($"This person is {age}, let's check if he can drink: " + ejemplos.CanDrink(age));



        }
        static Pen WritePermanent(Pen pen)
        {
            Console.WriteLine("Writing permanent");
            return new Pen();

        }
        static WritingInstrument Write(Pen pen)
        {
            Console.WriteLine("Writing");
            return new WritingInstrument();
        }
        static WritingInstrument WriteMore(WritingInstrument writingInstrument)
        {
            Console.WriteLine("Writing More");
            return new WritingInstrument();
        }
      

    }
}
        