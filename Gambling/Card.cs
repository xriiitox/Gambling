using System;
using System.Collections.Generic;
using System.Linq;

namespace Gambling;

public class Card
{
    // 1 == Ace
    // card numbers 2-10
    // J, Q, K = 11, 12, 13
    public int Number { get; }
    public Suit Suit { get; }
    
    public Card(int number, Suit suit)
    {
        this.Number = number;
        this.Suit = suit;
    }
    
    public new string ToString() => $"{Number} of {Enum.GetName(typeof(Suit), Suit)}";
}

public enum Suit
{
    CLUBS,
    SPADES,
    DIAMONDS,
    HEARTS
}