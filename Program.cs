using System;
using System.Threading;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string ava1 = "1";
            string ava2 = "2";
            string ava3 = "3";
            string ava4 = "4";
            string ava5 = "5";
            string ava6 = "6";
            string ava7 = "7";
            string ava8 = "8";
            string ava9 = "9";
            string a1 = " ";
            string a2 = " ";
            string a3 = " ";
            string a4 = " ";
            string a5 = " ";
            string a6 = " ";
            string a7 = " ";
            string a8 = " ";
            string a9 = " ";

            int player = 1;
            int choice;
            int flag = 0;
            string answer;
            bool result = false;
            do
            {
                player = 1;
                ava1 = "1";
                ava2 = "2";
                ava3 = "3";
                ava4 = "4";
                ava5 = "5";
                ava6 = "6";
                ava7 = "7";
                ava8 = "8";
                ava9 = "9";
                a1 = " ";
                a2 = " ";
                a3 = " ";
                a4 = " ";
                a5 = " ";
                a6 = " ";
                a7 = " ";
                a8 = " ";
                a9 = " ";
                Console.WriteLine("1. New Game");
                Console.WriteLine("2. About the author");
                Console.WriteLine("3. Exit");
                string menuResult=Console.ReadLine();
                if (menuResult == "1")
                {
                    do
                    {
                        Console.WriteLine("  {0}  |  {1}  |  {2}", a1, a2, a3);

                        Console.WriteLine("-----+-----+---- ");

                        Console.WriteLine("  {0}  |  {1}  |  {2}", a4, a5, a6);

                        Console.WriteLine("-----+-----+---- ");

                        Console.WriteLine("  {0}  |  {1}  |  {2}", a7, a8, a9);

                    Again:
                        if (player % 2 == 1)
                        {
                            Console.Write("X's move > ");
                        }
                        else
                        {
                            Console.Write("O's move > ");
                        }
                        try
                        {
                            choice = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Illegal Choise! Try Again");
                            goto Again;
                        }
                        Console.WriteLine();
                        if (choice >= 1 && choice <= 9)
                        {
                            switch (choice.ToString())
                            {
                                case "1":
                                    {
                                        if (player % 2 == 0)  
                                        {
                                            ava1 = "O";
                                            a1 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava1 = "X";
                                            a1 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava2 = "O";
                                            a2 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava2 = "X";
                                            a2 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "3":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava3 = "O";
                                            a3 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava3 = "X";
                                            a3 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "4":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava4 = "O";
                                            a4 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava4 = "X";
                                            a4 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "5":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava5 = "O";
                                            a5 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava5 = "X";
                                            a5 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "6":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava6 = "O";
                                            a6 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava6 = "X";
                                            a6 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "7":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava7 = "O";
                                            a7 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava7 = "X";
                                            a7 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "8":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava8 = "O";
                                            a8 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava8 = "X";
                                            a8 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                case "9":
                                    {
                                        if (player % 2 == 0)
                                        {
                                            ava9 = "O";
                                            a9 = "O";
                                            player++;
                                        }
                                        else
                                        {
                                            ava9 = "X";
                                            a9 = "X";
                                            player++;
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Illegal move! Try Again");
                                        break;
                                    }
                            }
                            
                              
                            if (ava1 == ava2 && ava2 == ava3)
                            {
                                flag= 1;
                            }
                           
                            else if (ava4 == ava5 && ava5 == ava6)
                            {
                                flag = 1;
                            }
                            
                            else if (ava7 == ava8 && ava8 == ava9)
                            {
                                flag = 1;
                            }
                            
                            else if (ava1 == ava4 && ava4 == ava7)
                            {
                                flag = 1;
                            }
                           
                            else if (ava2 == ava5 && ava5 == ava8)
                            {
                                flag = 1;
                            }
                            
                            else if (ava3 == ava6 && ava6 == ava9)
                            {
                                flag = 1;
                            }
                            
                            else if (ava1 == ava5 && ava5 == ava9)
                            {
                                flag = 1;
                            }
                            else if (ava3 == ava5 && ava5 == ava7)
                            {
                                flag = 1;
                            }
                           
                            
                            else if (ava1 != "1" && ava2 != "2" && ava3 != "3" && ava4 != "4" && ava5 != "5" && ava6 != "6" && ava7 != "7" && ava8 != "8" && ava9 != "9")
                            {
                                flag = -1;
                            }
                            
                            else
                            {
                                flag = 0;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Illegal move! Try Again");
                        }
                    } while (flag != 1 && flag != -1);

                    Console.WriteLine("  {0}  |  {1}  |  {2}", a1, a2, a3);

                    Console.WriteLine("-----+-----+---- ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", a4, a5, a6);

                    Console.WriteLine("-----+-----+---- ");

                    Console.WriteLine("  {0}  |  {1}  |  {2}", a7, a8, a9);

                    if (flag == 1)
                    {
                        Console.WriteLine("Player {0} has won", (player % 2) + 1);
                    }
                    else
                    {
                        Console.WriteLine("Game Over!");
                    }
                    Console.WriteLine("[Press Button to Return To Main Menu]");
                    Console.ReadLine();
                    result = false;
                }
                else if (menuResult == "2")
                {
                    Console.WriteLine("Oğuzhan KÖSE");
                }
                else if (menuResult == "3")
                {
                    do
                    {
                        Console.WriteLine("Are you sure you want to quit? [y/n]");
                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y")
                        {
                            result = true;
                        }
                        else if (answer == "n" || answer == "N")
                        {
                            result = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Illegal answer! Try Again");
                            result = false;
                        }
                    } while (result == false);
                }
            } while (result == false) ;
        }
    }
}
