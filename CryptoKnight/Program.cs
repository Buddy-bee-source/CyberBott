// ============================================================
// Program.cs - Entry Point
// This is the starting point of the CyberBot application.
// It sets up the console, plays the greeting, collects the
// user's name, and launches the chatbot.
// ============================================================

using System;
using CyberBot;

class Program
{
    static void Main(string[] args)
    {
        // Set the console window title shown at the top of the terminal
        Console.Title = "CyberBot - Cybersecurity Awareness Chatbot";

        // Allow special characters (emojis, symbols) to display correctly
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Create an AudioPlayer object and play the WAV greeting file
        // The file must be placed in the bin/Debug/net8.0/ folder
        AudioPlayer audio = new AudioPlayer("greeting.wav");
        audio.PlayGreeting();

        // Prompt the user to enter their name
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("\nEnter your name: ");
        Console.ResetColor(); // Reset to default colour after prompt

        // Read the name the user types
        string name = Console.ReadLine();

        // Input validation - keep asking until the user enters something
        // IsNullOrWhiteSpace checks for empty input or just spaces
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid name.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Enter your name: ");
            Console.ResetColor();

            name = Console.ReadLine();
        }

        // Create a User object with the trimmed name (removes extra spaces)
        User user = new User(name.Trim());

        // Create a Chatbot object and pass the user into it
        Chatbot bot = new Chatbot(user);

        // Start the main chat loop
        bot.Start();
    }
}