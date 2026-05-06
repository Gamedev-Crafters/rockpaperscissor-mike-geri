using NUnit.Framework.Constraints;

namespace Tests;

public class RockPaperScissors
{
	public static string Play(string player1, string player2)
	{
		if (player1 == player2)
			return "Tie";

		if (player1 == "Scissors") {
			if (player2 == "Paper")
				return "Player1";
			return "Player2";
		}

		if (player1 == "Rock") {
			if (player2 == "Paper")
				return "Player2";
			return "Player1";
		}

		if (player1 == "Paper") {
			if (player2 == "Scissors")
				return "Player2";
			return "Player1";
		}

		return string.Empty;
	}
}

public class Tests {

	[Test]
	public void RockBeatsScissors() {
		Assert.That(RockPaperScissors.Play("Rock", "Scissors"), Is.EqualTo("Player1"));
		Assert.That(RockPaperScissors.Play("Scissors", "Rock"), Is.EqualTo("Player2"));
	}

	[Test]
	public void PaperBeatsRock()
	{
		Assert.That(RockPaperScissors.Play("Paper", "Rock"), Is.EqualTo("Player1"));
		Assert.That(RockPaperScissors.Play("Rock", "Paper"), Is.EqualTo("Player2"));
	}

	[Test]
	public void ScissorsBeatsPaper() {
		Assert.That(RockPaperScissors.Play("Scissors", "Paper"), Is.EqualTo("Player1"));
		Assert.That(RockPaperScissors.Play("Paper", "Scissors"), Is.EqualTo("Player2"));
	}

	[Test]
	public void SameMoveTie()
	{
		Assert.That(RockPaperScissors.Play("Paper", "Paper"), Is.EqualTo("Tie"));
	}
}