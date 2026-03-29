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

                // Check for empty input
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    _uiResponder.DisplayErrorMessage("I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                // Check for exit commands FIRST
                string lowerInput = userInput.ToLower();
                if (lowerInput == "exit" || lowerInput == "quit" || lowerInput == "bye")
                {
                    isRunning = false;
                    // Display goodbye message
                    _uiResponder.DisplayBotMessage("Goodbye! Stay safe online! 🔒");
                    // Break out of the loop immediately
                    break;
                }

                // Get response for valid question
                string response = _responseHandler.GetResponse(userInput);
                _uiResponder.DisplayBotMessage(response);

                await Task.Delay(500);
            }
        }
    }
}