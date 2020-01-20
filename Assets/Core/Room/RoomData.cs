
public class RoomData {
    public string Id;
    public string Title;
    public string Description;

    public override string ToString() {
        return Id + " - " + Title + "\n" + Description;
    }
}
