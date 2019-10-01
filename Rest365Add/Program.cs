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
             List<String> dList = new List<String>();
            dList.Add(",");
            dList.Add("/n");
            string formula = " ";

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            String[] getValuesToAdd()
            {
                Console.WriteLine("Hello Welcome to a simple adding console app, please enter your numbers you would like to add");
                String numbers = Console.ReadLine().ToString();
                String[] numbersSeperated = numbers.Split(dList.ToArray(), StringSplitOptions.None);


                if (numbers.Substring(0, 1) == "//")
                {

                    numbersSeperated = getCustomDelimiters(numbers);

                }

                return numbersSeperated;
            }
            String[] numbersToAdd = getValuesToAdd();
            double totalAdded=runAdd(numbersToAdd);

            String[] getCustomDelimiters(String delimiters2Parse)
            {
                String[] numbersSeperated = delimiters2Parse.Split(dList.ToArray(), StringSplitOptions.None);

                delimiters2Parse.Remove(0, 1);
                numbersSeperated = delimiters2Parse.Split(dList.ToArray(), StringSplitOptions.None);
                if(numbersSeperated[0].Substring(0,0)=="[")
                {
                    numbersSeperated[0].Remove(numbersSeperated[0].Length, numbersSeperated[0].Length);
                    numbersSeperated[0].Remove(0, 0);
                    String[] st = { "][" };
                    String[] customDelimiters = numbersSeperated[0].Split(st, StringSplitOptions.None);
                    foreach (String s in customDelimiters )
                    {
                        dList.Add(s);
                    }
                    numbersSeperated = numbersSeperated.Skip(1).ToArray();

                }
                else
                {
                    numbersSeperated[0].Remove(numbersSeperated[0].Length, numbersSeperated[0].Length);
                    numbersSeperated[0].Remove(0, 0);
                    numbersSeperated = numbersSeperated.Skip(1).ToArray();

                    dList.Add(numbersSeperated[0]);
                }

                numbersSeperated = delimiters2Parse.Split(dList.ToArray(), StringSplitOptions.None);

                return numbersSeperated;
            }
           
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
                    if (double.Parse(st) < 0)      //blocks negative numbers
                    {
                        
                        Console.WriteLine("Sorry you entered a negative number please enter only positive numbers please");
                        return -1;
                    }
                    else
                    {
                        if (double.Parse(st) > 1000)  //blocks numbers greater than 1000
                        { }
                        else
                        {
                            if (formula.Length <2)
                            {
                                formula = st;
                            }
                            formula += "+" + st;
                            total += double.Parse(st);

                        }
                    }




                }
                return total;
            }
            while(totalAdded==-1)
            {
                numbersToAdd = getValuesToAdd();
                totalAdded = runAdd(numbersToAdd);


            }
            Console.WriteLine("Your total is: "+ totalAdded);
            Console.WriteLine("Your formula was: "+ formula);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
