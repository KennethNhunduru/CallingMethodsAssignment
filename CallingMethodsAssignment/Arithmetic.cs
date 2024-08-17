using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    //OBJECTS are items (usually real world things) that can be represented by a computer program.
    //The type of the object would be its CLASS.
    //Objects have STATE and BEHAVIOUR.
    //The state of the object would be its PROPERTIES or things that identify it.
    //The behaviour of the object would be its METHODS or things that it can do.

    //DECLARING THE CLASS OF THE ARITHMETIC OBJECTS.
    public class Arithmetic //this is public so the class is accessible to the Program class.
    {
        //IDENTIFYING THE PROPERTIES OF THE ARITHMETIC CLASS.

        //declaring the first operand which will be the user input.
        public int num1;
        //declaring the second integer variable since most arithmetic oerations require two operands.
        public int num2;

        //DECLARING THE CONSTRUCTOR METHOD.

        //a constructor is a special method in a class used to create an instance of a class object.
        /*the name of the constructor MUST match name of the class in which it is declared
          for the compiler to identify it as a constructor.*/
        //the constructor can be used to assign arguments to fields when creating an object of the class.

        /*declaring the Arithmetic constructor method in the Arithmetic class
          which takes the one integer, user input, as its only parameter.*/
        /*the constructor sets the userInput value of the Arithmetic object
          to the given integer and the second operand to fifty (50), say.*/
        public Arithmetic(int num1) //constructor declared in the Arithmetic class
        {
            this.num1 = num1; //first operand is identified as a property of the Sum class.
            this.num2 = 5; //second operand is identified as a property of the Sum class.        
        }

        //CREATING THE FIRST ARITHMETIC METHOD

        /*The first method, AdditionSum method, takes the user input and adds it to the second operand
          and returns the sum.*/

        public static void AdditionSum(int num1)
        {
            int result = num1 + 5;            
            Console.WriteLine("The sum of your integer: " + num1 + " " + "and the integer 5 is: " + result);           
        }

        //CREATING THE SECOND ARITHMETIC METHOD

        /*The second method, Multiply method, takes the user input and multiplies it with the second operand
         and returns the product.*/

        public static void Multiply(int num1)
        {
            int result = num1 * 5;            
            Console.WriteLine("The product of your integer: " + num1 + " " + "and the integer 5 is: " + result);            
        }

        //CREATING THE THIRD ARITHMETIC METHOD

        /*The third method, ModuloRemainder method, computes the integer remainder after dividing 
        the user input by the integer 5.*/

        public static void ModuloRemainder(int num1)
        {
            int result = num1 % 5;            
            Console.WriteLine("The integer remainder from dividing your integer: " + num1 + " " + "by the integer 5 is: " + result);
        }     
    }
}
