using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class valid_sudoku
    {
        public static bool IsValidSudokuA(char[][] board)
        {

            Dictionary<int, HashSet<char>> col = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> row = new Dictionary<int, HashSet<char>>();
            Dictionary<(int, int), HashSet<char>> suq = new Dictionary<(int, int), HashSet<char>>();


            for (int i = 0; i < 9; i++)
            {
                row[i] = new HashSet<char>();
                Console.WriteLine(" ");
                for (int k = 0; k < 9; k++)
                {

                    if (!col.ContainsKey(k)) col[k] = new HashSet<char>();
                    if (!suq.ContainsKey((i / 3, k / 3))) suq[(i / 3, k / 3)] = new HashSet<char>();

                    if (board[i][k] == '.') continue;

                    if (row[i].Contains(board[i][k]) || col[k].Contains(board[i][k]) || suq[(i / 3, k / 3)].Contains(board[i][k]))
                        return false;

                    row[i].Add(board[i][k]);
                    col[k].Add(board[i][k]);
                    suq[(i / 3, k / 3)].Add(board[i][k]);

                    Console.Write(board[i][k]);


                }

            }
         
            return true;
        }

        public static bool IsValidSudokuB(char[][] board)
        {
            //check rows
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                        if (Array.FindAll(board[i], el => el == board[i][j]).Length > 1) return false;
                }
            }

            //check columns
            for (int column = 0; column < board[0].Length; column++)
            {
                char[] arr = new char[board[0].Length];
                for (int row = 0; row < board.Length; row++) arr[row] = board[row][column];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != '.')
                        if (Array.FindAll(arr, el => el == arr[i]).Length > 1) return false;
                }

            }

            int boxRowStart = 0;
            int boxRowEnd = 3;
            int boxColumnStart = 0;
            int boxColumnEnd = 3;
            //check sub-boxes
            while (boxRowStart < 9 && boxColumnStart < 9)
            {
                int count = 0;
                char[] arr = new char[9];
                for (int row = boxRowStart; row < boxRowEnd; row++)
                {
                    for (int column = boxColumnStart; column < boxColumnEnd; column++)
                    {
                        arr[count] = board[row][column];
                        count++;
                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != '.')
                        if (Array.FindAll(arr, el => el == arr[i]).Length > 1) return false;
                }
                if (boxRowEnd == 9)
                {
                    boxColumnStart += 3;
                    boxColumnEnd += 3;
                    boxRowStart = 0;
                    boxRowEnd = 3;
                }
                else if (boxColumnEnd > 9) break;
                else
                {
                    boxRowStart += 3;
                    boxRowEnd += 3;
                }
            }

            return true;
        }



        public static void Run()
        {

            char[][] board = new char[][]
            {
                new char[] {'5', '3', '.', 'e', '7', 'z', '.', '.', 'Q'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', 'b', 'a', 'n', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            Console.WriteLine(IsValidSudokuB(board));



        }
    }
}
