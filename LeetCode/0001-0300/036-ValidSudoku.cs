//-----------------------------------------------------------------------------
// Link: https://leetcode.com/problems/valid-sudoku/
//-----------------------------------------------------------------------------

namespace LeetCode._0001_0300
{
    public class _036_ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            // Step 1: Check all rows
            // Each row must contain the digits 1-9 without repetition.
            for (int row = 0; row < 9; row++) {
                HashSet<char> seen = new HashSet<char>();

                for(int col=0; col < 9; col++)
                {
                    char current = board[row][col];

                    if (current == '.') 
                        continue;
                    if (!seen.Add(current))
                        return false;
                }  
            }

            // Step 2: Check all columns
            // Each column must contain the digits 1-9 without repetition

            for (int col = 0; col < 9; col++) {
                HashSet<char> seen = new HashSet<char>();

                for (int row = 0; row < 9; row++) {
                    char current = board[row][col];

                    if (current == '.')
                        continue;

                    if (!seen.Add(current))
                        return false;
                }
            }

            // Step 3: Check all 3x3 boxes
            // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition

            for(int rowBox = 0; rowBox < 9; rowBox += 3)
            {
                for(int colBox = 0; colBox < 9; colBox += 3)
                {
                    HashSet<char> seen = new HashSet<char>();

                    for(int row = rowBox; row < rowBox + 3; row++)
                    {
                        for(int col = colBox; col < colBox+3; col++)
                        {
                            char current = board[row][col];

                            if (current == '.')
                                continue;
                            if(!seen.Add(current))
                                return false;
                        }
                    }
                }
            }

            return true;

        }
    }
}
