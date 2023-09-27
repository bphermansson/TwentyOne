namespace TwentyOne
{
    public class GetCardClass
    {
        public static int TwoCards()
        {
            int result=0;
            for (int i = 0; i < 2; i++)
            {
                var c = GetCard();
                Thread.Sleep(2000);
                result += c.cardValue;
            }
            return result;
        }
        public static SingleCard GetCard()
        {
            var card = new Card();
            SingleCard sc = new SingleCard();
            sc.cardValue = card.getValue;
            if (sc.cardValue > 10)
            {
                sc.cardNameValue = GetName(sc.cardValue) + " of";
            }
            else
            {
                sc.cardNameValue = sc.cardValue.ToString();
            }
            Console.WriteLine($"New Card: {sc.cardNameValue} {card.getColor}");
            return sc;
        }

        public class SingleCard
        {
            public int cardValue;
            public string? cardNameValue;
        }
        public static string GetName(int cardValue)
        {
            string cardName = "";   
            cardName = Enum.GetName(typeof(ValuesClass.Values), cardValue) + $" ({cardValue})";
            return cardName;
        }

        public static string GetCardName(int cardValue)
        {
            string cardName = "";
            if (cardValue > 10)
            {
                cardName = Enum.GetName(typeof(ValuesClass.Values), cardValue) + $" ({cardValue})";
            }
            else
            {
                cardName = cardValue.ToString();
            }
            return cardName;
        }
    }
}