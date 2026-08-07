public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var seenRows = new bool[9,10];
        var seenCols = new bool[9,10];
        var seenBoxes = new bool[9,10];

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                int x = board[r][c] - '0';
                if (seenRows[r, x]) return false;
                if (seenCols[c, x]) return false;
                int b = (r/3)*3 + c/3;
                if (seenBoxes[b, x]) return false;

                seenRows[r, x] = seenCols[c, x] = seenBoxes[b, x] = true;
            }
        }

        return true;
    }

}
