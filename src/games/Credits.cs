public class Credits : Game
{
    public override string Name => "Credits";

    public override void Play()
    {
        int delay = 50;

        foreach (string key in Constants.Credits.Keys)
        {
            Helpers.Typing(key, delay);
            foreach (string value in Constants.Credits[key])
            {
                if (Helpers.HasPressed(ConsoleKey.Enter))
                    delay = 0;

                Helpers.Typing($" - {value}", delay);
                Thread.Sleep(delay == 0 ? 0 : 100);
            }
            Thread.Sleep(delay == 0 ? 0 : 250);
        }
    }
}