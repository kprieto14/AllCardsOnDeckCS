# AllCardsOnDeckCS

Another attempt at the pedac process to include adventure mode.

P

Instead of showing just the top two cards, the program will now store these cards in TWO different lists (one for each hand), which might hopefully be made into a game of war. Need to make sure that the program does not re-shuffle the cards and is constantly using the same deck for the entire "game". 

E

Will need variables for playerHandOne and playerHandTwo to keep track of the cards, each list should contain 26 cards.

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

NEW ADVENTURE ALGO

Create a new empty list for playerHandOne and another one for playerHandTwo

Create a loop that takes the first 26 cards from the deck and add them to the PlayerOneHand, then take the last 26 cards from the deck and add them to the PlayerTwoHand (perhaps using an if statement? as in if the count is less than 26, then add the card to first hand, ELSE add the rest of the cards into second hand).

Print out cards in the list for PlayerOne and PlayerTwo with the count number to ensure this worked as well as the deck to ensure the deck is empty.

C