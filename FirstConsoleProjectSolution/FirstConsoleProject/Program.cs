using System;
using System.Collections.Generic;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main (string[] args)	//This is a method called "Main". It is called when the program starts.
		{
            CreateGrid();

            Console.ReadKey ();

        }
        public static void CreateGrid ()
        {
            int width = 20;
            int height = 20;

            int[][] grid = new int[width][height];

            }
        }

	}
}