public class PromptGenerator
{
    // compact version of creating a list
    public List<string> _prompts;
    public PromptGenerator()
    {
        // this time the list is not empty, but has preset entries to be used.
        // separated by commas to turn each into its own line.
        _prompts = ["Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was something kind I did today?",
        "When could I have better used my time?",
        "Did I study today? What was it about?"];
    }
    // creates a random feature.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}