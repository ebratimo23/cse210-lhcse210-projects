public class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int VerseStart { get; }
    public int? VerseEnd { get; }

    public ScriptureReference(string reference)
    {
        // Example reference: "John 3:16-17" or "Proverbs 3:5"
        string[] parts = reference.Split(':');
        Book = parts[0].Trim();
        string versePart = parts[1].Trim();

        if (versePart.Contains("-"))
        {
            string[] verseRange = versePart.Split('-');
            VerseStart = int.Parse(verseRange[0]);
            VerseEnd = int.Parse(verseRange[1]);
        }
        else
        {
            VerseStart = int.Parse(versePart);
            VerseEnd = null;
        }

        string chapterString = reference.Substring(reference.IndexOf(' ') + 1, reference.IndexOf(':') - reference.IndexOf(' ') - 1);
        Chapter = int.Parse(chapterString);
    }

    public override string ToString()
    {
        if (VerseEnd.HasValue)
            return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
        else
            return $"{Book} {Chapter}:{VerseStart}";
    }
}
