public class Scripture
{
    public ScriptureReference Reference { get; }
    public string Text { get; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public string GetFullText()
    {
        return $"{Reference.ToString()} - {Text}";
    }
}
