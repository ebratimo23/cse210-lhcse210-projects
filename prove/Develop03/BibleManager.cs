public class BibleManager
{
    private List<Scripture> scriptures;

    public BibleManager()
    {
        
        scriptures = new List<Scripture>
        {
            new Scripture(new ScriptureReference("Proverbs 3:5-6"), "Trust in the Lord with all your heart, And lean not on your own understanding; In all your ways acknowledge Him, And He shall direct your paths.")
        };
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}
