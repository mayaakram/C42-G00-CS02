using System.ComponentModel;
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

            #region string formatting
            /////string formatting
            ///// equation:3+4=7            //int x = 3, y = 4;
            //string message = "equation" + x + "+" + y + "=" + (x + y);            //Console.WriteLine(message);

            /////fe kza tare2a tanya 34an concat bel + we74 awy 3ala memory 34an string is fixed array fa kol ma ygm4 y7ot fr string gded             /////1. composite string
            // message =string.Format("equation:{0}+{1}={2}",x,y,(x + y));
            /////2.string interpolation            /////$ manupulation oprator
            /////js -- message =`equation :${x}+${y}=${x+y}`            /////fe c# ashl bkteer w b7ot $ mara wa7da bs 
            /////            //message = $"equation{x}+{y}={x + y}";
            //Console.WriteLine(message);
            #endregion

            #region explicit vs implicit casting video
            #region implicit casting
            //int X = 8;
            //long Y = X; //implicit casting [safe casting]   //Console.WriteLine(Y); //8  

            #endregion

            #region Explicit Casting ex1 
            //long X = 8;
            //int Y = (int)X; //explicit casting[unsafe casting]   //Console.WriteLine(Y);
            #endregion

            #region explicit casting ex2
            //long X = 43224565675;   //int Y = (int)X;  //[unsafe explicit casting]
            //Console.WriteLine(Y);//carbage value [overflow]
            #endregion

            //2 ways to get ride of ec 1.checked 2.defensive code 
            #region 1.checked and unchecked to through exception  
            //long X = 43224568885675;
            //checked
            //{   //    int Y = (int)X;
            //    unchecked   //    {

            //        Console.WriteLine(Y);   //    }

            //}
            #endregion
            #region 2.defensive code
            //long X = 767788678;
            //int Y = X.GetType() == typeof(int) ? (int)X : 0;   //Console.WriteLine(Y);

            #endregion
            #region inttodouble implicit casting
            //int X = 5;   //double Y = X; /*(double)*///implicit casting
            //Console.WriteLine(Y);
            #endregion
            #region doubletoint explicit casting
            //double X = 5.5;   //int Y = (int)X; //explicit casting [unsafe]
            //Console.WriteLine(Y); //5 bs
            #endregion

            #endregion

            #region try ,parse video 
            #region Convert and its clases
            ///*convert is a class containing set of methods used             // * for casting from datatype to another */
            //Console.WriteLine("enter your name");
            //string Name = Console.ReadLine() ?? "NA";            //Console.WriteLine(Name);
            //Console.WriteLine("enter your age");
            //int Age = Convert.ToInt32(Console.ReadLine() ?? "NA");            //Console.WriteLine(Age);

            //Console.WriteLine("enter your salary");            //decimal Salary = Convert.ToDecimal(Console.ReadLine() ?? "NA");
            //Console.WriteLine(Salary);
            #endregion

            #region parse (converting to the caller datatype)
            //Console.WriteLine("enter your name");            //string Name = Console.ReadLine() ?? "NA";
            //Console.WriteLine(Name);
            //Console.WriteLine("enter your age");            //int Age = int.Parse(Console.ReadLine() ?? "NA");
            //Console.WriteLine(Age);
            //Console.WriteLine("enter your salary");            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "NA");
            //Console.WriteLine(Salary);
            #endregion
            #region 3yoop explicit casting using(parse,convert)
            //string X = "5";
            //int Y=int.Parse(X);            //Console.WriteLine(Y);
            //  string X = "true";
            // bool Y = Convert.ToBoolean(X);            // Console.WriteLine(Y);
            /* lw value tmam --casting tmam */
            //   string Z = "maya";
            // int T=int.Parse(Z); //error            // Console.WriteLine(T);
            //string X = "maya";
            //bool Y = Convert.ToBoolean(X);//error            //Console.WriteLine(Y);
            /*lw value m4 tmam b2a --casting m4 tmam*/
            #endregion

            #endregion

            #region TryParse video //try parse dont through exceptions//
            //if casting okay it returns true and result of casting in output parameter //if casting fails it returns false and 0(default) in the output parameter
            //output parameter mbyrg34 b 2edo fadya// //bardo b cast ll caller fr tryparse
            //string X = "maya";
            //int Y; //bool flag= int.TryParse(X,  out Y);
            //Console.WriteLine(Y);//zero //Console.WriteLine(flag);//false

            #endregion

        }




    } 

}




