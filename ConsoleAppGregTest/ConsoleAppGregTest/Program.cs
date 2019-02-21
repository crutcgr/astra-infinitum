using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGregTest
{
    class Program
    {
        static int menuChoice = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("*** Test Console ***\n\n");
            menuDisplay();
            //Console.ReadKey(true);
        }

        //Print menu options to console.
        static void menuDisplay()
        {
            menuChoice = 0;

            Console.WriteLine(
                "\nPlease choose an option below:\n\n" +
                "1) Enter a list of integers and view the sum of all even values.\n" +
                "2) Blah...\n" +
                "3) Exit"
                );

            menuChoice = int.Parse(Console.ReadLine());
            
       
                switch (menuChoice)
                {
                    case 1:
                        positiveNumberSum();
                        break;

                    case 3:
                        Console.WriteLine("Exiting..." );
                        return;

                    default:
                        Console.WriteLine("\nThat was not a vaild menu choice.");
                        menuDisplay();
                        break;


                }
            
        }

        // Obtains a list of integers from console input and displays the total of all even integers.
        static void positiveNumberSum()
        {
            try
            {
                Console.WriteLine("\nPlease enter a list of comma-separated integers.");
                int individualValue = 0;
                int total = 0;
                string tags = Console.ReadLine().Trim();
                if (tags == "H"|| tags =="E")
                {
                    return; 
                }
                List<int> TagIds = tags.Split(',').Select(int.Parse).ToList();
                Console.Write("You entered " + tags);

                Console.Write("\nEven Numbers:");
                for (int i = 0; i < TagIds.Count; i++)
                {
                    if (TagIds[i] % 2 == 0)
                    {
                        individualValue = TagIds[i];
                        total = total + individualValue;
                        Console.Write("\n" + individualValue);
                    }
                }
                Console.Write("\n" + "Sum of all even numbers in the list: " + total + "\n");
                menuDisplay();
            }
            catch (Exception)
            {
                Console.Write("** Input Format Error**\n");
                positiveNumberSum();
            }          
        }     
    }
}
