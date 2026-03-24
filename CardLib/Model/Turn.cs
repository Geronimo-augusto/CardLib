using System;
using System.Collections.Generic;
using System.Text;

namespace CardLib.Model;

internal class Turn
{
    public Player Player { get; set; }
    public List<Card> CardsUsed { get; set; }


    public int DamegeGive { get; set; }
    public int DamegeTake { get; set; }
    public int ActionUse { get; set; }
    public List<Card> CardsGained { get; set; }

    public Turn(Player player)
    {
        CardsUsed = player.cardsUsed;
        Player = player;
    }
}
