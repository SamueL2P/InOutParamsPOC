using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParamsPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //in

            int inNumber = 3;
            ViewNumber(in inNumber);

            //out 

            Console.WriteLine("\nNumber from out funtion : " + ChangeNumber(out int outNumber)); //No need to give initial value to variable while using out
                                                                                                 //Also it can be defined directly in function 

            //===============================================================================================================
           
            // Try Parse POC
            //Try parse is used to convert string representation of number to an integer.
            //If the string cannot be converted, then it returns false i.e. a Boolean value.
            //It provides a way to handle exceptions and prevent halting of the program.

            int myNumber;
            Console.WriteLine("Enter no for Try parse:");
            if (int.TryParse(Console.ReadLine(), out myNumber))
                Console.WriteLine("Conversion successful : " + myNumber);
            else
                Console.WriteLine("Give number properly");
            Console.WriteLine("Thank you"); //This will be executed regardless of whether the string is converted or not instead of showing an error.


            //==================================================================================================================

            //Params array
            //It is used when the number of parameters used is unknown 
            //Thus any number of arguments can be passed
            //The arguments for params should always be passed at the end.
             
            PrintFruits(23, "Apple", "Banana"); //passing 3 arguments
            PrintFruits(23, "Apple", "Banana" , "Orange"); //passing 4 arguments


        }
        //in variable
        static void ViewNumber(in int number) {
            // number = 2; Throws error because even though a method parameter is passed by reference,
                             // but the called method viewNumber cannot modify the argument number. 

            Console.WriteLine("Number from in funtion :" + number); //Can be used to display the results or number in this case
        }

        //out variable

        static int ChangeNumber(out int outNumber)
        {
            outNumber = 5; //Variable has to be updated when passed as out (ie - updation is compulsory or it will give error)
            return outNumber;
        }

        //params array

        static void PrintFruits(int number, params string[] names) { //params array written at end after int age
            Console.Write("\nparams array consists of : \n");
            foreach (string name in names) {
              
                Console.WriteLine(name); //Writeline for params array 
            }
        }
    }   
        
}
