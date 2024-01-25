namespace Bitoperations;

public class MaxSumMatrixRangeHandler
{
    public MaxSumMatrixRange? GetMaxSumMatrixRange(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return null;

        int rowsCount = matrix.Length;
        int colsCount = matrix[0].Length;
        MaxSumMatrixRange maxSumMatrixRange = new(
                        StartRow: 0,
                        StartCol: 0,
                        EndRow: 0,
                        EndCol: 0,
                        Sum: matrix[0][0]);

        for (int startRow = 0; startRow < rowsCount; startRow++)
        {
            int[] rowsSum = new int[colsCount];

            for (int currRow = startRow; currRow < rowsCount; currRow++)
            {
                for (int currentCol = 0; currentCol < colsCount; currentCol++)
                {
                    rowsSum[currentCol] += matrix[currRow][currentCol];
                }

                MaxSumRange maxSumRange = GetMaxSumRange(rowsSum)!;

                if (maxSumRange.Sum > maxSumMatrixRange.Sum)
                    maxSumMatrixRange = new MaxSumMatrixRange(
                        StartRow: startRow,
                        StartCol: maxSumRange.Start,
                        EndRow: currRow,
                        EndCol: maxSumRange.End,
                        Sum: maxSumRange.Sum);
            }
        }

        return maxSumMatrixRange;
    }

    public MaxSumRange? GetMaxSumRange(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return null;

        MaxSumRange maxSumRange = new(0, 0, arr[0]);
        for (int start = 0; start < arr.Length; start++)
        {
            int currentSum = 0;
            for (int end = start; end < arr.Length; end++)
            {
                currentSum += arr[end];
                if (currentSum > maxSumRange.Sum)
                    maxSumRange = new MaxSumRange(start, end, currentSum);
            }
        }

        return maxSumRange;
    }
}
