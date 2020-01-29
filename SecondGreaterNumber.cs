using System;
using System.Collections.Generic;
using System.Text;

namespace ODLEx1
{
    class SecondGreaterNumber
    {
        static void Main()
        {
            int inputNumbers, i, j, temp;
            int[] arrayNumbers = new int[15];

            Console.WriteLine("Enter the numbers to be entered: ");
            inputNumbers = int.Parse(Console.ReadLine());

            for (i = 0; i < inputNumbers; i++)
            {
                Console.Write("element - {0} : ", i);
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < arrayNumbers.Length - 1; i++)

                for (j = i + 1; j < arrayNumbers.Length; j++)

                    if (arrayNumbers[i] < arrayNumbers[j])
                    {

                        temp = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = temp;
                    }
            /*
            for (i = 0; i < inputNumbers; i++)
            {
                Console.Write("{0}  ", arrayNumbers[i]);
            }*/

            Console.WriteLine("The second greatest number is: " + arrayNumbers[1]);
            Console.ReadKey();
        }
    }
}
