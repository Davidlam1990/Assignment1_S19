﻿/* 
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
    Author: David Lam
    UID: U00959333
    Date: 1/22/2019
    Comments: 
        + Assignment 1 – Programming Introduction
        + This C# Console application code defines methods to do simple operations
        + Methods include:
            - printPrimeNumbers
            - getSeriesResult
            - decimalToBinary
            - binaryToDecimal
            - printTriangle
            - computeFrequency
------------------------------------------------------------------------------------
------------------------------------------------------------------------------------
*/

using System;
using System.Diagnostics;

namespace Assignment1_S19
{
    class Program
    {
        // Main method
        public static void Main()
        {
            /*Method 1 : printPrimeNumbers*/
            // Declare variable a and b as starting and ending range.
            int a = 5, b = 15;
            // Passing a and b to method printPrimeNumbers to return all prime numbers between a and b
            printPrimeNumbers(a, b);
            Console.ReadLine();

            /*Method 2 : getSeriesResult*/
            //Declare variable n1 as number of terms of the series
            int n1 = 5;
            //Passing n1 to method getSeriesResult to calculate and store result to varible r1 with type double
            double r1 = getSeriesResult(n1);
            //Write out the result r1
            Console.WriteLine("The sum of the series is: " + r1);
            Console.ReadLine();

            /*Method 3 : decimalToBinary*/
            //Declare variable n2 as decimail number (base 10) to be converted to binary (base 2)
            long n2 = 15;
            //Passing n2 to method decimalToBinary to convert to binary number and store result to r2
            long r2 = decimalToBinary(n2);
            //Write out the result r2
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            Console.ReadLine();

            /*Method 4 : binaryToDecimal*/
            //Declare variable n3 as binary (base 2) to be converted to decimail number(base 10)
            long n3 = 1111;
            //Passing n3 to method binaryToDecimal to convert to decimal number and store result to r3
            long r3 = binaryToDecimal(n3);
            //Write out the result r3
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);
            Console.ReadLine();

            /*Method 5 : printTriangle*/
            // Declare variable n4 as number of lines for the pattern
            int n4 = 5;
            // Passing n4 to method printTriangle to dislay result 
            printTriangle(n4);
            Console.ReadLine();

            /*Method 6 : computeFrequency*/
            // Declare arr
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            // Passing array arr to method computeFrequency to computes the frequency of each element in the array
            computeFrequency(arr);
            Console.ReadLine();

            // write your self-reflection here as a comment
            /*
            ---------------------------------------------------------------------------------------------------------------------------------------------------------
            ---------------------------------------------------------------------------------------------------------------------------------------------------------
            The assignment helps to develop familiarity with many essential programming constructs by introducing the use of variables, loops, arrays, method… 
            which is a good starting point for any beginners who may want to get into application development path later in their career. 
            It also is a good introduction of how C# programming language works with using Visual Studio as IDE. 
            Familiarity with GitHub is also another plus point of the assignment. 
            Even though the assignment is to focus on introductory structures, I found myself facing many challenges as well. 
            The assignment is a good practice for problems solving and apply those logics into programming which is an important skill to have in IT industry. 
            I think the assignment can be improved by providing more output solutions so that students can check their logic to make sure it’s doing what’s expected. 
            Free method formats is also help for thinking outside the box. 
            ---------------------------------------------------------------------------------------------------------------------------------------------------------
            ---------------------------------------------------------------------------------------------------------------------------------------------------------
            */

        } // end of Main method

