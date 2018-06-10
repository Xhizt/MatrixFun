using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheMatricesTest
{
    class Program
    {
        /* Author: Christian Tavares | Date June 9, 2018 | Project: TheMatricesTest | 
        * 
        * This project is designed to draw out 2 x 2 matrices with user input. The program can then multiply these 2 Matrices.
        * The program concept will get more and more advanced as more ideas come to me, this is just a start
        * 
        * This class is only used to call up the class that handles any console menus and DOS splash screens                   */

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            MenuPainterClass.Initialization(); //Initialize the program's first screen
        }
    }
}
