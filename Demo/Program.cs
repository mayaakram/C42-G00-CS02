﻿using System.ComponentModel;
using System.Drawing;

namespace Day_02
{
    class Program
    {


        static void Main(string[] args)
        {

            #region value type vs refrence type video
            //Point P1;
            /////declare for refrence of type "point" refering to null            /////this refrence 'p1' can refer to an object from type 'point' or other type inherting from 'point'
            /////CLR wiil allocate 4 bytes for the refrence at stack            /////CLR will allocate 0 bytes at HEAP

            //P1 = new Point();            /////new
            /////1.allocate required number of bytes in HEAP (object size +CLR overhead variables )            /////2.initialize (cross out) allocated bytes with default value of its datatype
            /////3. call user-defined constructor if exists            /////4. assign the refrence to a allocated object
            //Console.WriteLine(P1.X);//0
            //Console.WriteLine(P1.Y);//0
            //Point P2 = new Point(); //unreachable object            //P2 = P1;
            //P2.X = 10;            //Console.WriteLine(P1.X);

            #endregion


            #region fractions and discard video
            /////fractions ..default value for fractions is double so we need f m to specify the dt
            //float X = 5.3F; //double Y = 4.43;
            //decimal Z = 9999.88M;
            /////discard (just for redability) but printed as 100000000 3ady //long Number = 100_000_000;
            //Console.WriteLine(Number);
            #endregion


            #region operators
            #region unary operator
            /////unary operator (works on one operand(variable))     //int x = 10;
            /////1 ++     /////1.1 prefix [increment and then print]
            //Console.WriteLine(++x);// 11     //                       //1.2 postfix [print and then increment]
            //Console.WriteLine(x++); //10
            /////2 --
            /////2.1 prefix //2.2 postfix    
            #endregion
            #region binary operator
            /////binary operator
            //int Sum, Num01, Num02;     //Sum = Num01 + Num02;
            //Sum = Num01 - Num02;     //Sum = Num01 * Num02;
            //Sum = Num01 / Num02;     //Sum = Num01 % Num02;

            #endregion
            #region assignment operators
            /////assignment operator     //int X;
            //X += 4; //x=x+4     //X -= 4;
            //X *= 4;     //X /= 4;
            //X %= 4;
            #endregion
            #region relational operators[comparisons]
            /////relational operators
            //int X = 6, Y = 5;     //Console.WriteLine(X==Y);
            //Console.WriteLine(X != Y);     //Console.WriteLine(X > Y);
            //Console.WriteLine(X < Y);     //Console.WriteLine(X >= Y);
            //Console.WriteLine(X <= Y);
            #endregion

            #region logical operator    
            /////logical operator //short circuit
            //Console.WriteLine(!false);     //Console.WriteLine(false&&true);//short circuit
            //Console.WriteLine(false || true);
            #endregion

            #region  bitwise operators[long circuit]
            //// ///bitwise operators
            //// Console.WriteLine(~0);     //// Console.WriteLine(false&true); //long circuit
            //// //               0000 & 0001  =0000     //// Console.WriteLine(true | false);
            //// /*
            ////  Complimo 0 =1     ////  Complimo 1=0 
            //// ~ de alcomplimo
            //// Al & alwa7da de lazem t check 3al alatnin 7ata lw mn alawel false fana 3aref ano false 
            ////34an hya lazem ht7wel ala2awel w check 34an t3rf
            //// Fa lw 3ndy condition ana m7tago ytnfz regardless hw true wala false yb2a hst3ml de
            //// W al or nfs alklam
            //// Lazem tnfz 34an ytl3 result t7wlha l binary      //// Fa kda kda al2 conditions hytnfzo
            ////  */
            #endregion

            #region ternary operator
            /////ternary operator     //int X = 10, Y = 5;
            //string Message = X > Y ? "X is more than Y" : X < Y ? "X is less than Y" : "x equals Y";
            //Console.WriteLine(Message);
            #endregion 
            #endregion

            #region operators periority [precedence] video            ////operators periority [precedence] and asscoitivity[lw same priority yb2a from left to right]
            ///*
            // 1.unary operator (prefix)            // 2.Round braces()
            // 3. * / %            // 4. + -
            // */
            //int a = 20;            //int b = 10;
            //int c = 15;            //int d = 5;
            //int Equation;
            //Equation=(a+b)*c/d;            //Equation = ((a + b) * c )/ d;
            #endregion


        }




    } 

}




