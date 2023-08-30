using System;
using System.Collections.Generic;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
       
        static char[] spaces = new char[] {'1','2','3','4','5','6','7','8','9'};
        static int player = 1;
        static int choice;
        static int flag;
        /// <summary>
        /// Draw the game board
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void DrawBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  | {1}   |  {2}   ", spaces[0], spaces[1],spaces[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  | {1}   | {2}   ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0}   | {1}   |  {2}   ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("     |     |     ");
        }
        /// <summary>
        /// checks if the game is won tied or should continue
        /// </summary>
        /// <param name="args"></param>
        static int  CheckWin()
        {
            if(spaces[0]==spaces[1] &&
               spaces[1]==spaces[2] ||
               spaces[3]==spaces[4] &&
               spaces[4] == spaces[5] ||
               spaces[6]==spaces[7]&&
               spaces[7]==spaces[8] ||
               spaces[0]==spaces[3]&&
               spaces[3]==spaces[6]||
               spaces[1] == spaces[4]&&
               spaces[4] == spaces[7]||
               spaces[2]==spaces[5]&&
               spaces[5] == spaces[8]||
               spaces[0]==spaces[4]&&
               spaces[4]==spaces[8]||
               spaces[2]==spaces[4]&&
               spaces[4]==spaces[6])
            {
                return 1;
            }
            else if(spaces[0]!='1'&&
                    spaces[1] != '2' &&
                    spaces[2] != '3' &&
                    spaces[3]!='4'&&
                    spaces[4]!='5'&&
                    spaces[5] != '6' &&
                    spaces[6] != '7' &&
                    spaces[7] != '8' &&
                    spaces[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        /// <summary>
        /// draw an x on the game board 
        /// </summary>
        /// <param name="pos"></param>
        static void DrawX(int pos)
        {
            spaces[pos] = 'X';

        }
        /// <summary>
        /// Draw O on the game board 
        /// </summary>
        /// <param name="pos"></param>
        static void DrawO(int pos)
        {
            spaces[pos] = 'O';
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("Playes 1:X and Player 2:O" + "\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("playes 2's turn");
                }
                else
                {
                    Console.WriteLine("player 1's turn ");
                }
                Console.WriteLine("\n");
                DrawBoard();
                choice = int.Parse(Console.ReadLine()) - 1;
                if (spaces[choice] != 'X' && spaces[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        DrawO(choice);
                    }
                    else
                    {
                        DrawX(choice);
                    }
                    player++;
                }
                else
                {
                    Console.WriteLine("Sorry the row{0} is alredy marked with{1} \n", choice, spaces[choice]);
                    Console.WriteLine("please wait 2 seconds the board is loading agian...");
                    Thread.Sleep(2000);


                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            DrawBoard();
            if (flag==1)
            {
                Console.WriteLine("Player {0} has won ",(player%2+1));
            }
            else
            {
                Console.WriteLine("Tie Game");
            }
            Console.ReadLine();



        }
    }
}
public class A
{
    private int x = 20;
    private int y = 30;
    public int X { get; set; }
    public int Y { get; set; }
    public void M1()
    {
        Console.WriteLine(x); 
        Console.WriteLine(y); 
    }
}
public class SampleCode
{
    public void getNames(int[] marks,string[] names  )
    {
        int first=0, second=0, third = 0, firsti = 0, secondi = 0, thirdi = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            if(marks[i]>first)
            {
                third = second;
                second = first;
                first = marks[i];
                thirdi = secondi;
                secondi = firsti;
                firsti = i;
            }
            else if(marks[i]>second )
            {
                third = second;
                second = marks[i];
                thirdi = secondi;
                secondi = i;
            }
            else if (marks[i]>third)
            {
                third = marks[i];
                thirdi = i;
            }
        }
        Console.WriteLine(names[firsti]+" "+first);
        Console.WriteLine(names[secondi] + " " + second);
        Console.WriteLine(names[thirdi] + " "+third);


    }
    public void change(int x)
    {
        x = 500;
    }
}