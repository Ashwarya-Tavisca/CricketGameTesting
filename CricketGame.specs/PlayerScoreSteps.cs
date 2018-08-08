using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;

        [Given(@"Player has started a game of cricket")]
        [When(@"Player starts a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            _game = new Cricket();
        }
        [Given(@"Player has scored (.*) runs")]

        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int runs)
        {
            _game.Score(runs);
        }
        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.GetOut();
        }

        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }


    }
}
