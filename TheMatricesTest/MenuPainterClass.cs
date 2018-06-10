using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheMatricesTest
{
    class MenuPainterClass
    {
        /* Author: Christian Tavares | Date June 9, 2018 | Project: TheMatricesTest | 
        * 
        * This project is designed to draw out 2 x 2 matrices with user input. The program can then multiply these 2 Matrices.
        * The program concept will get more and more advanced as more ideas come to me, this is just a start                    
        *
        * This class handles splash screens and menu screens                                                                  */
        
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //The first screen you will see at launch.

        public static void Initialization()
        {
            Console.WriteLine("\n\n\n\n\n\n\n     Matrix 1:                             Matrix:2");//Menu Output
            Console.WriteLine("\n     | N/A , N/A , N/A |                   | N/A , N/A , N/A |");
            Console.WriteLine("     | N/A , N/A , N/A |                   | N/A , N/A , N/A |");
            Console.WriteLine("     | N/A , N/A , N/A |                   | N/A , N/A , N/A |");
            Console.WriteLine("");
            Console.WriteLine("     These are your matrices...");
            Console.Write("\n\n\n\n\n\n\n\npress enter to continue...");
            Console.ReadLine();//wait for user input

            Console.Clear();
            MatrixWriterMenu();
        }

        //This method is the one that proceeds initialization. 
        //As you provide input for your matrices, this will provide menu text.

        public static void MatrixWriterMenu()
        {
            Console.WriteLine("\n\n\nWrite your first matrix!");//Menu Output
            Console.WriteLine("\nRow 1");
            Console.Write("\nFirst number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();//Checks user input and converts it to an integer

            int input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 1, 0, input);//Fill matrix slot

            Console.Write("Second number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 1, 1, input);//Fill matrix slot

            Console.Write("Third number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 1, 2, input);//Fill matrix slot

            Console.Write("Row 2\nFirst number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 2, 0, input);//Fill matrix slot

            Console.Write("Second number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 2, 1, input);//Fill matrix slot

            Console.Write("Third number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 2, 2, input);//Fill matrix slot

            Console.Write("Row 3\nFirst number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 3, 0, input);//Fill matrix slot

            Console.Write("Second number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 3, 1, input);//Fill matrix slot

            Console.Write("Third number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(1, 3, 2, input);//Fill matrix slot

            Console.Clear();//Clear screen and display your matrices
            Console.WriteLine("Your arrays are as follows:\n");
            Console.Write("{0}{1}{2}                ", PublicVariables.Matrix1Row1[0], PublicVariables.Matrix1Row1[1], PublicVariables.Matrix1Row1[2]);
            Console.Write("{0}{1}{2}\n"              , PublicVariables.Matrix2Row1[0], PublicVariables.Matrix2Row1[1], PublicVariables.Matrix2Row1[2]);
            Console.Write("{0}{1}{2}                ", PublicVariables.Matrix1Row2[0], PublicVariables.Matrix1Row2[1], PublicVariables.Matrix1Row2[2]);
            Console.Write("{0}{1}{2}\n"              , PublicVariables.Matrix2Row2[0], PublicVariables.Matrix2Row2[1], PublicVariables.Matrix2Row2[2]);
            Console.Write("{0}{1}{2}                ", PublicVariables.Matrix1Row3[0], PublicVariables.Matrix1Row3[1], PublicVariables.Matrix1Row3[2]);
            Console.Write("{0}{1}{2}\n"              , PublicVariables.Matrix2Row3[0], PublicVariables.Matrix2Row3[1], PublicVariables.Matrix2Row3[2]);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\n\nWrite your second matrix!");//Menu Output (Matrix #2)
            Console.WriteLine("\nRow 1");
            Console.Write("\nFirst number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();//Checks user input and converts it to an integer

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 1, 0, input);//Fill matrix slot

            Console.Write("Second number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 1, 1, input);//Fill matrix slot

            Console.Write("Third number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 1, 2, input);//Fill matrix slot

            Console.Write("Row 2\nFirst number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 2, 0, input);//Fill matrix slot

            Console.Write("Second number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 2, 1, input);//Fill matrix slot

            Console.Write("Third number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 2, 2, input);//Fill matrix slot

            Console.Write("Row 3\nFirst number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 3, 0, input);//Fill matrix slot

            Console.Write("Second number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 3, 1, input);//Fill matrix slot

            Console.Write("Third number(1 digit only!):");

            ReadAndWrite.TryIntegerConversion();

            input = PublicVariables.inputInt;
            ReadAndWrite.MatrixValueWriter(2, 3, 2, input);//Fill matrix slot

            Console.Clear();//Clear screen and display your matrices
            Console.WriteLine("Your arrays are as follows:\n");
            Console.Write("{0}{1}{2}                ", PublicVariables.Matrix1Row1[0], PublicVariables.Matrix1Row1[1], PublicVariables.Matrix1Row1[2]);
            Console.Write("{0}{1}{2}\n"              , PublicVariables.Matrix2Row1[0], PublicVariables.Matrix2Row1[1], PublicVariables.Matrix2Row1[2]);
            Console.Write("{0}{1}{2}                ", PublicVariables.Matrix1Row2[0], PublicVariables.Matrix1Row2[1], PublicVariables.Matrix1Row2[2]);
            Console.Write("{0}{1}{2}\n"              , PublicVariables.Matrix2Row2[0], PublicVariables.Matrix2Row2[1], PublicVariables.Matrix2Row2[2]);
            Console.Write("{0}{1}{2}                ", PublicVariables.Matrix1Row3[0], PublicVariables.Matrix1Row3[1], PublicVariables.Matrix1Row3[2]);
            Console.Write("{0}{1}{2}\n"              , PublicVariables.Matrix2Row3[0], PublicVariables.Matrix2Row3[1], PublicVariables.Matrix2Row3[2]);
            Console.ReadLine();

            Console.Write("\n\n\nWe will now multiply these 2 matrices... (Press enter to continue):");
            Console.ReadLine();

            ReadAndWrite.MultiplyMatrices();//Math for matrix multiplication.

            Console.Clear();
            Console.WriteLine("Your arrays are as follows:\n");
            Console.WriteLine("                    |{0},{1},{2}                ", PublicVariables.result1, PublicVariables.result2, PublicVariables.result3);
            Console.WriteLine("                    |{0},{1},{2}                ", PublicVariables.result4, PublicVariables.result5, PublicVariables.result6);
            Console.WriteLine("                    |{0},{1},{2}                ", PublicVariables.result7, PublicVariables.result8, PublicVariables.result9);
            Console.ReadLine();
        }

        //This method is for error splash screens.

        public static void ErrorScreen(int errorCode)//The error code depicts which splash screen is displayed.
        {
            if (errorCode == 1)//Invalid number of characters
            {
                Console.WriteLine("Invalid # of characters");
            }
            if (errorCode == 2)//Invalid character type (Not a number/Integer)
            {
                Console.WriteLine("Invalid character type (Not an integer)");
            }
            if (errorCode == 3)//Cannot Multiply Matrices
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n                    Cannot Multiply Matrices!");
                Console.ReadLine();
                Console.ReadLine();
            }
        }
    }
}
