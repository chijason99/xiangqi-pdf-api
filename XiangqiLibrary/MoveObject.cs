using XiangqiLibrary;

namespace XiangqiPdfCreationApi.Models;

public class MoveObject
{
	public string Fen { get; set; }
	public Side SideMoved { get; set; }
	public Piece MovedPiece { get; set; }
	public string MoveNotation { get; set; }

	public string Comment = null;

	public int Round { get; set; }	
}
