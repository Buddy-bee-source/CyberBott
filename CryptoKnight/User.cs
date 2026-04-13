// ============================================================
// User.cs - User Data Model
// This class represents the person using the chatbot.
// It stores the user's name and generates a personalised
// greeting message to make the experience more friendly.
// ============================================================

namespace CyberBot
{
    public class User
    {
        // Property to store the user's name
        // { get; set; } means it can be read and changed
        public string Name { get; set; }

        // Constructor - runs when a new User object is created
        // Receives the name entered by the user in Program.cs
        public User(string name)
        {
            Name = name;
        }

        // Returns a personalised welcome message using the user's name
        public string GetGreeting()
        {
            return $"Hello, {Name}! Welcome to the Cybersecurity Awareness Bot.";
        }
    }
}
