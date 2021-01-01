using System;

namespace Test_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! To begin yor journey please type the name of your character.");
            string name = Console.ReadLine();

            Console.WriteLine("Hello"+" "+ name + ". What a beutiful name!");
            Console.WriteLine("So in this game you have to play by only typing the number of the option you choose, else the game is going to crash :(");
            Console.WriteLine("You have to make the right decisiones to complete the game");
            Console.WriteLine("Question 1-You are alone in the forest. What you gonna do?");
            Console.WriteLine("Option 1-Find a shelter or Option 2-play cards with the aliens");

            string a1 = "1";
            
            string a = Console.ReadLine();
            
            if (a == a1)
            {
                Console.WriteLine("Thats right. Here's the next question!");
                Console.WriteLine("Now you are in a shelter!");
                Console.WriteLine("What you gonna do?");
                Console.WriteLine("Option 1-Start a campfire or Option 2-Panic");

                string b1 = "1";

                string b = Console.ReadLine();

                if (b == b1)
                {
                    Console.WriteLine("Congrats!You are awesome!Now you have a camp fire and you can rest.");
                    Console.WriteLine("But you find out you have notnig to eat!");
                    Console.WriteLine("Option 1-You are going to hunt some dinner ot Option 2-It's too hard to find food so you decide to have a quick nap");

                    string c1 = "1";

                    string c = Console.ReadLine();

                    if (c == c1)
                    {
                        Console.WriteLine("You found a deer!Now you can cook it and eat it!");
                        Console.WriteLine("Half an hour leter you finished eating and you decide to sleep");
                        Console.WriteLine("The next day you spot a helicopter in the sky!");
                        Console.WriteLine("Option 1-you light a big fire so the heli can notice you ot Option 2-You don't care about it");

                        string d1 = "1";

                        string d = Console.ReadLine();

                        if (d == d1)
                        {
                            Console.WriteLine("They noticed you and coming to save you!");
                            Console.WriteLine("Congratulations!!!You are saved and wid the game!!!");
                            Console.WriteLine("Hope you liked our game adn had fun!!! :)))");
                        }
                        else
                        {
                            Console.WriteLine("You missed you chance to find escape from the  forest and no one came for the next 70 years and you died from old age");
                            Console.ReadLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("You died from hunger");
                        Console.ReadLine();
                    }
               

                }
                else
                {
                    Console.WriteLine("You panicked and died from hypothermia");
                    Console.ReadLine();
                }
            }

                else
                {
                Console.WriteLine("Bad news!The aliens were bad and had lunch with you!");
                Console.ReadLine();
                }           
        }
    }
}
