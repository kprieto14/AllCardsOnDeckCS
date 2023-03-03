using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{

  //Creates a class that will house 52 cards
  class Card 
    {
      public string Face {get; set;}
      public string Suit {get; set;}
      public int Value {get; set;}
    }
  class Program
  {
        static void Main(string[] args)
    {

      Console.WriteLine("Welcome to the game of War! I will be your dealer. Lets shuffle the cards and begin!");
      Console.WriteLine();
    
      //Creates the deck that assigns a Suit, face, value to each 52 cards. 
      var deck = new List<Card>()
      {
        new Card()
          {
            Face = "Clubs",
            Suit = "Ace",
            Value = 14
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "2",
            Value = 2
          }, 

        new Card()
         {
           Face = "Clubs",
            Suit = "3",
            Value = 3
          },

        new Card()
         {
           Face = "Clubs",
           Suit = "4",
           Value = 4
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "5",
            Value = 5
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "6",
            Value = 6
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "7",
            Value = 7
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "8",
            Value = 8
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "9",
            Value = 9
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "10",
            Value = 10
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "Jack",
            Value = 11
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "Queen",
            Value = 12
          },

        new Card()
          {
            Face = "Clubs",
            Suit = "King",
            Value = 13
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "Ace",
            Value = 14
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "2",
            Value = 2
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "3",
            Value = 3
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "4",
            Value = 4
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "5",
            Value = 5
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "6",
            Value = 6
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "7",
            Value = 7
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "8",
            Value = 8
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "9",
            Value = 9
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "10",
            Value = 10
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "Jack",
            Value = 11
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "Queen",
            Value = 12
          },

        new Card()
          {
            Face = "Diamonds",
            Suit = "King",
            Value = 13
          },

        new Card()
          {
            Face = "Hearts",
            Suit = "Ace",
            Value = 14
          },

        new Card()
          {
            Face = "Hearts",
            Suit = "2",
            Value = 2
          },

        new Card()
          {
            Face = "Hearts",
            Suit = "3",
            Value = 3
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "4",
            Value = 4
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "5",
            Value = 5
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "6",
            Value = 6
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "7",
            Value = 7
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "8",
            Value = 8
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "9",
            Value = 9
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "10",
            Value = 10
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "Jack",
            Value = 11
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "Queen",
            Value = 12
          },  

        new Card()
          {
            Face = "Hearts",
            Suit = "King",
            Value =13
          },
        
        new Card()
          {
            Face = "Spades",
            Suit = "Ace",
            Value = 14
          },

        new Card()
          {
            Face = "Spades",
            Suit = "2",
            Value = 2
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "3",
            Value = 3
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "4",
            Value = 4
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "5",
            Value = 5
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "6",
            Value = 6
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "7",
            Value = 7
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "8",
            Value = 8
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "9",
            Value = 9
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "10",
            Value = 10
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "Jack",
            Value = 11
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "Queen",
            Value = 12
          }, 

        new Card()
          {
            Face = "Spades",
            Suit = "King",
            Value = 13
          }, 
         
                            
      };

      var numberOfCards = deck.Count;
      Console.WriteLine($"There are {numberOfCards} total cards.");

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

      //To check that the deck has been successfully shuffled by showing the top 2 cards!
      var firstCard = deck[0];
      var secondCard = deck[1];
   
      Console.WriteLine($"The first card is a {firstCard.Suit} of {firstCard.Face}");
      Console.WriteLine($"The second card is a {secondCard.Suit} of {secondCard.Face}");
      Console.WriteLine();

      //Creates new lists to add cards into deck for PlayerOne and PlayerTwo
      var playerHand = new List<Card> ();
      var playerHandTwo = new List<Card> ();  

      //Creates a loop, that gives the first 26 shuffle cards to the first player, then gives the last 26 cards to the 2nd player and adds the cards to the corresponding lists
      for(var gameDeck = 0; gameDeck <= numberOfCards -1; gameDeck++)
      {
        if (gameDeck <= 25) {
          var playerOneCard = deck[gameDeck];
          playerHand.Add(playerOneCard);
        }
        else {
          var playerTwoCard = deck[gameDeck];
          playerHandTwo.Add(playerTwoCard);
        }
      }  

      //Clears the original deck, because in a real-world aspect, this would be empty and not exist anymore when cards are handed out.
      deck.Clear();

     bool gameOn = true;
     while(gameOn == true)
     {
      var playerCard = playerHand[0];
      var secondPlayerCard = playerHandTwo[0];

      Console.WriteLine($"Player One reveals a {playerCard.Suit} of {playerCard.Face} while Player Two reveals a {secondPlayerCard.Suit} of {secondPlayerCard.Face}.");

      //Checks both cards values and assigns a win to either and adjusts accordingly
      //First If statement that runs if Player 1 is greater than Player 2
      if (playerCard.Value > secondPlayerCard.Value)
      {
        //Algo that starts if the temp list has cards from starting the war!
        if (deck.Count != 0)
        {
          Console.Write("⚔️ Player 1 has won the war! They have added the");
          for (var count = 0; count < deck.Count; count ++)
          {
            var currentCard = deck[count];

            Console.Write($" {currentCard.Suit} of {currentCard.Face},");
            playerHand.Add(deck[count]);
          }
          Console.WriteLine($" {secondPlayerCard.Suit} of {secondPlayerCard.Face}, and {playerCard.Suit} of {playerCard.Face} to their hand! Congratulations!");
          //Clears original deck to continue regular war
          deck.Clear();
        }
        else
        {
          Console.WriteLine($"Player One has won this round! They have added the {secondPlayerCard.Suit} of {secondPlayerCard.Face} to their hand.");
        }
        //Adds both cards won to the back of the list for playerHand
        playerHand.Add(secondPlayerCard);
        playerHand.Add(playerCard);
      }
      //Second if statement that runs if Player 2 is greater than Player 1
      else if (playerCard.Value < secondPlayerCard.Value)
      {
        //Algo that starts if the temp list has cards from starting the war!
        if (deck.Count != 0)
        {
          Console.Write("⚔️ Player 2 has won the war! They have added the");
          for (var count = 0; count < deck.Count; count ++)
          {
            var currentCard = deck[count];
            
            Console.Write($" {currentCard.Suit} of {currentCard.Face},");
            playerHandTwo.Add(deck[count]);
          }
          Console.WriteLine($" {playerCard.Suit} of {playerCard.Face}, and {secondPlayerCard.Suit} of {secondPlayerCard.Face} to their hand! Congratulations!");
          //Clears original deck to continue regular war
          deck.Clear();
        }
        else
        {
          Console.WriteLine($"Player Two has won this round! They have added the {playerCard.Suit} of {playerCard.Face} to their hand.");
        }
        //Adds both cards won to the back of the list for playerHandTwo 
        playerHandTwo.Add(playerCard);
        playerHandTwo.Add(secondPlayerCard);
      }
      //Statement that triggers that War has begun
      else if (playerCard.Value == secondPlayerCard.Value)
      {
        Console.WriteLine("Uh oh, looks like it's time to start a War!");

        //Adds them into a temporary list that will be checked in the next loop.
        deck.Add(secondPlayerCard);
        deck.Add(playerCard);
      }
      else
      {
        Console.WriteLine("Something has gone wrong. Please check the code.");
        gameOn = false;
      }

      //Removes the cards that have been used during the round
      playerHand.RemoveAt(0);
      playerHandTwo.RemoveAt(0);
      Console.WriteLine($"Player One has {playerHand.Count} cards and Player Two has {playerHandTwo.Count} cards.");
      Console.WriteLine();

      //Constantly checks if either hand ever reaches 0 to officially end the game.
      if (playerHand.Count == 0)
      {
        Console.WriteLine("Game over! Player 2 has won!");
        gameOn = false;
      }
      else if (playerHandTwo.Count == 0)
      {
        Console.WriteLine("Game over! Player 1 has won!");
        gameOn = false;
      }
     }
    }
  }
}
