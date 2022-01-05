using System;

namespace Puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawShape();
        }

        static public void DrawShape()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < i; j++){
                    Console.Write(" ");
                }
                var count = 8 - 2 * i;
                HashTag(count); // count = 8 - 2 * i <--- 8 - 2 * 0 <---- OSV.
                Console.WriteLine();
            }
        }

        private static void HashTag(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("#");
            }
        }
    }
}


//Skumles kapittel 2 "Pure puzzles". Noe av dette kan være tungt, men tenke heller "hva kan jeg hente ut av dette" enn at dere må gå gjennom og forstå alt i detalj. 

//Gjør oppgavene 2-1, 2-2, 2-3 og 2-9 (side 53 og 54) i C#.

//Merk at de eneste kallene på Console.Write og Console.WriteLine du har lov til å gjøre er Console.Write("#"), Console.Write(" ") og Console.WriteLine.Uten denne litt kunstige regelen, gir ikke disse oppgavene noen mening. 

//2-1 Write a program that produces the following shape:
//########
// ######
//  ####
//   ##
