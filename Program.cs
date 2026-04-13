using System;
using System.Threading;
using System.Media;

public class CyberChatBot
{
    static void Main()
    {

    }

        public void Start()
    {
        PlayVoiceGreeting();
        ShowAsciiArt();
        

    }

    static void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("Recording not found.");
        }

    }

    private void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@" 
                _='`'=_ 
               //(@_@)\\
               |||(Y)|||    
               \\\\ ////  
                OOOOOOO
                / )`( \  
             <\(  )'(  ) 
              (__w)_(w__)

    BOBO DOGG AWARENESS CHATBOT");

        Console.ResetColor();


    }

    private void GetUserName()
    {
        Console.WriteLine("=========================================================================================");
        Console.Write("Please enter your name:");
        userName = Console.ReadLine();
       TextHelper. TypeText($"GoodDay, {userName}!Welcome to the Cybersecurity Awareness Bot, How may I assist you today? 🐶");
        Console.WriteLine("==========================================================================================");
    }

    static void StartChat(String UserName)
    {
        String input;

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            input = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BOBO DOGG: Please enter something. I didn't quite understand that.");
                Console.ResetColor();
                continue;
            }

            input = input.ToLower();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("BOBO DOGG: ");


            if (input.Contains("how are you "))
            {
                Console.WriteLine("I'm just a bot, but I'm here and ready to help you!");
            }
            else if (input.Contains("your purpose"))
            {
                Console.WriteLine("My  main purpose is to help you stay safe online.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You may ask me about passwords, phishing, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Please use strong passwords with uppercase, lowercase, numbers, and symbols.");
            }
            else if (input.Contains(" What is phishing?"))
            {
                Console.WriteLine("Phishing is when attackers try to trick you into giving personal info. You should avoid clicking suspicious links.");
            }

            else if (input.Contains(" What is safe browsing?") || input.Contains("browsing"))
            {
                Console.WriteLine(" When you only visit secure websites (https) and avoid downloading unknown files.");
            }
            else if (input == "exit")
            {
                Console.WriteLine($"Goodbye {userName}🐶! Please Stay safe online and do practice good cybersecurity habits👍.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I didn't quite understand that.Please Could you rephrase?");
            }

            Console.ResetColor();

        } while (input != " Please exit");
    }
}

    
    
