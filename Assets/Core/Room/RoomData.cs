using System.Collections.Generic;

public class RoomData {
    public string Id;
    public string Title;
    public string Description;
    public List<DirectionalExit> DirectionalExits; 

    public override string ToString() {
        string text = Id + " - " + Title + "\n " + Description + "\n";

        foreach (DirectionalExit exit in DirectionalExits) {
            text += "   " + exit + "\n";
        }

        return text;
    }
}
