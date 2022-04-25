using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion


            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;

            //explicit conversion
            // cast double to int;
            // visto que e int nao detecta decimais o resultado de myInt sera 13 apenas.
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // typeConversion
            // transforma o double em string e mostra o numero todo.
            string myString = myDouble.ToString(); //"13.37"
            string myFloatString =  myFloat.ToString();


            Console.WriteLine(myFloatString);

            // transforma o boolean em string escrevendo false na consola
            bool sunIsShining = false; 
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);


            // converter string to int

            string myStringNum = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myStringNum);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myStringNum + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read(); 

        }
    }
}
