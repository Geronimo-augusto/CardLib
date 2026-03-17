using CardLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib.Controller;

internal class HandController
{
    public List<Card> ChosenHand(Hand hand, Deck deck)
    {
        Random random = new Random();
        while(hand.Cards.Count < hand.CardLimit)
        {
            int escolha = random.Next(0,deck.Cards.Count+1);
            List<Card> possibilidade = deck.Cards;

            hand.Cards.Add(possibilidade[escolha]);

        }



        hand.Cards = deck.Cards;
        return hand.Cards;
    }
}
