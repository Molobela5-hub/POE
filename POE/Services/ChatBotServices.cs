using CyberSecurityAwarenessBot.Models;
using CyberSecurityAwarenessBot.UI;

namespace CyberSecurityAwarenessBot.Services
{
    public class ChatbotService
    {
        private readonly ResponseService _responseService;

        public ChatbotService()
        {
            _responseService = new ResponseService();
        }

        public void StartChat(UserProfile user)
        {
            while (true)
            {
                ConsoleUI.WriteUserPrompt($"{user.Name}: ");
                string? userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    ConsoleUI.WriteError("Invalid input. Please enter a valid question.");
                    continue;
                }

                string response = _responseService.GetResponse(userInput, user.Name);
                ConsoleUI.WriteBotMessage(response);

                if (userInput.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}