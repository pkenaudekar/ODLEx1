//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ODLEx1
//{
//    class Reverse
//    {
//        static void Main(string[] args)
//        {
//            int number, reverse = 0, remainder;

//            Console.WriteLine("Enter 2 or more digit numbers: ");
//            number = int.Parse(Console.ReadLine());
//            while(number > 0)
//            {
//                remainder = number % 10;
//                reverse = reverse * 10 + remainder;
//                number  = number / 10;
//            }
            
//            Console.WriteLine("Reverse is: "+reverse);
//            Console.ReadKey();
//        }
//    }
//}
