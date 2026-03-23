using System;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    class Program
    {
        private static AudioService? _audioService;
        private static UIResponder? _uiResponder;
        private static ChatbotService? _chatbotService;

        static async Task Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.CursorVisible = true;

            _audioService = new AudioService();
            _uiResponder = new UIResponder();
            _chatbotService = new ChatbotService(_uiResponder);

            _uiResponder.DisplayAsciiArt();
            await _audioService.PlayGreetingAsync();

            string userName = _uiResponder.DisplayWelcomeAndGetName();
            await _chatbotService.StartChatAsync(userName);

            _uiResponder.DisplayExitMessage(userName);
        }
    }
}