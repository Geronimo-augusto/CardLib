using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CardLib.Model;

internal class Player
{
    public List<Card> Hand { get; set; }

    public List<Card> CardsUsed { get; set; }
    public Deck Deck { get; set; }
    public int BuyLimit { get; set;}
    public int CardLimit { get; set; }
    public int Points { get; set; }
    public int Life { get; set; }

    public int Actions { get; set; }

    public Player(int buyLimit, int cardLimit, int life)
    {
        BuyLimit = buyLimit;
        CardLimit = cardLimit;
        Life = life;
    }

    public void Jogar()
    {
        Random random = new Random();
        while (CardsUsed.Count < Actions)
        {
            int escolha = random.Next(0, Hand.Count + 1);
            List<Card> possibilidade = Hand;

            CardsUsed.Add(possibilidade[escolha]);
        }
    }
}
