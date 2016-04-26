
## Black Jack

### Features

 * You have to get to 21 to win
 * If you go over 21 you bust
 * Hitting gives you a card
 * Staying means you are good with your total
 * To start you get 2 cards
 * Aces are 1 or 11
 * Dealer gets 1 card
 * Dealer must draw on 16 and stand on all 17s
 * Betting (TODO needs more features)

### Classes

#### Card
 * Has a Rank and Suit
 * Has a Picture
 * Ace's have variable value

#### Player
 * Has a Hand
 * Has a balance
 * Controls via Actions

#### Dealer
 * Has a Hand
 * Draws on 16
 * Stands on all 17s
 * Draws 1 card first

#### Action
 * Hit for new card
 * Stand for stopping
 * Split for two hands
 * Double Down

#### Hand
 * Has variable number of cards
 * Hands start with 2 cards
 * Hands bust when over 21

#### Deck
 * Gets new cards
 * Has 52 cards

#### Game
 * Orchastates stuff

#### Pot
 * Contains current bets

#### Bet
 * Current amount of money bet


### MVP

#### Cards
 * number between 1-10
 
#### Player
 * Has a hand
 * Controls
 
#### Dealer
 * Has to have a Hand
 * Draw on 16
 * Stays on 17

#### Hand
 * All good
 
#### Deck
 * Get a new Card
 
## TODO List
 1. -Card with value-
 3. -Deck gives cards-
 2. -Hand gets cards- 
