using CyberSecurityAwarenessBot.Models;
using CyberSecurityAwarenessBot.Services;
using CyberSecurityAwarenessBot.UI;

namespace CyberSecurityAwarenessBot
{
    internal class Program
    {
        // Simple memory feature
        static string lastTopic = "";

        static void Main()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ConsoleUI.DisplayHeader();
            AudioPlayer.PlayGreeting("Assets/Greetings.wav");

            ConsoleUI.WriteBotMessage("\nHello! Welcome to the Cybersecurity Awareness Bot.");
            ConsoleUI.WriteBotMessage("I am here to help you stay safe online.");
            ConsoleUI.WriteBotMessage("\nYou can ask me things like:");
            ConsoleUI.WriteBotMessage("  : How are you?");
            ConsoleUI.WriteBotMessage("  : What's your purpose?");
            ConsoleUI.WriteBotMessage("  : What can I ask you about?");
            ConsoleUI.WriteBotMessage("  : Tell me about password safety");
            ConsoleUI.WriteBotMessage("  : What is phishing?");
            ConsoleUI.WriteBotMessage("  : How do I browse safely?");
            ConsoleUI.WriteBotMessage("\nChoose an option from the menu below to get started.\n");

            UserProfile user = new UserProfile();
            ChatbotService chatbot = new ChatbotService();

            bool running = true;

            while (running)
            {
                ShowMenu();
                string? option = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(option))
                {
                    ConsoleUI.WriteBotMessage("Invalid option. Try again.");
                    continue;
                }

                switch (option)
                {
                    case "1":
                        RunChat();
                        break;

                    case "2":
                        RunChallenge();
                        break;

                    case "3":
                        ConsoleUI.WriteBotMessage("Goodbye! Stay safe online.");
                        running = false;
                        break;

                    default:
                        ConsoleUI.WriteBotMessage("Invalid option. Try again.");
                        break;
                }
            }
        }

        // =========================
        // Chat System
        // =========================
        static void RunChat()
        {
            ConsoleUI.WriteBotMessage("Welcome to the Cybersecurity Chat!");
            ConsoleUI.WriteBotMessage("\nYou can ask me about:");
            ConsoleUI.WriteBotMessage("  • Password safety and strong passwords");
            ConsoleUI.WriteBotMessage("  • Phishing attacks and how to identify them");
            ConsoleUI.WriteBotMessage("  • Online scams and fraud prevention");
            ConsoleUI.WriteBotMessage("  • Safe browsing practices");
            ConsoleUI.WriteBotMessage("  • Two-factor authentication");
            ConsoleUI.WriteBotMessage("  • Data protection and privacy");
            ConsoleUI.WriteBotMessage("\nExample questions:");
            ConsoleUI.WriteBotMessage("  - What is phishing?");
            ConsoleUI.WriteBotMessage("  - How do I create a strong password?");
            ConsoleUI.WriteBotMessage("  - How can I browse safely?");
            ConsoleUI.WriteBotMessage("  - What are common online scams?");
            ConsoleUI.WriteBotMessage("\nType 'exit' to return to the main menu.\n");

            ResponseService responseService = new ResponseService();

            while (true)
            {
                Console.Write("You: ");
                string? input = Console.ReadLine();

                if (input == null) continue;

                input = input.ToLower();

                if (input == "exit")
                    break;

                // Simple memory
                if (input.Contains("phishing")) lastTopic = "phishing";
                else if (input.Contains("password")) lastTopic = "password safety";
                else if (input.Contains("scam")) lastTopic = "online scams";

                string response = responseService.GetResponse(input, "User");

                ConsoleUI.WriteBotMessage(response);

                ShowRandomTip();

                if (!string.IsNullOrEmpty(lastTopic))
                {
                    ConsoleUI.WriteBotMessage("(We’ve been talking about " + lastTopic + ")");
                }
            }
        }

        // =========================
        // Challenge Mode (Unique Feature)
        // =========================
        static void RunChallenge()
        {
            Console.Clear();

            ConsoleUI.WriteBotMessage("Quick Challenge!");

            Console.WriteLine("\nYou receive this message:");
            Console.WriteLine("\"Your bank account is locked. Click here to fix it.\"");

            Console.WriteLine("\n1. Click the link");
            Console.WriteLine("2. Ignore it");
            Console.WriteLine("3. Report it");

            Console.Write("\nEnter choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConsoleUI.WriteBotMessage("That is risky! This is likely a phishing scam.");
                    break;

                case "2":
                    ConsoleUI.WriteBotMessage("Better, but reporting it is safer.");
                    break;

                case "3":
                    ConsoleUI.WriteBotMessage("Excellent! You handled it correctly.");
                    break;

                default:
                    ConsoleUI.WriteBotMessage("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        // =========================
        // Random Tips
        // =========================
        static void ShowRandomTip()
        {
            string[] tips =
            {
                "Use strong passwords.",
                "Do not click unknown links.",
                "Enable two-factor authentication.",
                "Avoid public Wi-Fi for sensitive data.",
                "Phishing is very common."
            };

            Random rand = new Random();
            Console.WriteLine("\nTip: " + tips[rand.Next(tips.Length)]);
        }

        // =========================
        // Menu
        // =========================
        static void ShowMenu()
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Chat");
            Console.WriteLine("2. Quick Challenge");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
        }
    }
}