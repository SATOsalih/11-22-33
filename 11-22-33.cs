using System;
using System.Threading;

namespace project_112233
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game_finish = false;

            while (game_finish == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(34, 1);

                Console.WriteLine("╔═════════════  + 11-22-33 Game + ═════════════╗");                   //Creating game menu.
                for (int i = 0; i <= 6; i++)
                {
                    Console.SetCursorPosition(34, i + 2);
                    Console.WriteLine("║                                              ║");
                }
                Console.SetCursorPosition(34, 9);
                Console.WriteLine("╚══════════════════════════════════════════════╝");

                Console.SetCursorPosition(39, 3);
                Console.WriteLine("1 - Gameplay Guide (for new players)");
                Console.SetCursorPosition(39, 5);
                Console.WriteLine("2 - Start game ");
                Console.SetCursorPosition(39, 7);
                Console.Write("Please select the number [ ]");
                Console.SetCursorPosition(65, 7);

                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);


                if (cki.KeyChar == 49)
                {
                    Console.Clear();
                    Console.SetCursorPosition(40, 1);                                                   //Printing how to play section.
                    Console.WriteLine("----| How To Play 11 22 33 Game |----");
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n");
                    Console.WriteLine("1) The game is played on a 3x30 board.");
                    Console.WriteLine();
                    Console.WriteLine("2) In the beginning, the board is randomly filled with 30 random numbers which are 1, 2 and 3.");
                    Console.WriteLine();
                    Console.WriteLine("3) The arrow keys on the keyboard are used to move the cursor.");
                    Console.WriteLine();
                    Console.WriteLine("4) W-A-S-D keys are used to move the number under the cursor.");
                    Console.WriteLine();
                    Console.WriteLine("5) W-A-S-D keys can move only the single numbers.");
                    Console.WriteLine();
                    Console.WriteLine("6) W and S : Moves the number one square up-down.");
                    Console.WriteLine();
                    Console.WriteLine("7) A and D : Moves the number to the left-right as much as it can go.");
                    Console.WriteLine();
                    Console.WriteLine("8) If two identical numbers come together on the same line :");
                    Console.WriteLine();
                    Console.WriteLine("-Matching numbers are deleted from the board.");
                    Console.WriteLine("-The player's score increases by 10 points.");
                    Console.WriteLine("-Matching numbers are deleted from the board.");
                    Console.WriteLine("-New two random numbers are generated and randomly placed on the board.");
                    Console.WriteLine();
                    Console.WriteLine("9) The aim of the game is to earn the highest score.");
                    Console.WriteLine("\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-> Please press ENTER to show menu section");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (cki.KeyChar == 50)
                {
                    int x_cordinate;                                    //printing the 2nd option of the menu.
                    int y_cordinate;
                    Console.Clear();
                    Console.SetCursorPosition(1, 8);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-> Please press ESC to show menu section");
                    Console.SetCursorPosition(1, 9);
                    Console.WriteLine("-> Please press Q to exit the game");


                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(3, 1);
                    Console.WriteLine("+------------------------------+");
                    for (int a = 0; a < 3; a++)
                    {
                        Console.SetCursorPosition(3, 3 + a - 1);                                    //Creating game screen.
                        Console.WriteLine("|                              |");
                    }
                    Console.SetCursorPosition(3, 5);
                    Console.WriteLine("+------------------------------+");
                    Console.ResetColor();



                    Random xy = new Random();
                    x_cordinate = xy.Next(4, 34);                 //generating random x-y coordinate
                    y_cordinate = xy.Next(2, 5);

                    int[] row_1 = new int[32];
                    int[] row_2 = new int[32];                    //creating arrays.
                    int[] row_3 = new int[32];


                    int score = 0;                               //creating score variables.   

                    Random rnd = new Random();


                    for (int i = 1; i <= 30; i++)                                       //placing random numbers.
                    {
                        int row_number = rnd.Next(1, 4);

                        int one_from_three = rnd.Next(1, 4);

                        int one_from_thirty = rnd.Next(1, 31);

                        if (row_number == 1)
                        {
                            if (row_1[one_from_thirty] == 0)
                            {
                                row_1[one_from_thirty] = one_from_three;
                            }
                            else
                            {
                                i--;
                            }
                        }

                        if (row_number == 2)
                        {
                            if (row_2[one_from_thirty] == 0)
                            {
                                row_2[one_from_thirty] = one_from_three;
                            }
                            else
                            {
                                i--;
                            }

                        }

                        if (row_number == 3)
                        {
                            if (row_3[one_from_thirty] == 0)
                            {
                                row_3[one_from_thirty] = one_from_three;

                            }
                            else
                            {
                                i--;
                            }
                        }

                        for (int j = 1; j < 30; j++)
                        {
                            if (row_1[j] == row_1[j + 1] && row_1[j] != 0 && row_1[j + 1] != 0)                     //Checking that the random numbers match
                            {
                                row_1[j] = 0;
                                row_1[j + 1] = 0;
                                score += 10;
                                i = i - 2;
                            }

                            if (row_2[j] == row_2[j + 1] && row_2[j] != 0 && row_2[j + 1] != 0)
                            {
                                row_2[j] = 0;
                                row_2[j + 1] = 0;
                                score += 10;
                                i = i - 2;
                            }

                            if (row_3[j] == row_3[j + 1] && row_3[j] != 0 && row_3[j + 1] != 0)
                            {
                                row_3[j] = 0;
                                row_3[j + 1] = 0;
                                score += 10;
                                i = i - 2;
                            }
                        }
                    }

                    for (int t = 1; t < 31; t++)                                        //printing random numbers and coloring them.
                    {
                        Console.SetCursorPosition(3 + t, 2);
                        if (row_1[t] != 0)
                        {
                            if (row_1[t] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(row_1[t]);
                                Console.ResetColor();
                            }
                            else if (row_1[t] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row_1[t]);
                                Console.ResetColor();
                            }
                            else if (row_1[t] == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row_1[t]);
                                Console.ResetColor();
                            }
                        }
                        Console.SetCursorPosition(3 + t, 3);
                        if (row_2[t] != 0)
                        {
                            if (row_2[t] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(row_2[t]);
                                Console.ResetColor();
                            }
                            else if (row_2[t] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row_2[t]);
                                Console.ResetColor();
                            }
                            else if (row_2[t] == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row_2[t]);
                                Console.ResetColor();
                            }
                        }
                        Console.SetCursorPosition(3 + t, 4);
                        if (row_3[t] != 0)
                        {
                            if (row_3[t] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(row_3[t]);
                                Console.ResetColor();
                            }
                            else if (row_3[t] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(row_3[t]);
                                Console.ResetColor();
                            }
                            else if (row_3[t] == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(row_3[t]);
                                Console.ResetColor();
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(45, 2);
                    Console.Write("Score = " + score);                                                      //printing the score to the screen
                    Console.ResetColor();

                    int u = 2;


                    bool game()
                    {
                        bool flag = true;
                        for (int h = 1; h <= 30; h++)
                        {
                            if (row_1[h] != 0 && row_1[h + 1] == 0 && row_1[h - 1] == 0)
                            {
                                flag = false;
                            }
                            else if (row_2[h] != 0 && row_2[h + 1] == 0 && row_2[h - 1] == 0)                   //Checking all numbers. if ,cannot be moved, the game ends             
                            {
                                flag = false;
                            }
                            else if (row_3[h] != 0 && row_3[h + 1] == 0 && row_3[h - 1] == 0)
                            {
                                flag = false;
                            }
                        }
                        return flag;

                    }


                    while (true)
                    {

                        if (Console.KeyAvailable)
                        {
                            // true: there is a key in keyboard buffer
                            cki = Console.ReadKey(true);       // true: do not write character 




                            if (cki.Key == ConsoleKey.RightArrow && x_cordinate < 33)
                            {   // key and boundary control 
                                x_cordinate++;
                            }

                            if (cki.Key == ConsoleKey.LeftArrow && x_cordinate > 4)
                            {
                                x_cordinate--;                                                       //Cursor movement
                            }

                            if (cki.Key == ConsoleKey.UpArrow && y_cordinate > 2)
                            {
                                y_cordinate--;
                            }

                            if (cki.Key == ConsoleKey.DownArrow && y_cordinate < 4)
                            {
                                y_cordinate++;
                            }


                            if (cki.KeyChar == 115 && y_cordinate == 2 && row_1[x_cordinate - 4] == 0 && row_1[x_cordinate - 2] == 0 &&
                                row_2[x_cordinate - 3] == 0 && row_1[x_cordinate - 3] != 0)
                            {


                                Console.Write(" ");                                                 //Moving single numbers down on row1 with using S key and coloring.
                                Console.SetCursorPosition(x_cordinate, 3);
                                if (row_1[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_1[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_1[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }

                                row_2[x_cordinate - 3] = row_1[x_cordinate - 3];
                                row_1[x_cordinate - 3] = 0;

                                y_cordinate++;

                            }


                            else if (cki.KeyChar == 115 && y_cordinate == 3 && row_2[x_cordinate - 4] == 0 && row_2[x_cordinate - 2] == 0 &&
                                     row_3[x_cordinate - 3] == 0 && row_2[x_cordinate - 3] != 0)
                            {


                                Console.Write(" ");
                                Console.SetCursorPosition(x_cordinate, 4);                         //Moving single numbers down on row2 with using S key and coloring.
                                if (row_2[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }

                                row_3[x_cordinate - 3] = row_2[x_cordinate - 3];
                                row_2[x_cordinate - 3] = 0;

                                y_cordinate++;

                            }


                            else if (cki.KeyChar == 119 && y_cordinate == 3 && row_2[x_cordinate - 4] == 0 && row_2[x_cordinate - 2] == 0 &&
                                     row_1[x_cordinate - 3] == 0 && row_2[x_cordinate - 3] != 0)
                            {


                                Console.Write(" ");
                                Console.SetCursorPosition(x_cordinate, 2);                          //Moving single numbers up on row2 with using W key and coloring
                                if (row_2[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }

                                row_1[x_cordinate - 3] = row_2[x_cordinate - 3];
                                row_2[x_cordinate - 3] = 0;

                                y_cordinate--;

                            }

                            else if (cki.KeyChar == 119 && y_cordinate == 4 && row_3[x_cordinate - 4] == 0 && row_3[x_cordinate - 2] == 0 &&
                                     row_2[x_cordinate - 3] == 0 && row_3[x_cordinate - 3] != 0)
                            {


                                Console.Write(" ");
                                Console.SetCursorPosition(x_cordinate, 3);                            //Moving single numbers up on row3 with using W key and coloring
                                if (row_3[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_3[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_3[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }

                                row_2[x_cordinate - 3] = row_3[x_cordinate - 3];
                                row_3[x_cordinate - 3] = 0;

                                y_cordinate--;

                            }
                            else if (cki.KeyChar == 97 && y_cordinate == 2 && row_1[x_cordinate - 4] == 0 && row_1[x_cordinate - 2] == 0 && row_1[x_cordinate - 3] != 0)
                            {

                                while (row_1[x_cordinate - 4] == 0)
                                {
                                    if (x_cordinate == 4)                                           //Moving single numbers to the left as much as it can go on row1 with using A key and coloring.
                                    {
                                        break;
                                    }
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x_cordinate - 1, 2);


                                    row_1[x_cordinate - 4] = row_1[x_cordinate - 3];
                                    row_1[x_cordinate - 3] = 0;

                                    x_cordinate--;
                                }
                                if (row_1[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_1[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_1[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                            }
                            else if (cki.KeyChar == 97 && y_cordinate == 3 && row_2[x_cordinate - 4] == 0 && row_2[x_cordinate - 2] == 0 && row_2[x_cordinate - 3] != 0)
                            {

                                while (row_2[x_cordinate - 4] == 0)
                                {
                                    if (x_cordinate == 4)
                                    {
                                        break;                                              //Moving single numbers to the left as much as it can go on row2 with using A key and coloring.
                                    }
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x_cordinate - 1, 3);


                                    row_2[x_cordinate - 4] = row_2[x_cordinate - 3];
                                    row_2[x_cordinate - 3] = 0;

                                    x_cordinate--;
                                }
                                if (row_2[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                            }
                            else if (cki.KeyChar == 97 && y_cordinate == 4 && row_3[x_cordinate - 4] == 0 && row_3[x_cordinate - 2] == 0 && row_3[x_cordinate - 3] != 0)
                            {

                                while (row_3[x_cordinate - 4] == 0)
                                {
                                    if (x_cordinate == 4)                                            //Moving single numbers to the left as much as it can go on row3 with using A key and coloring.
                                    {
                                        break;
                                    }
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x_cordinate - 1, 4);


                                    row_3[x_cordinate - 4] = row_3[x_cordinate - 3];
                                    row_3[x_cordinate - 3] = 0;

                                    x_cordinate--;
                                }
                                if (row_3[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_3[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_3[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                            }
                            else if (cki.KeyChar == 100 && y_cordinate == 2 && row_1[x_cordinate - 4] == 0 && row_1[x_cordinate - 2] == 0 && row_1[x_cordinate - 3] != 0)
                            {

                                while (row_1[x_cordinate - 2] == 0)
                                {
                                    if (x_cordinate == 33)
                                    {                                                           //Moving single numbers to the right as much as it can go on row1 with using D key and coloring.
                                        break;
                                    }
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x_cordinate + 1, 2);


                                    row_1[x_cordinate - 2] = row_1[x_cordinate - 3];
                                    row_1[x_cordinate - 3] = 0;

                                    x_cordinate++;
                                }
                                if (row_1[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_1[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_1[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_1[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                            }
                            else if (cki.KeyChar == 100 && y_cordinate == 3 && row_2[x_cordinate - 4] == 0 && row_2[x_cordinate - 2] == 0 && row_2[x_cordinate - 3] != 0)
                            {

                                while (row_2[x_cordinate - 2] == 0)
                                {
                                    if (x_cordinate == 33)
                                    {                                                               //Moving single numbers to the right as much as it can go on row2 with using D key and coloring.
                                        break;
                                    }
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x_cordinate + 1, 3);


                                    row_2[x_cordinate - 2] = row_2[x_cordinate - 3];
                                    row_2[x_cordinate - 3] = 0;

                                    x_cordinate++;
                                }
                                if (row_2[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_2[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_2[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                            }
                            else if (cki.KeyChar == 100 && y_cordinate == 4 && row_3[x_cordinate - 4] == 0 && row_3[x_cordinate - 2] == 0 && row_3[x_cordinate - 3] != 0)
                            {

                                while (row_3[x_cordinate - 2] == 0)
                                {
                                    if (x_cordinate == 33)
                                    {                                                           //Moving single numbers to the right as much as it can go on row3 with using D key and coloring.
                                        break;
                                    }
                                    Console.Write(" ");
                                    Console.SetCursorPosition(x_cordinate + 1, 4);


                                    row_3[x_cordinate - 2] = row_3[x_cordinate - 3];
                                    row_3[x_cordinate - 3] = 0;

                                    x_cordinate++;
                                }
                                if (row_3[x_cordinate - 3] == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_3[x_cordinate - 3] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                                else if (row_3[x_cordinate - 3] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(row_3[x_cordinate - 3]);
                                    Console.ResetColor();
                                }
                            }

                            if (cki.KeyChar == 97 && row_1[x_cordinate - 3] == row_1[x_cordinate - 4] && row_1[x_cordinate - 3] != 0 && y_cordinate == 2)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 2);
                                Console.Write("  ");
                                row_1[x_cordinate - 3] = 0;                                                          // matching on row1 when A is pressed ( current cursor and left of cursor)
                                row_1[x_cordinate - 4] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 97 && row_2[x_cordinate - 3] == row_2[x_cordinate - 4] && row_2[x_cordinate - 3] != 0 && y_cordinate == 3)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 3);
                                Console.Write("  ");
                                row_2[x_cordinate - 3] = 0;                                                         // matching on row2 when A is pressed ( current cursor and left of cursor)
                                row_2[x_cordinate - 4] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 97 && row_3[x_cordinate - 3] == row_3[x_cordinate - 4] && row_3[x_cordinate - 3] != 0 && y_cordinate == 4)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 4);
                                Console.Write("  ");
                                row_3[x_cordinate - 3] = 0;
                                row_3[x_cordinate - 4] = 0;                                                         // matching on row3 when A is pressed ( current cursor and left of cursor)
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 100 && row_1[x_cordinate - 3] == row_1[x_cordinate - 2] && row_1[x_cordinate - 3] != 0 && y_cordinate == 2)
                            {
                                Console.SetCursorPosition(x_cordinate, 2);
                                Console.Write("  ");
                                row_1[x_cordinate - 3] = 0;                                                         // matching on row1 when D is pressed ( current cursor and right of cursor)
                                row_1[x_cordinate - 2] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 100 && row_2[x_cordinate - 3] == row_2[x_cordinate - 2] && row_2[x_cordinate - 3] != 0 && y_cordinate == 3)
                            {
                                Console.SetCursorPosition(x_cordinate, 3);
                                Console.Write("  ");
                                row_2[x_cordinate - 3] = 0;
                                row_2[x_cordinate - 2] = 0;                                                         // matching on row2 when D is pressed ( current cursor and right of cursor)
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 100 && row_3[x_cordinate - 3] == row_3[x_cordinate - 2] && row_3[x_cordinate - 3] != 0 && y_cordinate == 4)
                            {
                                Console.SetCursorPosition(x_cordinate, 4);
                                Console.Write("  ");
                                row_3[x_cordinate - 3] = 0;
                                row_3[x_cordinate - 2] = 0;                                                         // matching on row3 when D is pressed ( current cursor and right of cursor)
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 119 && row_1[x_cordinate - 3] == row_1[x_cordinate - 4] && row_1[x_cordinate - 3] != 0 && y_cordinate == 2)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 2);
                                Console.Write("  ");
                                row_1[x_cordinate - 3] = 0;
                                row_1[x_cordinate - 4] = 0;                                                 // matching on row1 when W is pressed ( current cursor and left of cursor)
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 119 && row_1[x_cordinate - 3] == row_1[x_cordinate - 2] && row_1[x_cordinate - 3] != 0 && y_cordinate == 2)
                            {
                                Console.SetCursorPosition(x_cordinate, 2);
                                Console.Write("  ");
                                row_1[x_cordinate - 3] = 0;                                                 // matching on row1 when W is pressed ( current cursor and right of cursor)
                                row_1[x_cordinate - 2] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 119 && row_2[x_cordinate - 3] == row_2[x_cordinate - 4] && row_2[x_cordinate - 3] != 0 && y_cordinate == 3)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 3);
                                Console.Write("  ");
                                row_2[x_cordinate - 3] = 0;                                                  // matching on row2 when W is pressed ( current cursor and left of cursor)
                                row_2[x_cordinate - 4] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 119 && row_2[x_cordinate - 3] == row_2[x_cordinate - 2] && row_2[x_cordinate - 3] != 0 && y_cordinate == 3)
                            {
                                Console.SetCursorPosition(x_cordinate, 3);
                                Console.Write("  ");
                                row_2[x_cordinate - 3] = 0;                                                  // matching on row2 when W is pressed ( current cursor and right of cursor)
                                row_2[x_cordinate - 2] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 115 && row_3[x_cordinate - 3] == row_3[x_cordinate - 4] && row_3[x_cordinate - 3] != 0 && y_cordinate == 4)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 4);
                                Console.Write("  ");
                                row_3[x_cordinate - 3] = 0;
                                row_3[x_cordinate - 4] = 0;                                                // matching on row3 when S is pressed ( current cursor and left of cursor)             
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 115 && row_3[x_cordinate - 3] == row_3[x_cordinate - 2] && row_3[x_cordinate - 3] != 0 && y_cordinate == 4)
                            {
                                Console.SetCursorPosition(x_cordinate, 4);
                                Console.Write("  ");
                                row_3[x_cordinate - 3] = 0;                                                 // matching on row3 when S is pressed ( current cursor and right of cursor)
                                row_3[x_cordinate - 2] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 115 && row_2[x_cordinate - 3] == row_2[x_cordinate - 4] && row_2[x_cordinate - 3] != 0 && y_cordinate == 3)
                            {
                                Console.SetCursorPosition(x_cordinate - 1, 3);
                                Console.Write("  ");
                                row_2[x_cordinate - 3] = 0;                                                 // matching on row2 when S is pressed ( current cursor and left of cursor)
                                row_2[x_cordinate - 4] = 0;
                                u = 0;
                                score += 10;
                            }
                            else if (cki.KeyChar == 115 && row_2[x_cordinate - 3] == row_2[x_cordinate - 2] && row_2[x_cordinate - 3] != 0 && y_cordinate == 3)
                            {
                                Console.SetCursorPosition(x_cordinate, 3);
                                Console.Write("  ");
                                row_2[x_cordinate - 3] = 0;                                                 // matching on row2 when S is pressed ( current cursor and right of cursor)
                                row_2[x_cordinate - 2] = 0;
                                u = 0;
                                score += 10;
                            }




                            while (u < 2)
                            {

                                Random row_rn = new Random();                                   //placing random numbers after matching numbers


                                int row_number = row_rn.Next(1, 4);


                                int one_from_three = row_rn.Next(1, 4);


                                int one_from_thirty = row_rn.Next(1, 31);

                                if (row_number == 1)
                                {
                                    if (row_1[one_from_thirty] == 0)
                                    {
                                        row_1[one_from_thirty] = one_from_three;
                                        Console.SetCursorPosition(3 + one_from_thirty, 2);
                                        if (one_from_three == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        if (one_from_three == 2)                                    //placing random numbers and coloring them
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        if (one_from_three == 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        u++;
                                    }

                                }

                                if (row_number == 2)
                                {
                                    if (row_2[one_from_thirty] == 0)
                                    {
                                        row_2[one_from_thirty] = one_from_three;
                                        Console.SetCursorPosition(3 + one_from_thirty, 3);
                                        if (one_from_three == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        if (one_from_three == 2)                                            //placing random numbers and coloring them
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        if (one_from_three == 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        u++;
                                    }

                                }

                                if (row_number == 3)
                                {
                                    if (row_3[one_from_thirty] == 0)
                                    {
                                        row_3[one_from_thirty] = one_from_three;
                                        Console.SetCursorPosition(3 + one_from_thirty, 4);
                                        if (one_from_three == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        if (one_from_three == 2)                                                 //placing random numbers and coloring them
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        if (one_from_three == 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(one_from_three);
                                            Console.ResetColor();
                                        }
                                        u++;
                                    }

                                }
                                for (int j = 1; j < 30; j++)                                                            //Checking that the random numbers match 
                                {
                                    if (row_1[j] == row_1[j + 1] && row_1[j] != 0 && row_1[j + 1] != 0)
                                    {
                                        row_1[j] = 0;
                                        row_1[j + 1] = 0;
                                        Console.SetCursorPosition(3 + j, 2);
                                        Console.Write("  ");
                                        score += 10;
                                        u = u - 2;

                                    }

                                    if (row_2[j] == row_2[j + 1] && row_2[j] != 0 && row_2[j + 1] != 0)
                                    {
                                        row_2[j] = 0;
                                        row_2[j + 1] = 0;
                                        Console.SetCursorPosition(3 + j, 3);
                                        Console.Write("  ");
                                        score += 10;
                                        u = u - 2;

                                    }

                                    if (row_3[j] == row_3[j + 1] && row_3[j] != 0 && row_3[j + 1] != 0)
                                    {
                                        row_3[j] = 0;
                                        row_3[j + 1] = 0;
                                        Console.SetCursorPosition(3 + j, 4);
                                        Console.Write("  ");
                                        score += 10;
                                        u = u - 2;

                                    }
                                }

                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(45, 2);                                               //printing the score to the screen
                            Console.Write("Score = " + score);
                            Console.ResetColor();

                            if (cki.KeyChar == 113)
                            {
                                game_finish = true;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(0, 8);
                                Console.WriteLine("                                                                         ");
                                Console.SetCursorPosition(45, 2);
                                Console.Write("                             ");
                                Console.SetCursorPosition(0, 9);                                                        //exit the game when pressing Q
                                Console.WriteLine("                                                                   ");
                                Console.WriteLine("-> Your total score = " + score);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(3, 7);
                                Console.WriteLine("Game Over!");
                                Console.ResetColor();
                                break;
                            }




                        }
                        if (cki.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;                                                      //exit the game when pressing ESC
                        }



                        if (cki.KeyChar != 113)
                        {
                            Console.SetCursorPosition(x_cordinate, y_cordinate);
                            Thread.Sleep(50);
                        }


                        if (game())
                        {
                            game_finish = true;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("                                                                         ");
                            Console.SetCursorPosition(45, 2);
                            Console.Write("                             ");
                            Console.SetCursorPosition(3, 7);
                            Console.WriteLine("Game Over!");                                                                    //If all numbers cannot be moved, the game ends
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.SetCursorPosition(0, 9);
                            Console.WriteLine("                                                                   ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("-> Your total score = " + score);
                            Console.ResetColor();
                            break;
                        }

                    }
                    Console.SetCursorPosition(0, 12);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                }
                else
                {
                    Console.SetCursorPosition(44, 12);
                    Console.WriteLine("Please enter a valid value!");
                    Console.SetCursorPosition(65, 7);
                }

            }
        }
    }
}