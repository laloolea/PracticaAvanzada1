using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaProgramacionAvanzada
{
    public class Delegates
    {
        public Delegates()
        {
        }

        public Func<List<int>, List<int>> CheckEvenNumbers = (numbers) =>
        {
            return numbers.Where(m => m % 2 == 0).ToList();
        };

        public Func<List<int>, List<int>> CheckOddNumbers = (numbers) =>
        {
            return numbers.Where(m => m % 2 != 0).ToList();
        };
        public Func<List<int>, List<int>> AscendingOrder = (numbers) =>
        {
            return numbers.OrderBy(m=>m).ToList();
        };
        public Func<List<int>, List<int>> DescendingOrder = (numbers) =>
        {
            return numbers.OrderByDescending(m => m).ToList();
        };
        public Predicate<int> CheckMultiply3 = (number) =>
        {
            return number %3==0;
        };

        public Action<string> PrintText = (text) =>
        {
            Console.WriteLine(text);
        };


        public Func<List<int>, int> MaxValue = (numbers) =>
         {
             return numbers.Max(m => m);
         };

        public Func<List<int>, int> MinValue = (numbers) =>
        {
            return numbers.Min(m => m);
        };
        public Func<List<int>, double> AverageValue = (numbers) =>
        {
            return numbers.Average();
        };
        public Func<List<int>, double> RMSValue = (numbers) =>
        {
            double rms = 0;
            foreach(int i in numbers)
            {
                rms += Math.Pow(i, 2);
            }
            rms = rms / numbers.Count();

            rms = Math.Sqrt(rms);

            return rms;
        };

        public Action<string> Greeting = (name) =>
        {
            Console.WriteLine($"Hello {name} How are you today?");
        };
        public Func<string, string, string> GetInitials = (name, lastName) =>
          {
              char[] firstLetters = {  lastName[0],name[0]};
              string initials = new string(firstLetters);
              return initials;
          };

        public Predicate<int> CanDrink = age => age >= 18;


    }
}
