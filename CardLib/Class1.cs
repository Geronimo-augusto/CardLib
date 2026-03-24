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

        Player player1= new Player(1,3,3);
        Player player2 = new Player(1, 3, 3);
        player1.Deck = deck;
        player2.Deck = deck;

        HandController controller = new HandController();
        player1.Hand = controller.ChosenHand(player1, player1.Deck);
        player2.Hand = controller.ChosenHand(player2, player2.Deck);
        List<Turn> tuns = new List<Turn>();
        player1.Jogar();     
        Turn turn1 = new Turn(player1);
        tuns.Add(turn1);

        player2.Jogar();
        Turn turn2 = new Turn(player2);
        tuns.Add(turn2);




        Partida partida1 = new Partida(tuns, player1,player2);


    }

}
