using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib.Model;

internal class Hand
{
    public List<Card> Cards { get; set; }
    public int BuyLimit { get; set;}
    public int CardLimit { get; set; }

}
