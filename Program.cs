using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
  class Program
  {
    static void Main(string[] args)
    {
      //Creates new lists of the suits, ranks, and the deck list to combine the two to be added later through looping.
      var suits = new List<string>() {"Clubs", "Diamonds", "Hearts", "Spades"};
      var ranks = new List<string>() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
      var deck = new List<string>(); 

      //Creates a nested loop to assign all the ranks in each suit, and adds them to the deck list.
      foreach (var suit in suits) 
      {
        foreach (var rank in ranks) 
        {
          var card = $"{rank} of {suit}";
          deck.Add(card);
        }
      }
      
      var numberOfCards = deck.Count; 

      //Establishes loop that will shuffle deck
      for(var rightIndex = numberOfCards - 1; rightIndex >=1; rightIndex--) 
      {
        //Establishes the 2nd card to be randomly shuffled from the last card in deck
        var randomNumberGenerator = new Random();
        var leftIndex = randomNumberGenerator.Next(rightIndex);
        //Matches the number index from loop and re-assigns the value with the corresponding value from the "deck" list
        var leftCard = deck[leftIndex];
        var rightCard = deck[rightIndex];
        //Switches the left card with the right card to be shuffled until the loop reaches the last card
        deck[rightIndex] = leftCard;
        deck[leftIndex] = rightCard;
      }

      var firstCard = deck[0];
      var secondCard = deck[1];

      Console.WriteLine(firstCard);
      Console.WriteLine(secondCard);
    }
  }
}
