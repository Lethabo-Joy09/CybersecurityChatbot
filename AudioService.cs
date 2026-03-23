
#pragma warning disable CA1416  // SoundPlayer is Windows-only
using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class AudioService
    {
        private readonly string _audioPath;

        public AudioService()
        {
            _audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", "greeting.wav");
        }

        public async Task PlayGreetingAsync()
        {
            try
            {
                if (File.Exists(_audioPath))
                {
                    await Task.Run(() =>
                    {
                        using (SoundPlayer player = new SoundPlayer(_audioPath))
                        {
                            player.PlaySync();
                        }
                    });
                }
                else
                {
                    Console.WriteLine("[Audio file not found. Playing simulated greeting...]");
                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Audio playback error: {ex.Message}]");
            }
        }
    }
}
#pragma warning restore CA1416