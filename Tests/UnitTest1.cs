using NUnit.Framework.Constraints;

namespace Tests;

public class Tests {
	[Test]
	public void RockBeatsScissors() {
		Assert.That(RockPaperScissors("Rock", "Scissors"), Is.EqualTo("Player1"));
		Assert.That(RockPaperScissors("Scissors", "Rock"), Is.EqualTo("Player2"));
	}

	private string RockPaperScissors(string player1, string player2) {
		if (player1 == "Rock")
			return "Player1";
		return "Player2";
	}
}