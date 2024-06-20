namespace assignment
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

            #region ques8
            /*
   8- Write a program that calculates the simple interest given the principal amount,    rate of interest, and time. The formula for simple interest is 
     Interest = (principal * rate * time ) /100.     */

            //double Principal, Rate, Time, Interest;
            //Principal = 2000.55;
            //Rate = .20;
            //Time = 3.5;
            //Interest = (Principal * Rate * Time) / 100;
            //Console.WriteLine(Interest);
            #endregion

            #region ques9
            /*
           9- Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and  height in meters. The formula for BMI is
        BMI = (Weight)/(Height*Height)   */
            //double Weight, Height, Bmi;

            //Console.Write("Enter the weight (in kg): ");    //Weight = double.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter the height (in meters): ");
            //Height = double.Parse(Console.ReadLine() ?? "0");
            //Bmi = (Weight) / (Height * Height);
            //Console.WriteLine(Bmi);
            #endregion

            #region ques10
            /*  10- Write a program that uses the ternary operator to check if the temperature is too hot, too cold,or just good. Assign the result in variable then display the result. Assume that below 10 degrees is "Just Cold",
         above 30 degrees is "Just Hot", and anything else is "Just Good". */

            //int Temp;
            //Temp = int.Parse(Console.ReadLine() ?? "0");
            //string Message = Temp < 10 ? "just cold" : Temp > 30 ? "just hot" : "just good";
            //Console.WriteLine(Message);
            #endregion


            #region ques11
            /*
11- Write a program that takes the date from user and displays it in various formats using string interpolation.Ex :
Today’s date : 20 , 11 , 2001Today's date : 20 / 11 / 2001
Today's date : 20 – 11 – 2001
    */
            //Console.Write("Enter the day");            //int day = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter the month");
            //int month = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter the year");            //int year = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine($"date is {day} , {month} , {year}");            //Console.WriteLine($"date is {day} / {month} / {year}");
            //Console.WriteLine($"date is: {day} - {month} - {year}");
            #endregion

            #region ques12
            //ques 12  c)  The event is on 06/14/2024
            /* ques 13    int d;
             * d= Convert.ToInt32(!(30 < 20));              *   Console.WriteLine(d);
             * f) A value 1 will be assigned to d.             */
            #endregion


        }
    }
}
