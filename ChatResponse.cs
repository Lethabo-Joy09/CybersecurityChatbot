namespace CybersecurityChatbot
{
    public class ChatResponse
    {
        public string Category { get; set; } = string.Empty;
        public string Response { get; set; } = string.Empty;
        public string[] Keywords { get; set; } = Array.Empty<string>();
    }
}