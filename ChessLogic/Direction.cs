namespace ChessLogic;

public class Direction(int rowDelta, int columnDelta)
{
    public readonly static Direction North = new(-1, 0);
    public readonly static Direction South = new(1, 0);
    public readonly static Direction East = new(0, 1);
    public readonly static Direction West = new(0, -1);

    public readonly static Direction NorthEast = North + East;
    public readonly static Direction NorthWest = North + West;
    public readonly static Direction SouthEast = South + East;
    public readonly static Direction SouthWest = South + West;
    public int RowDelta { get; } = rowDelta;
    public int ColumnDelta { get; } = columnDelta;

    public static Direction operator +(Direction dir1, Direction dir2)
    {
        return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.ColumnDelta + dir2.ColumnDelta);
    }

    public static Direction operator *(int scaler, Direction dir)
    {
        return new Direction(scaler * dir.RowDelta, scaler * dir.ColumnDelta);
    }
}
