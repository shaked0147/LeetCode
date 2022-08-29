public class Solution {
    public int NumIslands(char[][] grid) {
      int count = 2;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == '1')
                    {
                        grid = IslandIncrease(grid, i, j, (char)(count + 95));
                        count++;
                    }
                }
            }

            return count - 2;
    }
    
    public static char[][] IslandIncrease(char[][] grid, int sr, int sc, char count)
        {
            if (grid[sr][sc] == count)
                return grid;

            char a = '1';
            grid[sr][sc] = count;

            if (sr - 1 >= 0 && grid[sr - 1][sc] == a)
                grid = IslandIncrease(grid, sr - 1, sc, count);

            if (sr + 1 < grid.Length && grid[sr + 1][sc] == a)
                grid = IslandIncrease(grid, sr + 1, sc, count);

            if (sc - 1 >= 0 && grid[sr][sc - 1] == a)
                grid = IslandIncrease(grid, sr, sc - 1, count);

            if (sc + 1 < grid[0].Length && grid[sr][sc + 1] == a)
                grid = IslandIncrease(grid, sr, sc + 1, count);

            return grid;
        }
}