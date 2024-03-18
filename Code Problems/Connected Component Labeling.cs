/* Given an array of numbers, a starting point in that array and a replacement number. Replace the value at 
 starting point with the given replacement value. Do the same for all points connected to the starting point 
 through sides which have the same value as the starting point.

Array:
[[0,1,0,0,0],
[1,1,1,0,0],
[1,1,0,0,0],
[0,1,0,1,0]]

Replacement number 2:
location [1,2]

Resulting Array:
[[0,2,0,0,0],
[2,2,2,0,0],
[2,2,0,0,0],
[0,2,0,1,0]] */

// initial solutions
// complexity of O(n^2)

/*
int[][] solution(int[][] array, int row, int column, int replace) {
    
    if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(0)) {
        return array;
    }
   
    if (array[row][column] != replace && array[row][column] != 0) {
        array[row][column] = replace; // replace element
        
        solution(array, row - 1, column, replace); // check above
        solution(array, row + 1, column, replace); // check below
        solution(array, row, column - 1, replace); // check left
        solution(array, row, column + 1, replace); // check right
    }
   
   return array;
}
*/

// refactored code to reduce complexity to O(n)

int[][] IterativeSolution(int[][] array, int startRow, int startColumn, int replace)
{
    // Check if start indices are valid
    if (startRow < 0 || startRow >= array.GetLength(0) || startColumn < 0 || startColumn >= array.GetLength(1))
    {
        return array;
    }

    int originalValue = array[startRow][startColumn];
    if (originalValue == replace || originalValue == 0)
    {
        return array; // No need to process if originalValue is equal to replace or 0
    }

    Queue<(int, int)> queue = new Queue<(int, int)>();
    queue.Enqueue((startRow, startColumn));
    array[startRow][startColumn] = replace; // Replace the starting element

    while (queue.Count > 0)
    {
        var (row, col) = queue.Dequeue();

        // Check adjacent cells (up, down, left, right)
        foreach (var (dr, dc) in new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) })
        {
            int newRow = row + dr;
            int newCol = col + dc;

            if (newRow >= 0 && newRow < array.GetLength(0) && newCol >= 0 && newCol < array[newRow].Length &&
                array[newRow][newCol] == originalValue)
            {
                array[newRow][newCol] = replace; // Replace the adjacent element
                queue.Enqueue((newRow, newCol)); // Enqueue for further processing
            }
        }
    }

    return array;
}
