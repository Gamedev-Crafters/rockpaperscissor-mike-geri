using NUnit.Framework.Constraints;

namespace Tests;

public class RockPaperScissors
{
	public static string Play(string player1, string player2)
	{
		if (player1 == player2)
			return Tie();

		if (player1 == Scissors() && player2 == Paper())
			return Player1();
		if (player1 == Scissors())
			return Player2();

		if (player1 == Rock() && player2 == Paper())
			return Player2();
		if (player1 == Rock())
			return Player1();

		if (player1 == Paper() && player2 == Scissors())
			return Player2();
		return Player1();
	}
	
	public static string Rock() => "Rock";
	public static string Paper() => "Paper";
	public static string Scissors() => "Scissors";
	
	public static string Player1() => "Player1";
	public static string Player2() => "Player2";
	
	public static string Tie() => "Tie";
}

public class Tests {

	[Test]
	public void RockBeatsScissors() {
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Rock(), RockPaperScissors.Scissors()), Is.EqualTo(RockPaperScissors.Player1()));
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Scissors(), RockPaperScissors.Rock()), Is.EqualTo(RockPaperScissors.Player2()));
	}

	[Test]
	public void PaperBeatsRock()
	{
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Paper(), RockPaperScissors.Rock()), Is.EqualTo(RockPaperScissors.Player1()));
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Rock(), RockPaperScissors.Paper()), Is.EqualTo(RockPaperScissors.Player2()));
	}

	[Test]
	public void ScissorsBeatsPaper() {
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Scissors(), RockPaperScissors.Paper()), Is.EqualTo(RockPaperScissors.Player1()));
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Paper(), RockPaperScissors.Scissors()), Is.EqualTo(RockPaperScissors.Player2()));
	}

	[Test]
	public void SameMoveTie()
	{
		Assert.That(RockPaperScissors.Play(RockPaperScissors.Paper(), RockPaperScissors.Paper()), Is.EqualTo(RockPaperScissors.Tie()));
	}
}