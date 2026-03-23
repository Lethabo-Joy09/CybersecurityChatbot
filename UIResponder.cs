using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public class UIResponder
    {
        public void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiArt = @"
    ╔══════════════════════════════════════════════════════════════╗
    ║                                                              ║
    ║    ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗         ║
    ║   ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝         ║
    ║   ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗         ║
    ║   ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║         ║
    ║   ╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║         ║
    ║    ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝         ║
    ║                                                              ║
    ║           █████╗ ██╗    ██╗ █████╗ ██████╗ ███████╗         ║
    ║          ██╔══██╗██║    ██║██╔══██╗██╔══██╗██╔════╝         ║
    ║          ███████║██║ █╗ ██║███████║██████╔╝█████╗           ║
    ║          ██╔══██║██║███╗██║██╔══██║██╔══██╗██╔══╝           ║
    ║          ██║  ██║╚███╔███╔╝██║  ██║██║  ██║███████╗         ║
    ║          ╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝         ║
    ║                                                              ║
    ║              C Y B E R S E C U R I T Y                       ║
    ║              A W A R E N E S S   B O T                       ║
    ║                                                              ║
    ╚══════════════════════════════════════════════════════════════╝";

            Console.WriteLine(asciiArt);
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        public string DisplayWelcomeAndGetName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            DisplayDivider();
            Console.WriteLine("🌟 WELCOME TO THE CYBERSECURITY AWARENESS BOT 🌟");
            DisplayDivider();
            Console.ResetColor();

            Console.Write("\n📝 Please enter your name: ");
            string? userName = Console.ReadLine()?.Trim();
            userName = string.IsNullOrWhiteSpace(userName) ? string.Empty : userName;

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("⚠️  Name cannot be empty. Please enter your name: ");
                Console.ResetColor();
                userName = Console.ReadLine()?.Trim() ?? string.Empty;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n✨ Hello, {userName}! ✨");
            Console.ResetColor();

            return userName;
        }

        public void DisplayDivider()
        {
            Console.WriteLine("═══════════════════════════════════════════════════════════════");
        }

        public void DisplaySectionHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n📌 {title}");
            Console.ResetColor();
        }

        public void DisplayBotMessage(string message, bool withTypingEffect = true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n🤖 Bot: ");
            Console.ResetColor();

            if (withTypingEffect)
            {
                TypewriterEffect(message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        public void DisplayUserMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n👤 You: ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        private void TypewriterEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }

        public void DisplayErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"❌ {message}");
            Console.ResetColor();
        }

        public void DisplayInfoMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"ℹ️  {message}");
            Console.ResetColor();
        }

        public void DisplayHelpMenu()
        {
            DisplayDivider();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("💡 You can ask me about:");
            Console.ResetColor();
            Console.WriteLine("  • Password safety tips");
            Console.WriteLine("  • How to identify phishing emails");
            Console.WriteLine("  • Safe browsing practices");
            Console.WriteLine("  • Two-factor authentication");
            Console.WriteLine("  • My purpose and capabilities");
            Console.WriteLine("\n💬 Try asking: 'How are you?', 'What can you help with?', or any cybersecurity question!");
            DisplayDivider();
        }

        public void DisplayExitMessage(string userName)
        {
            DisplayDivider();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n👋 Thank you for chatting, {userName}! Stay safe online! 🔒");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}