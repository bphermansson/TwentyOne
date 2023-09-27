using static TwentyOne.Questions;
using static TwentyOne.GetCardClass;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            while (true)
            {
                #region player
                string answer = "";
                Console.Clear();
                Console.WriteLine("*** Welcome to 21! ***\n");
                Console.WriteLine("Your turn");

                int result = TwoCards();
                Console.WriteLine($"Your result: {result}");

                if (ToHigh(result))
                {
                    answer = "n";
                    gameOver = true;
                    Thread.Sleep(2000);
                    continue;
                }

                while (answer != "n")
                {
                    Console.WriteLine("Another card? (y/n)");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        gameOver = false;
                        var newCard = new Card();
                        var newCardValue = newCard.getValue;
                        string newCardName = GetCardName(newCardValue);
                        result = result + newCardValue;

                        Console.WriteLine($"{newCard.getColor} {newCardName}");
                        Console.WriteLine($"Your result: {result}");

                        if (ToHigh(result))
                        {
                            gameOver = true;
                            answer = "n";
                            continue;
                        }
                    }
                }

                if (gameOver == true)
                {
                   if (Again())
                    {
                        continue;
                    }
                }
                #endregion

                #region dealer
                // The player is pleased, let's see what the computer gets.
                int dealerRes = 0;

                    Console.WriteLine("Dealers turn");
                    for (int i = 0; i < 2; i++)
                    {
                        var c = GetCardClass.GetCard();
                        Thread.Sleep(2000);
                        dealerRes += c.cardValue;
                    }
                    Console.WriteLine($"Result {dealerRes}");
                    Thread.Sleep(2000);
                    
                    answer = "";
                    if (ToHigh(dealerRes) || dealerRes >= 15)
                    {
                        answer = "n";
                    }
                
                while (answer != "n")
                {
                    var newCard = new Card();
                    var newCardValue = newCard.getValue;
                    string newCardName = GetCardName(newCardValue);
                    dealerRes = dealerRes + newCardValue;

                    Console.WriteLine($"{newCard.getColor} {newCardName}");
                    Console.WriteLine($"Dealers result: {dealerRes}");
                    Thread.Sleep(2000);

                    // When shall the dealer stop?
                    if (ToHigh(dealerRes) || dealerRes >= 15)
                    {
                        answer = "n";
                    }
                }
                #endregion

                if (result > dealerRes || dealerRes > 21)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You loose!");
                }

                if (Questions.Again())
                {
                    continue;
                }
            }
        }
    }
}