        /*Method printPrimeNumbers*/
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                // Write your code here
                // Prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.    
                // If the user provide a valid range, then apply logic to find all prime numbers
                if ( x < y)
                {
                    // Iterate through the range between x and y using a For Loop
                    for (int i = x; i <= y; i++)
                    {
                        // Initilize variable Prime = 0
                        int Prime = 0;
                        // Iterate through the range between 1 and i using another For Loop
                        for (int j = 1; j < i; j++)
                        {
                            // check if i % j == 0 , then add 1 to Prime
                            if (i % j == 0)
                            {
                                Prime++;
                            } // End of if

                            // check if Prime == 2 then break 
                            if (Prime == 2)
                            {
                                break;
                            } // End of if
                        } // End of for

                        // check if Prime != 2 and i > 1, write out i as Prime number 
                        if (Prime != 2 && i > 1)
                        {
                            Console.Write(i + " ");
                        } // End of if

                        // set Prime = 0
                        Prime = 0;
                    } // End of for
                } // End of if
                // If the user provide an invalid range , display a message
                else
                {
                    Console.WriteLine("Please provide a valid range ...");
                } // End of else
            } // End of try
            // catch bad inputs
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            } // End of catch
        } // End of printPrimeNumbers

        /*Method getSeriesResult*/
        public static double getSeriesResult(int n)
        {
            try
            {
                // Write your code here
                // This method computes the series 1/2 – 2!/3 + 3!/4 – 4!/5 --- n

                // Check if inputs are greater than 0 , then apply logic below
                if(n > 0)
                {
                    // Initialize variables Odd_Sum = 0, Even_Sum = 0, total = 0;
                    double Odd_Sum = 0, Even_Sum = 0, total = 0;
                    //  Initialize Factorial = 1
                    int Factorial = 1;
                    // Iterate from 1 to n (input) using a For Loop
                    for (int i = 1; i <= n; i++)
                    {
                        // calculate factorial for each Iterator
                        Factorial *= i;

                        // check if even terms, then sum will be negative
                        if (i % 2 == 0)
                        {
                            Even_Sum -= Factorial / (i + 1.0);
                        } // End of if
                          // else will be odd terms, then sum will be positive
                        else
                        {
                            Odd_Sum += Factorial / (i + 1.0);
                        } // End of else
                    }
                    // result will be total of Even_Sum and Odd_Sum, round to three decimal places using Math.Round
                    return total = Math.Round(Even_Sum, 3) + Math.Round(Odd_Sum, 3);

                } //End of if
                // check if bad inputs, display the message
                else
                {
                    Console.WriteLine("Please provide a positive integer number, otherwise result will be default to 0 !!!");
                } // End of else

            } //End of try
            // catch bad inputs  
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            } // End of catch

            //return 0 as default result
            return 0;
        } // End of getSeriesResult

        /*Method decimalToBinary*/
        public static long decimalToBinary(long n)
        {
            try
            {
                // Write your code here
                // This method converts a number from decimal (base 10) to binary (base 2).
                // Check of inputs are equal to 0 , then return 0
                if (n == 0)
                {
                    return 0;
                } // End of if
                // Check if inputs are greater than 0, then apply logic below
                else if (n > 0)
                {
                    // Write your code here
                    // Initialize variable Remainder
                    long Remainder;
                    // Initialize Result as an emty string
                    string Result = "";
                    // Using while loop to apply logic as long as n > 0
                    while (n > 0)
                    {
                        // set Remainder = n % 2
                        Remainder = n % 2;
                        // set n = n/2 for the next iterator
                        n /= 2;
                        // store result = Remainder + Result , need to convert Remainder to sting for concatenating string result
                        Result = Remainder.ToString() + Result;
                    } // End of While loop

                    // return Result to type long using Convert.ToInt64
                    return Convert.ToInt64(Result);

                } // End of else if
                // check if bad inputs, display the message 
                else
                {
                    Console.WriteLine("Please provide a positive integer number, otherwise result will be default to 0 !!!");
                } // End of else

            } // End of try
            // catch bad inputs
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            } // End of catch
            //return 0 as default result
            return 0;
        } // End of decimalToBinary

        /*Method binaryToDecimal*/
        public static long binaryToDecimal(long n)
        {
            try
            {
                // Write your code here
                // This method converts a number from binary (base 2) to decimal (base 10).
                // Check of inputs are equal to 0 , then return 0
                if (n == 0)
                {
                    return 0;
                } //End of if
                // Check if inputs are greater than 0, then apply logic below
                else if (n > 0)
                {
                    // Intialize variables result = 0, baseVal = 1 and remainder 
                    long result = 0, baseVal = 1, remainder;
                    // Using while loop to apply logic as long as n > 0
                    while (n > 0)
                    {
                        // set remainder = n % 10 
                        remainder = n % 10;
                        // store result = result + remainder * baseVal
                        result += remainder * baseVal;
                        // set n = n/10 for the next iterator
                        n /= 10;
                        // set baseVal = baseVal*2 for each iterator
                        baseVal *= 2;
                    } // End of While loop
                    // return result
                    return result;
                } // End of else if
                // check if bad inputs, display the message 
                else
                {
                    Console.WriteLine("Please provide a positive number for better result other than 0 as default !!!");
                } //End of else

            } // End of try
            // catch bad inputs
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            } // End of catch

            // return default result to 0
            return 0;
        } //End of binaryToDecimal

        /*Method printTriangle*/
        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                // n – number of lines for the pattern, integer (int)
                // check if input is greater than 0 , then apply logic
                if (n > 0)
                {
                    //declare variables i, j, k
                    int i, j, k;
                    //loop through n numbers using for loop
                    for (i = 1; i <= n; i++)
                    {
                        //write empty space for each iterator from i to less than n
                        for (j = i; j < n; j++)
                        {
                            Console.Write(" ");
                        } // end of for

                        //write * for each iterator from 1 to  k < (i * 2)
                            for (k = 1; k < (i * 2); k++)
                        {
                            Console.Write("*");
                        } // end of for

                        // Write New line
                        Console.WriteLine();
                    } // end of for
                    Console.ReadLine();
                } // End of if
                // check if bad inputs, display the message 
                else
                {
                    Console.WriteLine("Please provide a positive number greater than 0 !!!");
                } // End of else

            } // End of try
            // catch bad inputs
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            } // End of catch
        } // End of printTriangle

        /*Method computeFrequency*/
        public static void computeFrequency(int[] a)
        {
            try
            {
                // Write your code here
                // Check if input array is not empty , then apply logic
                if (a.Length > 0)
                {
                    // This method computes the frequency of each element in the array
                    // Declare arry fre with the size of arry a input to store the frequency of each element
                    int[] fre = new int[a.Length];
                    // Declare variable i , j, count for iterator and count
                    int i, j, count;

                    //initialize all element in fre array to -999
                    for (i = 0; i < a.Length; i++)
                    {
                        fre[i] = -999;
                    } // end of for

                    // loop through from 0 to less than the size of array a using for loop
                    for (i = 0; i < a.Length; i++)
                    {
                        // initially set count = 1
                        count = 1;

                        // loop through from 1 position to the right of i (i+1) in array a
                        for (j = i + 1; j < a.Length; j++)
                        {
                            // Chech occurance to the right 
                            // if match 
                            if (a[i] == a[j])
                            {
                                // increase the count by 1 
                                count++;
                                // set value of that index in Array = 0 , which mean already count . 
                                fre[j] = 0;
                            } // end of if
                        }

                        // Assign total count for each element as long as they're not 0
                        if (fre[i] != 0)
                        {
                            fre[i] = count;
                        } // end of if
                    } // end of for

                    // print out result using for loop
                    for (i = 0; i < a.Length; i++)
                    {
                        // print out result set as long as fre[i] != 0
                        if (fre[i] != 0)
                        {
                            Console.WriteLine("{0}   {1} \n", a[i], fre[i]);
                        } // end of if
                    } // end of for
                } // end if if
                // check if bad input, dislay message
                else
                {
                    Console.WriteLine("Please provide a valid input of array...");
                } // end of else
                
            } // end of try
            // catch bad inputs
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            } // end of catch
        } // end of computeFrequency
    } // end of class
}  // end of namespace

