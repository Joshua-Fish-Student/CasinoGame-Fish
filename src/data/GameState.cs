public class GameState {
    public readonly SaveData saveData = new SaveData("data/savedata.props");
    public bool loseSwitch = false;
    public int drunkLevel = 0;
    public int money
    {
        get => saveData.GetOrDefault("money", 200);
        set => saveData.SetValue("money", Math.Max(0, value)); 
    }

    public bool hasPlayedBefore 
    {
        get => saveData.GetOrDefault("has-played-before", false);
        set => saveData.SetValue("has-played-before", value);
    }
}