using CardLib.Controller;
using CardLib.Model;

namespace CardLib;

public class Class1
{
    public void Main()
    {
        List<Card> cartas = new List<Card>();
        cartas.Add(new Card("Nome1", "disc", 2, new List<Object>(["a", "b"])));
        cartas.Add(new Card("Nome2", "disc", 3, new List<Object>(["a", "b"])));
        cartas.Add(new Card("Nome3", "disc", 4, new List<Object>(["a", "b"])));
        cartas.Add(new Card("Nome4", "disc", 5, new List<Object>(["a", "b"])));
        cartas.Add(new Card("Nome5", "disc", 6, new List<Object>(["a", "b"])));


        Deck deck = new Deck();
        deck.Cards = cartas;

        Hand hand= new Hand();
        hand.BuyLimit = 1;
        hand.CardLimit = 3;

        HandController controller = new HandController();
        hand.Cards = controller.ChosenHand(hand, deck);
    }

}
