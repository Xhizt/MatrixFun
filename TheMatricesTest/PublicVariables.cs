using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheMatricesTest
{
    class PublicVariables
    {
        /* Author: Christian Tavares | Date June 9, 2018 | Project: TheMatricesTest | 
        * 
        * This project is designed to draw out 2 x 2 matrices with user input. The program can then multiply these 2 Matrices.
        * The program concept will get more and more advanced as more ideas come to me, this is just a start                    
        *
        * This class is used only to store public variables. I decided to store the values of the mtrices in multiple integer arrays equal to the # of rows in it.
        * The same process will be used later on for when the columns and rows of the matrices are indicated by user input.*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int inputInt;//User input after converted for properly loading it into the arrays

        //Matrix 1
        public static int[] Matrix1Row1 = new int[3];//Row 1 
        public static int[] Matrix1Row2 = new int[3];//Row 2
        public static int[] Matrix1Row3 = new int[3];//Row 3

        //Matrix 2
        public static int[] Matrix2Row1 = new int[3];//Row 1
        public static int[] Matrix2Row2 = new int[3];//Row 2
        public static int[] Matrix2Row3 = new int[3];//Row 3

        //Math Results
        public static int result1;//Top left
        public static int result2;//Top-mid
        public static int result3;//Top-right
        public static int result4;//Mid-left
        public static int result5;//Middle
        public static int result6;//Mid-right
        public static int result7;//Bottom-left
        public static int result8;//Bottom-mid
        public static int result9;//Bottom-right
    }
}
