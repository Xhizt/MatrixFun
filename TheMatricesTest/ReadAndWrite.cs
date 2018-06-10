using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheMatricesTest
{
    class ReadAndWrite
    {
        /* Author: Christian Tavares | Date June 9, 2018 | Project: TheMatricesTest | 
        * 
        * This project is designed to draw out 2 x 2 matrices with user input. The program can then multiply these 2 Matrices.
        * The program concept will get more and more advanced as more ideas come to me, this is just a start                    
        *
        * This class handles reading and writing of any data in the program. This includes both data conversion from user input
        * and writing user input to your matrices.*/
        
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //This method is used to convert user input into an integer.
        //Once converted, the input can properly be loaded into arrays for your matrices.
        
        public static void TryIntegerConversion()
        {
            try
            {
                string input = Console.ReadLine();//input

                if (input.Length == 1)
                {
                    int convertedValue = Convert.ToInt32(input);
                    PublicVariables.inputInt = convertedValue;//load public input string
                }
                else
                {
                    MenuPainterClass.ErrorScreen(1);//Error: Invalid # of characters
                    Console.Write("Try again:");
                    TryIntegerConversion();
                }
            }
            catch
            {
                MenuPainterClass.ErrorScreen(2);//Error: Invalid character type
                Console.Write("Try again:");
                TryIntegerConversion();
            }
        }

        //This method is a universal way to write a value into any array index for any matrix.
        //It uses many variables to indicate which index it is loading the input into.

        public static void MatrixValueWriter(int matrix, int row, int index, int value)
        {
            if (matrix == 1)//Matrix 1
            {
                if (row == 1) //Row check if-tree
                {
                    PublicVariables.Matrix1Row1[index] = value; //Index
                }
                if (row == 2)
                {
                    PublicVariables.Matrix1Row2[index] = value;
                }
                if (row == 3)
                {
                    PublicVariables.Matrix1Row3[index] = value;
                }
            }
            else //Matrix 2
            {
                if (row == 1)
                {
                    PublicVariables.Matrix2Row1[index] = value;
                }
                if (row == 2)
                {
                    PublicVariables.Matrix2Row2[index] = value;
                }
                if (row == 3)
                {
                    PublicVariables.Matrix2Row3[index] = value;
                }
            }
        }

        //This method is designed strictly for multiplying your matrices.
        //It contains a catch just in case for some reason it cannot multiply the values loaded into your matrices.

        public static void MultiplyMatrices()
        {
            try
            {
                //Top row

                PublicVariables.result1 =  PublicVariables.Matrix1Row1[0] * PublicVariables.Matrix2Row1[2];//Top-left    * Top-right
                PublicVariables.result1 += PublicVariables.Matrix1Row1[1] * PublicVariables.Matrix2Row2[2];//Top-mid     * Mid-right
                PublicVariables.result1 += PublicVariables.Matrix1Row1[2] * PublicVariables.Matrix2Row3[2];//Top-right   * Bottom-right

                PublicVariables.result2 =  PublicVariables.Matrix1Row1[0] * PublicVariables.Matrix2Row1[1];//Top-left    * Top-mid
                PublicVariables.result2 += PublicVariables.Matrix1Row1[1] * PublicVariables.Matrix2Row2[1];//Top-mid     * Middle
                PublicVariables.result2 += PublicVariables.Matrix1Row1[2] * PublicVariables.Matrix2Row3[1];//Top-right   * Bottom-mid

                PublicVariables.result3 =  PublicVariables.Matrix1Row1[0] * PublicVariables.Matrix2Row1[0];//Top-left    * Top-left
                PublicVariables.result3 += PublicVariables.Matrix1Row1[1] * PublicVariables.Matrix2Row2[0];//Top-mid     * Mid-left
                PublicVariables.result3 += PublicVariables.Matrix1Row1[2] * PublicVariables.Matrix2Row3[0];//Top-right   * Bottom-left

                //Middle row

                PublicVariables.result4 =  PublicVariables.Matrix1Row2[0] * PublicVariables.Matrix2Row1[2];//Mid-left    * Top-right
                PublicVariables.result4 += PublicVariables.Matrix1Row2[1] * PublicVariables.Matrix2Row2[2];//Middle      * Mid-right
                PublicVariables.result4 += PublicVariables.Matrix1Row2[2] * PublicVariables.Matrix2Row3[2];//Mid-right   * Bottom-right

                PublicVariables.result5 =  PublicVariables.Matrix1Row2[0] * PublicVariables.Matrix2Row1[1];//Mid-left    * Top-mid
                PublicVariables.result5 += PublicVariables.Matrix1Row2[1] * PublicVariables.Matrix2Row2[1];//Middle      * Middle
                PublicVariables.result5 += PublicVariables.Matrix1Row2[2] * PublicVariables.Matrix2Row3[1];//Mid-right   * Bottom-mid

                PublicVariables.result6 =  PublicVariables.Matrix1Row2[0] * PublicVariables.Matrix2Row1[0];//Mid-left    * Top-left
                PublicVariables.result6 += PublicVariables.Matrix1Row2[1] * PublicVariables.Matrix2Row2[0];//Middle      * Mid-left
                PublicVariables.result6 += PublicVariables.Matrix1Row2[2] * PublicVariables.Matrix2Row3[0];//Mid-right   * Bottom-left

                //Bottom row

                PublicVariables.result7 =  PublicVariables.Matrix1Row3[0] * PublicVariables.Matrix2Row1[2];//Bottom-left * Top-right
                PublicVariables.result7 += PublicVariables.Matrix1Row3[1] * PublicVariables.Matrix2Row2[2];//Bottom-mid  * Mid-right
                PublicVariables.result7 += PublicVariables.Matrix1Row3[2] * PublicVariables.Matrix2Row3[2];//Bottom-right* Bottom-right

                PublicVariables.result8 =  PublicVariables.Matrix1Row3[0] * PublicVariables.Matrix2Row1[1];//Bottom-left * Top-mid
                PublicVariables.result8 += PublicVariables.Matrix1Row3[1] * PublicVariables.Matrix2Row2[1];//Bottom-mid  * Middle
                PublicVariables.result8 += PublicVariables.Matrix1Row3[2] * PublicVariables.Matrix2Row3[1];//Bottom-right* Bottom-mid

                PublicVariables.result9 =  PublicVariables.Matrix1Row3[0] * PublicVariables.Matrix2Row1[0];//Bottom-left * Top-left
                PublicVariables.result9 += PublicVariables.Matrix1Row3[1] * PublicVariables.Matrix2Row2[0];//Bottom-mid  * Mid-left
                PublicVariables.result9 += PublicVariables.Matrix1Row3[2] * PublicVariables.Matrix2Row3[0];//Bottom-right* Bottom-left
            }
            catch
            {
                MenuPainterClass.ErrorScreen(3);
            }
        }
    }
}
