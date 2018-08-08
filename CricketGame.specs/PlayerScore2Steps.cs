using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class MultiPlayerSteps
    {
        private Cricket _player1;
        private Cricket _player2;

        [Given(@"Player one has started a game of cricket")]
        [When(@"Player one has started a game of cricket")]
        public void WhenPlayerOneHasStartedAGameOfCricket()
        {
            _player1 = new Cricket();
        }

        [Given(@"Player two has started a game of cricket")]
        [When(@"Player two has started a game of cricket")]
        public void WhenPlayerTwoHasStartedAGameOfCricket()
        {
            _player2 = new Cricket();
        }

        [Then(@"the player one and player two score should be (.*)")]
        public void ThenThePlayerOneAndPlayerTwoScoreShouldBe(int score)
        {
            _player1.Score(score);
            _player2.Score(score);

        }

        [Given(@"Player one has scored (.*) runs")]
        [When(@"Player one scores (.*) runs")]
        public void WhenPlayerOneScoresRuns(int score1)
        {
            _player1.Score(score1);
        }
        [Then(@"the player one score should be (.*)")]
        public void ThenThePlayerOneScoreShouldBe(int score1)
        {
            _player1.PlayerScore.Should().Be(score1);
        }

        [Given(@"Player two has scored (.*) runs")]
        [When(@"Player two scores (.*) runs")]
        public void WhenPlayerTwoScoresRuns(int score2)
        {
            _player2.Score(score2);
        }
        [Then(@"the player two score should be (.*)")]
        public void ThenThePlayerTwoScoreShouldBe(int score2)
        {
            _player2.PlayerScore.Should().Be(score2);
        }

        [Given(@"Player one gets out")]
        public void GivenPlayerOneGetsOut()
        {
            _player1.GetOut();
        }

        [Given(@"Player two gets out")]
        public void GivenPlayerTwoGetsOut()
        {
            _player2.GetOut();
        }

        [When(@"Both gets out")]
        public void WhenBothGetsOut()
        {
            _player1.GetOut();
            _player2.GetOut();
        }


        [Then(@"The result is player one is the winner.")]
        public void ThenTheResultIsPlayerOneIsTheWinner_()
        {
            _player1.PlayerScore.Should().BeGreaterThan(_player2.PlayerScore);
        }

        [Then(@"The result is player two is the winner.")]
        public void ThenTheResultIsPlayerTwoIsTheWinner_()
        {
            _player2.PlayerScore.Should().BeGreaterThan(_player1.PlayerScore);
        }

        [Then(@"The result is match is a tie.")]
        public void ThenTheResultIsMatchIsATie_()
        {
            _player2.PlayerScore.Should().Be(_player1.PlayerScore);
        }


    }
}
