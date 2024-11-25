using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{

    class NewClass
    {
        static void Main(string[] args)
        {

            int userX = 5; int userY = 7;
            char[,] map =
                   {
               {'#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ','#' },
               {'#',' ','X',' ',' ',' ',' ',' ',' ',' ','X',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ','#','#','#','#','#',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#' },
               {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#' },
               {'#','#','#','#','#','#','#','#','#','#','#','#','#','#' }

            };
            while (true)
            {
                
                Console.Clear();


                {
                    Console.CursorVisible = false;
                    
                    for (int i = 0; i < map.GetLength(0); i++)
                    {

                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            Console.Write(map[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.SetCursorPosition(userY, userX);
                    Console.Write('%');
                    ConsoleKeyInfo readKey = Console.ReadKey();
                    switch (readKey.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (map[userX - 1, userY] != '#') userX--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (map[userX + 1, userY] != '#') userX++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (map[userX, userY - 1] != '#') userY--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (map[userX, userY + 1] != '#') userY++;
                            break;
                    }
                    if (map[userX, userY] == 'X')
                    {
                        Console.SetCursorPosition(0,10);
                        Console.WriteLine("You found the treasure!");
                        map[userX, userY] = ' '; 
                    }

                }
            }
        }


    }



}

