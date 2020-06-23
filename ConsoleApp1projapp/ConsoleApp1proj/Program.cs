using System;
using System.IO.Pipes;

namespace ConsoleApp1proj
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            
            
            
            
            int[] numbers1 = { 1, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int number in numbers1)//this print out all the numbers
            {
                Console.WriteLine(number);//to commint out do Ctrl 'k' 'c'. to uncomment
                //do Ctrl 'k' 'u'.
            }//you do not change the ammounts with the foreach. you cannot change it like the for. 






            int[] numbers = { 1, 1, 2, 3, 4, 5, 6, 7}; //this is our array variable

            for (int k = 0; k < numbers.Length; k++) //k is the index, not the numbers. 
            {
                numbers[k] += 1;/*a forloop has rthe abitlity to changew the 
                                 * individual values inside an array*///this changed the numbers
                                    //in the array. 
                Console.WriteLine(numbers[k]); //this will print out the array
                Console.WriteLine($"{numbers[k]} is at the {k} index in the array.");
                
            }//you need the [k] after the numbers in the string. 
            
            
            
            for(int j = 0; j < 10; j++) //for statement
            {
                Console.WriteLine("Hello World");
                
            }

            int i = 0;//this is needed for the while and do-while statements
            do //do-while statement
            {
                Console.WriteLine("Hello World");
                i++;
            } while (i < 10);

            while (i < 10) //while statement
            {
                Console.WriteLine("Hello World");
                i++;
            }
        }
    }
}
