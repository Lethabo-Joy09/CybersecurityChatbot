using System;
using System.Collections.Generic;
using System.Linq;   // <-- needed for .Any()

namespace CybersecurityChatbot
{
    public class ResponseHandler
    {
        private readonly List<ChatResponse> _responses;

        public ResponseHandler()
        {
            _responses = InitializeResponses();
        }

        private List<ChatResponse> InitializeResponses()
        {
            return new List<ChatResponse>
            {
                new ChatResponse
                {
                    Category = "Greeting",
                    Keywords = new[] { "how are you", "how are u", "how do you do" },
                    Response = "I'm operating securely! Thanks for asking. How can I help you stay safe online today?"
                },
                new ChatResponse
                {
                    Category = "Purpose",
                    Keywords = new[] { "what is your purpose", "what can you do", "what do you do", "help me with" },
                    Response = "I'm a Cybersecurity Awareness Bot designed to help you learn about online safety! I can provide tips on password security, phishing prevention, safe browsing, and more. What would you like to know?"
                },
                new ChatResponse
                {
                    Category = "Password Safety",
                    Keywords = new[] { "password", "passwords", "password safety", "secure password" },
                    Response = "🔐 PASSWORD SAFETY TIPS:\n" +
                              "• Use long passwords (12+ characters) with a mix of uppercase, lowercase, numbers, and symbols\n" +
                              "• Never reuse passwords across different accounts\n" +
                              "• Enable Two-Factor Authentication (2FA) whenever possible\n" +
                              "• Use a password manager to generate and store strong passwords\n" +
                              "• Avoid using personal information like birthdays or names"
                },
                new ChatResponse
                {
                    Category = "Phishing",
                    Keywords = new[] { "phishing", "phish", "scam email", "suspicious email" },
                    Response = "🎣 PHISHING DETECTION TIPS:\n" +
                              "• Check the sender's email address carefully - scammers use fake addresses\n" +
                              "• Hover over links before clicking to see the actual URL\n" +
                              "• Look for spelling and grammar mistakes\n" +
                              "• Never share personal information via email\n" +
                              "• Be wary of urgent or threatening language\n" +
                              "• When in doubt, contact the company directly using official channels"
                },
                new ChatResponse
                {
                    Category = "Safe Browsing",
                    Keywords = new[] { "browsing", "safe browsing", "browser", "internet safety" },
                    Response = "🌐 SAFE BROWSING PRACTICES:\n" +
                              "• Always look for 'https://' and the padlock icon in the address bar\n" +
                              "• Keep your browser and extensions updated\n" +
                              "• Use ad-blockers and privacy extensions\n" +
                              "• Don't download files from untrusted sources\n" +
                              "• Clear your cache and cookies regularly\n" +
                              "• Use a reputable VPN on public Wi-Fi"
                },
                new ChatResponse
                {
                    Category = "2FA",
                    Keywords = new[] { "2fa", "two factor", "two-factor", "mfa", "multifactor" },
                    Response = "🔑 TWO-FACTOR AUTHENTICATION (2FA):\n" +
                              "2FA adds an extra layer of security to your accounts. Even if someone steals your password, they can't access your account without the second factor.\n\n" +
                              "Types of 2FA:\n" +
                              "• SMS codes (least secure)\n" +
                              "• Authentication apps like Google Authenticator or Authy\n" +
                              "• Hardware keys like YubiKey (most secure)\n\n" +
                              "I highly recommend enabling 2FA on all your important accounts!"
                },
                new ChatResponse
                {
                    Category = "General Tips",
                    Keywords = new[] { "tips", "advice", "recommendations", "best practices" },
                    Response = "💡 TOP CYBERSECURITY TIPS:\n" +
                              "1. Keep all software updated\n" +
                              "2. Use unique passwords for each account\n" +
                              "3. Enable 2FA everywhere possible\n" +
                              "4. Think before clicking links\n" +
                              "5. Backup important data regularly\n" +
                              "6. Use antivirus software\n" +
                              "7. Be careful what you share on social media"
                }
            };
        }

        public string GetResponse(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "I didn't catch that. Could you please say something?";
            }

            string lowerInput = userInput.ToLower();

            // Exit commands
            if (lowerInput.Contains("exit") || lowerInput.Contains("quit") || lowerInput.Contains("bye"))
            {
                return "Goodbye! Stay safe online! 🔒";
            }

            // Try to match a keyword
            foreach (var response in _responses)
            {
                if (response.Keywords.Any(keyword => lowerInput.Contains(keyword)))
                {
                    return response.Response;
                }
            }

            // Default fallback – this ensures all code paths return a value
            return "I'm not sure I understand that question. 🤔\n\n" +
                   "I can help you with:\n" +
                   "• Password safety tips\n" +
                   "• Phishing detection\n" +
                   "• Safe browsing practices\n" +
                   "• Two-factor authentication\n" +
                   "• General cybersecurity advice\n\n" +
                   "Could you rephrase your question?";
        }
    }
}
