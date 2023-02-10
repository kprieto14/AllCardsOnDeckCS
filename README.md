# AllCardsOnDeckCS

My attempt at trying the PEDAC myself and see how much I could come up with on my own, unfortunately it seems I was still missing much information to help me out and I needed the video for much of the help :(

P

The deck should contain 52 cards, with 2 different lists of 4 suits and 13 ranks. They should be shuffled with the last card in the deck (rightIndex) being shuffled with a random card in the deck. 

E

Will need variables for Suits, Ranks, Indexes

D

Will need strings, loops, index, random.Next() function

A

Create a list for the 4 suits, create a list of the 13 ranks. Combine the two in a list statement of deck, create a loop then ADDS (deck.Add("string");) each rank with each suit. Then to implement the shuffling of cards, will need the count of cards (numberOfCards = some variable.Count) then do rightIndex = count - 1 to grab the last card in the "deck"/ list. leftindex will be 0 to grab the first card in the list. Here is the example the teacher gives:

numberOfCards = length of our deck

for rightIndex from numberOfCards - 1 down to 1 do:
  leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")

  Now swap the values at rightIndex and leftIndex by doing this:
    leftCard = the value from deck[leftIndex]
    rightCard = the value from deck[rightIndex]
    deck[rightIndex] = leftCard
    deck[leftIndex] = rightCard

Will need the following to work with the shuffling:
var randomNumberGenerator = new Random();
var randomNumber = randomNumberGenerator.Next(52); with the 52 representing the 52 cards in the deck. Come back to Adventure mode later.

C