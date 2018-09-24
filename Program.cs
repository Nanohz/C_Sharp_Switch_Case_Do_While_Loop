using System;

namespace CsharpLoopPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Presently in the United States, specifically in California, how old does a person have to be in order to purchase a tobacco product? ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool guess = false;

            do
            {

                switch (age)
                {

                    case 18:
                        Console.WriteLine("You guessed 18, which is incorrect");
                        Console.WriteLine("Please guess another number!");
                        age = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 19:
                        Console.WriteLine("You guessed 19, which is incorrect");
                        Console.WriteLine("Please guess another number!");
                        age = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 20:
                        Console.WriteLine("You guessed 20, which is incorrect");
                        Console.WriteLine("Please guess another number!");
                        age = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 21:
                        Console.WriteLine("Youg guessed 21, which is correct!");
                        Console.WriteLine("Congratulations, you have guessed correct! The legal age to purchase a tobacco product in the state of California is 21.");
                        guess = true;

                        break;

                    default:
                        Console.WriteLine("Sorry, incorrect guess : Please try again!");
                        Console.WriteLine("Please guess another number!");
                        age = Convert.ToInt32(Console.ReadLine());

                        break;


                }
            }
            while (!guess);
            Console.ReadLine();
        }
    }
}
