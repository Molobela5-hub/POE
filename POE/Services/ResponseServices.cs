namespace CyberSecurityAwarenessBot.Services
{
    public class ResponseService
    {
        public string GetResponse(string userInput, string userName)
        {
            string input = userInput.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return "You entered nothing. Please type a question so I can help you.";
            }

            switch (input)
            {
                case string s when s.Contains("how are you"):
                    return $"I am doing well, {userName}. Thank you for asking. I am ready to help you with cybersecurity awareness.";

                case string s when s.Contains("what's your purpose") || s.Contains("what is your purpose"):
                    return "My purpose is to educate users about cybersecurity risks and help them stay safe online.";

                case string s when s.Contains("what can i ask you about"):
                    return "You can ask me about password safety, phishing, suspicious links, scams, safe browsing, and basic online protection.";

                case string s when s.Contains("password"):
                    return "Use strong passwords with a mix of uppercase letters, lowercase letters, numbers, and symbols. Avoid using your name or birth date.";

                case string s when s.Contains("phishing"):
                    return "Phishing is a scam where attackers pretend to be trusted organisations to steal your personal information. Do not click suspicious links or share passwords.";

                case string s when s.Contains("safe browsing") || s.Contains("browse safely") || s.Contains("browsing"):
                    return "To browse safely, only visit trusted websites, check for HTTPS, avoid clicking unknown pop-ups, and keep your browser updated.";

                case string s when s.Contains("suspicious link") || s.Contains("link"):
                    return "Before clicking a link, hover over it to inspect the URL. If it looks strange, shortened, or unrelated to the sender, do not click it.";

                case string s when s.Contains("scam"):
                    return "Online scams often create urgency or fear. Be cautious of messages asking for money, OTPs, passwords, or banking details.";

                case "exit":
                    return $"Goodbye, {userName}. Stay safe online!";

                default:
                    return "I didn’t quite understand that. Could you rephrase? You can ask about passwords, phishing, or safe browsing.";
            }
        }
    }
}