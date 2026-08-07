public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        Span<int> seenRows  = stackalloc int[9];
        Span<int> seenCols  = stackalloc int[9];
        Span<int> seenBoxes = stackalloc int[9];

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                int d = board[r][c] - '0';
                int bit = 1 << d;

                if ((seenRows[r] & bit) != 0 || 
                    (seenCols[c] & bit) != 0)
                    return false;

                int b = (r/3)*3 + c/3;
                if ((seenBoxes[b] & bit) != 0) return false;

                seenRows[r] |= bit;
                seenCols[c] |= bit;
                seenBoxes[b] |= bit;
            }
        }

        return true;
    }

}
