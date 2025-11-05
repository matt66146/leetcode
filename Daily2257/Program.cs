

int unguardedCells = Solution.CountUnguarded(4, 6, [[0, 0], [1, 1], [2, 3]], [[0, 1], [2, 2], [1, 4]]);
Console.WriteLine(unguardedCells);

unguardedCells = Solution.CountUnguarded(3, 3, [[1, 1]], [[0, 1], [1, 0], [2, 1], [1, 2]]);
Console.WriteLine(unguardedCells);

class Solution
{
    public static int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        int unguardedCells = 0;
        Dictionary<(int y, int x), CellStatus> cellStatuses = new();
        foreach (var guard in guards)
        {
            cellStatuses[(guard[0], guard[1])] = CellStatus.Guard;
        }
        foreach (var wall in walls)
        {
            cellStatuses[(wall[0], wall[1])] = CellStatus.Wall;
        }

        List<(int y, int x)> keys = new(cellStatuses.Keys);
        foreach ((int y, int x) key in keys)
        {
            if (cellStatuses[key] == CellStatus.Guard)
            {
                //left
                for (int x = key.x - 1; x >= 0; x--)
                {
                    if (!cellStatuses.ContainsKey((key.y, x)))
                    {
                        cellStatuses[(key.y, x)] = CellStatus.Guarded;
                    }
                    else if (cellStatuses[(key.y, x)] != CellStatus.Guarded)
                    {
                        break;
                    }
                }
                //right
                for (int x = key.x + 1; x < n; x++)
                {
                    if (!cellStatuses.ContainsKey((key.y, x)))
                    {
                        cellStatuses[(key.y, x)] = CellStatus.Guarded;
                    }
                    else if (cellStatuses[(key.y, x)] != CellStatus.Guarded)
                    {
                        break;
                    }
                }
                //up
                for (int y = key.y - 1; y >= 0; y--)
                {
                    if (!cellStatuses.ContainsKey((y, key.x)))
                    {
                        cellStatuses[(y, key.x)] = CellStatus.Guarded;
                    }
                    else if (cellStatuses[(y, key.x)] != CellStatus.Guarded)
                    {
                        break;
                    }
                }
                //down
                for (int y = key.y + 1; y < m; y++)
                {
                    if (!cellStatuses.ContainsKey((y, key.x)))
                    {
                        cellStatuses[(y, key.x)] = CellStatus.Guarded;
                    }
                    else if (cellStatuses[(y, key.x)] != CellStatus.Guarded)
                    {
                        break;
                    }
                }
            }
        }

        for (int y = 0; y < m; y++)
        {
            for (int x = 0; x < n; x++)
            {
                if (!cellStatuses.ContainsKey((y, x)))
                {
                    unguardedCells++;
                }
            }
        }
        return unguardedCells;
    }

}

enum CellStatus
{
    Guard,
    Guarded,
    Wall
}
