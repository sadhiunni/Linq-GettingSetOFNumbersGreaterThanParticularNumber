using System;
using System.Linq;
using System.Collections.Generic;
/* Get the number of numbers and the numbers in the list from the user.
 * Get the number greater than which , the numbers in the list have to be displayed from the user. 
 * Displays the list of numbers greater then the number entered.
 */
namespace Linq_GettingSetOFNumbersGreaterThanParticularNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> SetNumbers = new List<int>();
            int num,greaterThan;
            
            Console.WriteLine("Enter the number of numbers you want to enter : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            
            Console.WriteLine("Please input the numbers : ");
            for (int i=0;i<num;i++) 
            {
                SetNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("\n");
            
            Console.WriteLine("Enter the number greater than which you want the numbers in the list to be displayed : ");
            greaterThan = Convert.ToInt32(Console.ReadLine());
            var GreaterThanList = from int x in SetNumbers
                                  where x > greaterThan
                                  select x;
            Console.WriteLine("\n");
            
            Console.WriteLine("The numbers in the list which are greater than "+greaterThan);
            foreach (var number in GreaterThanList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
