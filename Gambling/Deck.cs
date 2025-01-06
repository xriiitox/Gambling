using System;
using System.Collections.Generic;
using System.Linq;

namespace Gambling;

public class Deck
{
    private static Random _rng = new();
    
    private List<Card> _deck;
    
    private static List<Card> _drawnCards = [];

    public Deck()
    {
        // i love linq (this generates a full deck of cards)
        _deck = (from num
                in Enumerable.Range(0, 52)
            select new Card((num % 13) + 1, (Suit)(num % 4))).ToList();
    }

    public void Reset()
    {
        _deck = (from num
                in Enumerable.Range(0, 52)
            select new Card((num % 13) + 1, (Suit)(num % 4))).ToList();
        _drawnCards = [];
    }
    
    public void Shuffle()
    {
        _deck = _deck.OrderBy(_ => _rng.Next()).ToList();
    }
    
    public Card Draw()
    {
        var card = _deck[_rng.Next(_deck.Count)];
        _deck.Remove(card);
        _drawnCards.Add(card);
        return card;
    } 
}