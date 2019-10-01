using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest365Add
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello Welcome to a simple adding console app, please enter your numbers you would like to add");
            String numbers = Console.ReadLine().ToString();
            List<String> dList = new List<String>();
            dList.Add(",");
            dList.Add("/n");
            //dList.ToArray();
            String[] values = numbers.Split(dList.ToArray(), StringSplitOptions.None);
            double totalAdded=runAdd(values);
      
           
            //bool isFinished = true;
            //bool isFirst = true;
            //foreach(string st in values)
            //{
            //    var isNumeric = double.TryParse(st, out double n);

            //    if (!isNumeric && isFirst)
            //    {
            //        dList.Add(st);
            //        isFirst = false;
            //    }
            //}

            double runAdd(string[] input)
            {
                double total = 0;
                foreach (string st in input)
                {
                    if (double.Parse(st) < 0)
                    {
                        
                        Console.WriteLine("Sorry you entered a negative number please enter only positive numbers please");

                    }
                    else
                    {
                        if (double.Parse(st) > 1000)
                        { }
                        else
                        {
                            total += double.Parse(st);

                        }
                    }




                }
                return total;
            }
            Console.WriteLine("Your total is: "+ totalAdded);

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
