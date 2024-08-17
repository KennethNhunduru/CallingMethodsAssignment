using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{ 
    class Program
    {
        static void Main(string[] args)
        {            
            //SETTING UP THE VARIABLE THE PROGRAM NEEDS.
            
            //requesting user input for the arithmetic operations.
            Console.WriteLine("Enter the integer number you want to do the math operations on: ");
            //capturing the user input.
            int userInput = Convert.ToInt32(Console.ReadLine());                       
            
            int num1 = userInput;
                        
            //CALLING EACH METHOD IN TURN, PASSING THE USER INPUT TO THE METHOD.

            /*Since the methods to be called are STATIC, they can be called directly 
            from a different class through their class called 'Arithmetic'*/
            
            Arithmetic.AdditionSum(num1);
            Arithmetic.Multiply(num1);
            Arithmetic.ModuloRemainder(num1);

            Console.ReadLine();
        }
    }
}
