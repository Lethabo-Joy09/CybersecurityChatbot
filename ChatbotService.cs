using System;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class ChatbotService
    {
        private readonly UIResponder _uiResponder;
        private readonly ResponseHandler _responseHandler;
        private string? _userName;

        public ChatbotService(UIResponder uiResponder)
        {
            _uiResponder = uiResponder;
            _responseHandler = new ResponseHandler();
        }

        public async Task StartChatAsync(string userName)
        {
            _userName = userName;

            _uiResponder.DisplayDivider();
            _uiResponder.DisplayBotMessage($"I'm here to help you stay safe online, {_userName}! 🔒");
            _uiResponder.DisplayHelpMenu();

            bool isRunning = true;
            while (isRunning)
            {
                Console.Write("\n💬 You: ");
                string? userInput = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    _uiResponder.DisplayErrorMessage("I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                string response = _responseHandler.GetResponse(userInput);

                if (userInput.ToLower().Contains("exit") ||
                    userInput.ToLower().Contains("quit") ||
                    userInput.ToLower().Contains("bye"))
                {
                    isRunning = false;
                }

                _uiResponder.DisplayBotMessage(response);
                await Task.Delay(500);
            }
        }
    }
}