using System;
using System.Collections.Generic;

namespace Gambling;

// A round of Blackjack
public class Blackjack
{
    private List<Card> DealerHand { get; }
    private List<Card> PlayerHand { get; }
    
    private int PlayerBet { get; set; }
    private int PlayerChips { get; set; }

    public Blackjack()
    {
        throw new NotImplementedException();
    }
}