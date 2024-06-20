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


        }




    } 

}




