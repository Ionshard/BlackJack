# BlackJack

Simple project for practicing C# by making BlackJack!

## TODO List
 1. ~~Card with value~~
 1. ~~Deck gives cards~~
 1. ~~Hand gets cards~~ 
 1. ~~Hand has a total~~
 1. ~~Player has a hand~~
 1. ~~Player can get new cards~~
 1. ~~Player can hit or stay~~
 1. ~~Player can bust~~
 1. ~~Implement simple player run dealer~~
 1. ~~Override dealer's Deal functionality to automate~~
 1. ~~Dealer must draw on all 16s and stay on all 17s~~
 1. ~~Refactor bad nested if logic in Game's Play function~~
 1. Give dealer first card before player plays
 1. Update deck to handle have 52 cards.
 1. Add Ace card 11/1 handling. (Harder)
 1. Add betting (Long and kinda hard)


## Planning

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
 
