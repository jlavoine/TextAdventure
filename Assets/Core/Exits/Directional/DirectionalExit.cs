
public enum Direction {
    North,
    South,
    East,
    West
}

public class DirectionalExit {
    public Direction Direction;
    public string TargetMapId;
    public string TargetRoomId;

    public override string ToString() {
        return Direction.ToString() + ": " + TargetRoomId + "(" + TargetMapId + ")"; 
    }
}
