using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define few variables
            int age = 31;
            string name = "Alfonso";
            string job = "Software Developer";

            // string concatenation
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello my name is " + name + ", i am " + age + " years old. Im a " + job + ". \n");

            // string formatting
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Helo my name is {0}, I am {1} years old. Im a {2} \n", name , age, job);

            // string interpolations
            // string Interpolations uses $ at the start which will allow us to write our variables like this {variable}
            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old. Im a {job}", name, age, job);

            // Verbatim strings
            // verbatim strings start with @ and tells the compiller to take the string literally and ignore spaces and escapes like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor                          incididunt ut labore et dolore magna aliqua. 
                                Ut enim ad minim veniam,              
                                                quis nostrud exercitation ullamco laboris nisi ut aliquip ex                    ea commodo consequat. 
                                Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore            eu fugiat nulla pariatur. 
                                
                                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit 
                                anim                    id est                                                 laborum.");


            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error message because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\user\Admin\Dog Pictures\Dog1\Nice CoolDog.png");


            // Some String functions
            string firstName = "Ricardo";
            string lastName = "Silva"; 
            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(firstName.Substring(2));
            Console.WriteLine(firstName.ToLower());
            Console.WriteLine(lastName.ToUpper());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.IndexOf('o'));



            // search for the character index in a string
            Console.Write("\n\nEnter the string here: ");
            //Read first input string. 
            string input = Console.ReadLine();

            Console.Write("Enter a character to search: ");
            //Read the character input to search. 
            char searchInput = Console.ReadLine()[0];
            // Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Prints the Index as a search result on console. 
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);
        }
    }
}
