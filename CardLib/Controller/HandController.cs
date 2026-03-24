using CardLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib.Controller;

internal class HandController
{
    public List<Card> ChosenHand(Player player, Deck deck)
    {
        Random random = new Random();
        while(player.Hand.Count < player.CardLimit)
        {
            int escolha = random.Next(0,deck.Cards.Count+1);
            List<Card> possibilidade = deck.Cards;

            player.Hand.Add(possibilidade[escolha]);

        }


        return player.Hand;
    }

    public void Jogar(Player player)
    {

    }


}
