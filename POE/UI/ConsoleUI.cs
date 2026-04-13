using System.Text;

namespace CyberSecurityAwarenessBot.UI
{
    /// <summary>
    /// Provides styled console output methods for the Cybersecurity Awareness Bot
    /// </summary>
    public static class ConsoleUI
    {
        private const int DefaultTypingDelay = 5;

        // =========================
        // Display Methods
        // =========================

        /// <summary>
        /// Displays the application header with ASCII art and branding
        /// </summary>
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("==============================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" 

            
        ╔══════════════════════╗
        ║   CYBER BOT v1.0     ║
        ╚══════════════════════╝

             [●]   [●]
               \___/
            .-'/   \'-.  
           /  |     |  \
          |   |     |   |
          |   |_____|   |
          |  /|     |\  |
          |_| |     | |_|
             /       \
            /_/     \_\

        >>> SECURITY MODE ACTIVE <<<
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Stay alert. Stay secure. Stay informed.");
            Console.WriteLine();
            Console.ResetColor();
        }

        // =========================
        // Message Output Methods
        // =========================

        /// <summary>
        /// Writes a bot message with typing effect in blue color
        /// </summary>
        /// <param name="message">The message to display</param>
        public static void WriteBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Bot: ");
            Console.ResetColor();
            TypeText(message);
            Console.WriteLine();
        }

        /// <summary>
        /// Writes a user prompt in blue color without a line break
        /// </summary>
        /// <param name="message">The prompt message to display</param>
        public static void WriteUserPrompt(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Writes an error message in red color
        /// </summary>
        /// <param name="message">The error message to display</param>
        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Writes a success message in blue color
        /// </summary>
        /// <param name="message">The success message to display</param>
        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // =========================
        // Helper Methods
        // =========================

        /// <summary>
        /// Creates a typing effect by displaying text character by character with a delay
        /// </summary>
        /// <param name="text">The text to display with typing effect</param>
        /// <param name="delay">Delay in milliseconds between each character (default: 5ms)</param>
        private static void TypeText(string text, int delay = DefaultTypingDelay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}