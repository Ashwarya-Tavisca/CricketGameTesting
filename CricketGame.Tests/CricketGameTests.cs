using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Tests
{
    [TestClass]
    public class CricketGameTests
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 4);
        }

        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }

        [TestMethod]
        public void Score_MultipleTimes_ShouldUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(4);
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 8);
        }
        [TestMethod]
        public void Score_GetsOut_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(2);
            game.GetOut();
            game.Score(3);
            Assert.IsTrue(game.PlayerScore == 2);
        }
        [TestMethod]
        public void Score_BothGetsOut_ResultIsTie()
        {
            var player1 = new Cricket();
            player1.Score(2);
            player1.GetOut();
            var player2 = new Cricket();
            player2.Score(2);
            player2.GetOut();
            Assert.IsTrue(player1.PlayerScore == player2.PlayerScore);
        }
        [TestMethod]
        public void Score_BothGetsOut_PlayerOneIsTheWinner()
        {
            var player1 = new Cricket();
            player1.Score(1);
            player1.Score(3);
            player1.GetOut();
            var player2 = new Cricket();
            player2.Score(2);
            player2.GetOut();
            Assert.IsTrue(player1.PlayerScore >= player2.PlayerScore);
        }

        [TestMethod]
        public void Score_BothGetsOut_PlayerTwoIsTheWinner()
        {
            var player2 = new Cricket();
            player2.Score(4);
            player2.Score(1);
            player2.GetOut();
            var player1 = new Cricket();
            player1.Score(4);
            player1.GetOut();
            Assert.IsTrue(player2.PlayerScore >= player1.PlayerScore);
        }
    }
}
