public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        
        int rows = mat.Length;
        int cols = mat[0].Length;
        
        for(int row = 0; row < rows; row++) {
            var diagonal = ReadDiagonal(mat, row, 0, rows, cols);
            diagonal.Sort();
            ReplaceDiagonal(mat, diagonal, row, 0);
        }
        
        for(int col = 1; col < cols; col++) {
            var diagonal = ReadDiagonal(mat, 0, col, rows, cols);
            diagonal.Sort();
            ReplaceDiagonal(mat, diagonal, 0, col);
        }
        
        return mat;
    }
    
    private List<int> ReadDiagonal(int[][]mat, int row, int col, int maxRow, int maxCol) {
        List<int> result = new List<int>();
        
        while(row < maxRow && col < maxCol) {
            result.Add(mat[row++][col++]);
        }
        
        return result;
    }
    
    private void ReplaceDiagonal(int[][] mat, IEnumerable<int> newDiag, int startRow, int startCol) {
        foreach(var val in newDiag) {
            mat[startRow++][startCol++] = val;
        }
    
    }
}