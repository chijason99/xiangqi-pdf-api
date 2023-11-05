using XiangqiLibrary;

namespace XiangqiPdfCreationApi.Models;

public class GameObject
{
	public DateOnly DatePlayed { get; init; }
	public IList<MoveObject> Moves { get; set;}
	public string StartingFen { get; set;}
	public int NumberOfRounds => (int)Math.Ceiling((double)Moves.Count / 2);
	public string NameOfRedPlayer { get; set; } = "Unknown";
	public string NameOfBlackPlayer { get; set; } = "Unknown";
	public string NameOfGame { get; set; } = "Unknown";
	public GameResult GameResult { get; set; } = GameResult.Unknown;
}
