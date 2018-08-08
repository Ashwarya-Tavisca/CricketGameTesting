Feature: MultiPlayer
	In order to enjoy a game of cricket bewteen two players
	As the audience
	I want to know the winner of the match

Scenario: Player 1 and player 2 score is zero when game starts
	When Player one has started a game of cricket
	When Player two has started a game of cricket
	Then the player one and player two score should be 0

Scenario: Player 1 should be able to score runs
    Given Player one has started a game of cricket 
	When Player one scores 4 runs
	Then the player one score should be 4

Scenario: Player 2 should be able to score runs
    Given Player two has started a game of cricket 
	When Player two scores 2 runs
	Then the player two score should be 2

Scenario: Player 1 has scored some runs and gets out.
    Given Player one has started a game of cricket 
	Given Player one has scored 4 runs
	And Player one gets out
	When Player one scores 3 runs
	Then the player one score should be 4

Scenario: Player 2 has scored some runs and gets out.
    Given Player two has started a game of cricket 
	Given Player two has scored 2 runs
    And Player two gets out
	When Player two scores 3 runs
	Then the player two score should be 2
	
Scenario:both players gets out and result is to be declared that player one is the winner.
	Given Player one has started a game of cricket 
	Given Player one has scored 4 runs
	Given Player one has scored 3 runs
	And Player one gets out
    Given Player two has started a game of cricket 
	Given Player two has scored 2 runs
    And Player two gets out
	When Both gets out
	Then The result is player one is the winner.

Scenario:both players gets out and result is to be declared that player two is the winner.
	Given Player two has started a game of cricket 
	Given Player two has scored 2 runs
	Given Player two has scored 2 runs
	And Player two gets out
    Given Player one has started a game of cricket 
	Given Player one has scored 2 runs
    And Player one gets out
	When Both gets out
	Then The result is player two is the winner.

 Scenario:both players gets out and result is to be declared that match is a tie.
	Given Player two has started a game of cricket 
	Given Player two has scored 2 runs
	And Player two gets out
    Given Player one has started a game of cricket 
	Given Player one has scored 2 runs
    And Player one gets out
	When Both gets out
	Then The result is match is a tie.










