using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        [When(@"Player starts a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        { 
            _game = new Cricket();
        }
        [Then(@"the player score should be (.*)")]
        public void ThenTheplayerScoreShouldBeZero(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }
        [When(@"Player scores (.*) runs")]
        [Given(@"Player has scored (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            _game.Score(runs);
              
        }

        [Then(@"the player score should increase by (.*)")]
        public void ThenPlayerScoresIncreaseBy4(int runs)
        {
            _game.PlayerScore.Should().Be(runs);
        }


    }
}
