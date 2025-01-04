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

    private static Random rng = new();

    // i love linq (this generates a full deck of cards)
    private static List<Card> _deck = (from num
            in Enumerable.Range(0, 52)
        select new Card((num % 13) + 1, (Suit)(num % 4))).ToList();
    
    public static List<Card> Deck => _deck;
    private static List<Card> _drawnCards = [];

    public static void ResetDeck()
    {
        _deck = (from num
                in Enumerable.Range(0, 52)
            select new Card((num % 13) + 1, (Suit)(num % 4))).ToList();
    }
    
    public static void ShuffleDeck()
    {
        _deck = _deck.OrderBy(_ => rng.Next()).ToList();
    }
    
    public Card(int number, Suit suit)
    {
        this.Number = number;
        this.Suit = suit;
    }

    public static Card GetCardFromDeck()
    {
        var card = _deck[rng.Next(_deck.Count)];
        _deck.Remove(card);
        _drawnCards.Add(card);
        return card;
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