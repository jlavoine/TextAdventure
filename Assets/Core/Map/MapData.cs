using System.Collections.Generic;

public class MapData {
    public string Id;
    public List<RoomData> Rooms;

    public override string ToString() {
        string text = "Map for " + Id + "\n";
        foreach (RoomData room in Rooms)
        {
            text += room + "\n";
        }

        return text;
    }
}
