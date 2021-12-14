using Godot;
using Newtonsoft.Json;

public class Main : Node2D
{
    public override void _Ready()
    {
        File file = new File();
        file.Open("res://NNet.json", File.ModeFlags.Read);
        var obj = JsonConvert.DeserializeObject<NNet>(file.GetAsText());
    }
}
