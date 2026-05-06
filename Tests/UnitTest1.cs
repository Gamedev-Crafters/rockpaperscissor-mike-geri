using NUnit.Framework.Constraints;

namespace Tests;

public class Tests {
	[Test]
	public void RockBeatsScissors() {
		Assert.That(RockPaperScissors("Rock", "Scissors"), Is.EqualTo("Player1"));
	}

	private string RockPaperScissors(string player1, string player2) {
		return "Player1";
	}
}