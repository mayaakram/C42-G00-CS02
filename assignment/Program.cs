﻿namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ques1
            //1 - Write a program that allows the user to enter a number then print it.
            //int Number;     //Number = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine(Number);
            #endregion

            #region ques2
            //  2 - Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string X = "maya";            //int Y;
            //bool Flag = int.TryParse(X, out Y);            //Console.WriteLine(Flag); //Flag= false //y =0
            //Console.WriteLine(Y);
            #endregion

            #region ques3
            //  3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float X = 2.3F;      //float Y = 3.3F;
            //float Result = X + Y;      //Console.WriteLine(Result);//5.6
            #endregion

            #region ques4
            //   4 - Write C# program that Extract a substring from a given string.
            //string FullString = "hello world session 2 c sharp";      //string SubString = FullString.Substring(12, 7);
            //Console.WriteLine($"string is {FullString} ,substring is {SubString}");
            #endregion

            #region ques5      
            // 5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int X = 6;
            //int Y = X;            //++X;
            //Console.WriteLine(Y);//still 6 because its only a copy of the value
            #endregion


            #region ques6       
            //6- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen    

            //          Point P1;  //          P1 = new Point();

            //          Point P2;
            //          P2 = new Point();
            //          P2 = P1;
            //          P1.X = 10;  //          Console.WriteLine(P2.X); //10  beacuse 2 variables refrence the same object(bs hya btdy zero//)

            #endregion


            #region ques7       
            // 7 - Write C# program that take two string variables and print them as one variable 

            //string Message1 = "maya";            //string Message2 = "akram";
            //Console.WriteLine($"{Message1} {Message2}");

            #endregion
        }
    }
}
