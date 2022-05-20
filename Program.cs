using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
            public static int playerScore = 0;
            public static int computerScore = 0;
        public static void Main(string[] args)
        {
            DisplayScoreBoard();
        }
        
        static void DisplayScoreBoard()
        {
            while(true)
            {
                if(playerScore == 3)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                if(computerScore == 3)
                {
                    Console.WriteLine("You lost!");
                    break;
                }
                Console.WriteLine("---------------------------");
                Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");

                string answer = Console.ReadLine();

                int parsedAnswer = int.Parse(answer);
                Random r = new Random();
                int compAnswer = r.Next(1, 4);

                PlayGame(compAnswer, parsedAnswer);

            }
        }

        static void PlayGame(int computerAnswer, int playerAnswer)
        {
                RenderGame(playerAnswer);
                Console.WriteLine("VS");
                RenderGame(computerAnswer);

                GameLogic(computerAnswer, playerAnswer);
        }
        static void RenderGame(int choice)
        {
            switch(choice)
            {
                case 1:
                    Rock();
                    break;
                case 2:
                    Paper();
                    break;
                case 3:
                    Scissors();
                    break;
            }
        }

        static void GameLogic(int computerAnswer, int playerAnswer)
        {
            switch(playerAnswer)
            {
                case 1:
                    if(computerAnswer == 2)
                    {
                        computerScore++;
                        break;
                    }
                    else if(computerAnswer == 1)
                    {
                        break;
                    }
                    playerScore++;
                    break;
                case 2:
                    if(computerAnswer == 1)
                    {
                        playerScore++;
                        break;
                    }
                    else if(computerAnswer == 2)
                    {
                        break;
                    }
                    computerScore++;
                    break;
                case 3:
                    if(computerAnswer == 2)
                    {
                        playerScore++;
                        break;
                    }
                    else if(computerAnswer == 3)
                    {
                        break;
                    }
                    computerScore++;
                    break;
                    
            }
        }
        static void Rock()
        {   
            Console.WriteLine(@"
                ______
            ---'  ____)
                 (_____)
                 (_____)
                 (____)
            ---._(___)     
");
        }
        static void Paper()
        {
            Console.WriteLine(@"
                 _______
            ---'    ____)____
                        ______)
                       _______)
                      _______)
            ---.__________)
            ");
        }

        static void Scissors()
        {
            Console.WriteLine(@"
                _______
            ---'   ____)____
                      ______)
                   __________)
                  (____)
            ---.__(___)
            ");
        }

    }
}
