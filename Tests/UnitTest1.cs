using NUnit.Framework.Constraints;

namespace Tests;

public class Tests {
	[Test]
	public void RockBeatsScissors() {
		Assert.That(RockPaperScissors("Rock", "Scissors"), Is.EqualTo("Player1"));
		Assert.That(RockPaperScissors("Scissors", "Rock"), Is.EqualTo("Player2"));
	}

	[Test]
	public void PaperBeatsRock()
	{
		Assert.That(RockPaperScissors("Paper", "Rock"), Is.EqualTo("Player1"));
		Assert.That(RockPaperScissors("Rock", "Paper"), Is.EqualTo("Player2"));
	}

	private string RockPaperScissors(string player1, string player2) {
		if (player2 == "Paper")
			return "Player2";
		if (player1 == "Rock")
			return "Player1";
		if (player1 == "Paper")
			return "Player1";
		return "Player2";
	}
}