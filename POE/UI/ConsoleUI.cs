using System.Text;

namespace CyberSecurityAwarenessBot.UI
{
        
    public static class ConsoleUI
    {
        
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

        public static void WriteBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Bot: ");
            Console.ResetColor();
            TypeText(message);
            Console.WriteLine();
        }

        public static void WriteUserPrompt(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void TypeText(string text, int delay = 5)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}