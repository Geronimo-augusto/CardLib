namespace CardLib.Model;

internal struct Partida
{
    public Player[] PlayesHand { get; }
    public List<Card> CardHistory { get; set; }
    public int Pontuacao { get; }
    public List<Turn> Turns { get; set; }

    public Partida(List<Turn> turns ,params Player[] playersHand)
    {
        PlayesHand = playersHand;
        Turns = turns;
    }

}
