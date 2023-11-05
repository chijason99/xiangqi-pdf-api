using XiangqiLibrary;
using XiangqiPdfCreationApi.Models;

namespace XiangqiPdfCreationApi.Model;

public static class GameObjectTemplate
{
    public static GameObject GenerateGameObjectTemplate()
    {
        var listOfMoves = new List<MoveObject>()
        {
            GenerateMoveObject("rnbakabnr/9/1c5c1/p1p1p1p1p/9/9/P1P1P1P1P/1C2C4/9/RNBAKABNR b - - 1 1", Side.Red, Piece.Cannon,"炮二平五", 1 ),
            GenerateMoveObject("rnbakabnr/9/4c2c1/p1p1p1p1p/9/9/P1P1P1P1P/1C2C4/9/RNBAKABNR w - - 2 1", Side.Black, Piece.Cannon,"炮2平5", 1 ),
            GenerateMoveObject("rnbakabnr/9/4c2c1/p1p1p1p1p/9/9/P1P1P1P1P/1C2C1N2/9/RNBAKAB1R b - - 3 2", Side.Red, Piece.Cannon,"馬二進三", 2 ),
            GenerateMoveObject("r1bakabnr/9/2n1c2c1/p1p1p1p1p/9/9/P1P1P1P1P/1C2C1N2/9/RNBAKAB1R w - - 4 2", Side.Black, Piece.Cannon,"馬2進3", 2 ),
            GenerateMoveObject("r1bakabnr/9/2n1c2c1/p1p1p1p1p/9/9/P1P1P1P1P/1CN1C1N2/9/R1BAKAB1R b - - 5 3", Side.Red, Piece.Cannon,"馬八進七", 3 ),
            GenerateMoveObject("1rbakabnr/9/2n1c2c1/p1p1p1p1p/9/9/P1P1P1P1P/1CN1C1N2/9/R1BAKAB1R w - - 6 3", Side.Black, Piece.Cannon,"車1平2", 3 ),
            GenerateMoveObject("1rbakabnr/9/2n1c2c1/p1p1p1p1p/9/9/P1P1P1P1P/1CN1C1N2/9/1RBAKAB1R b - - 7 4", Side.Black, Piece.Cannon,"車九平八", 4 ),
            GenerateMoveObject("2bakabnr/9/2n1c2c1/p1p1p1p1p/9/9/PrP1P1P1P/1CN1C1N2/9/1RBAKAB1R w - - 8 4", Side.Black, Piece.Cannon,"車2進6", 4 ),
            GenerateMoveObject("2bakabnr/9/2n1c2c1/p1p1p1p1p/9/9/PrP1P1P1P/1CN1C1N2/9/1RBAKABR1 b - - 9 5", Side.Black, Piece.Cannon,"車一平二", 5 ),
            GenerateMoveObject("2bakabnr/9/2n1cc3/p1p1p1p1p/9/9/PrP1P1P1P/1CN1C1N2/9/1RBAKABR1 w - - 10 5", Side.Black, Piece.Cannon,"炮8平6", 5 ),
            GenerateMoveObject("2bakabnr/7R1/2n1cc3/p1p1p1p1p/9/9/PrP1P1P1P/1CN1C1N2/9/1RBAKAB2 b - - 11 6", Side.Black, Piece.Cannon,"車二進八", 6 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n1cc3/p1p1p1p1p/9/9/PrP1P1P1P/1CN1C1N2/9/1RBAKAB2 w - - 12 6", Side.Black, Piece.Cannon,"士4進5", 6 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n1cc3/p1p1p1p1p/9/9/PrP1P1P1P/C1N1C1N2/9/1RBAKAB2 b - - 13 7", Side.Black, Piece.Cannon,"炮八平九", 7 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n1cc3/p1p1p1p1p/9/9/P1r1P1P1P/C1N1C1N2/9/1RBAKAB2 w - - 0 7", Side.Black, Piece.Cannon,"車2平3", 7 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n1cc3/p1p1p1p1p/9/9/P1r1P1P1P/CRN1C1N2/9/2BAKAB2 b - - 1 8", Side.Black, Piece.Cannon,"車八進二", 8 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n1c4/p1p1p1p1p/9/9/P1r1P1P1P/CRN1CcN2/9/2BAKAB2 w - - 2 8", Side.Black, Piece.Cannon,"炮6進5", 8 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n1c4/p1p1p1p1p/9/9/P1r1P1P1P/CRN1CcN2/4A4/2BAK1B2 b - - 3 9", Side.Black, Piece.Cannon,"士四進五", 9 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1r1c1P1P/CRN1CcN2/4A4/2BAK1B2 w - - 0 9", Side.Black, Piece.Cannon,"炮5進4", 9 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1r1c1P1P/CRN1CcN2/4A4/2BA1KB2 b - - 1 10", Side.Black, Piece.Cannon,"帥五平四", 10 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1r2cP1P/CRN1CcN2/4A4/2BA1KB2 w - - 2 10", Side.Black, Piece.Cannon,"炮5平6", 10 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1r2cP1P/CRN1CcN2/4A4/2BAK1B2 b - - 3 11", Side.Black, Piece.Cannon,"帥四平五", 11 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1r2cP1P/CRc1C1N2/4A4/2BAK1B2 w - - 0 11", Side.Black, Piece.Cannon,"前炮平3", 11 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1r2cP1P/1RC1C1N2/4A4/2BAK1B2 b - - 0 12", Side.Black, Piece.Cannon,"炮九平七", 12 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/9/P1rc2P1P/1RC1C1N2/4A4/2BAK1B2 w - - 1 12", Side.Black, Piece.Cannon,"炮6平4", 12 ),
            GenerateMoveObject("2b1kabnr/4a2R1/2n6/p1p1p1p1p/9/6P2/P1rc4P/1RC1C1N2/4A4/2BAK1B2 b - - 2 13", Side.Black, Piece.Cannon,"兵三進一", 13 ),
            GenerateMoveObject("2b1kabnr/3ca2R1/2n6/p1p1p1p1p/9/6P2/P1r5P/1RC1C1N2/4A4/2BAK1B2 w - - 3 13", Side.Black, Piece.Cannon,"炮4退5", 13 ),
            GenerateMoveObject("2b1kabnr/3ca4/2n4R1/p1p1p1p1p/9/6P2/P1r5P/1RC1C1N2/4A4/2BAK1B2 b - - 4 14", Side.Black, Piece.Cannon,"車二退一", 14 ),
            GenerateMoveObject("2bnkabnr/3ca4/7R1/p1p1p1p1p/9/6P2/P1r5P/1RC1C1N2/4A4/2BAK1B2 w - - 5 14", Side.Black, Piece.Cannon,"馬3退4", 14 ),
            GenerateMoveObject("2bnkabnr/1R1ca4/7R1/p1p1p1p1p/9/6P2/P1r5P/2C1C1N2/4A4/2BAK1B2 b - - 6 15", Side.Black, Piece.Cannon,"車八進五", 15 ),
            GenerateMoveObject("2bnkab1r/1R1ca4/7Rn/p1p1p1p1p/9/6P2/P1r5P/2C1C1N2/4A4/2BAK1B2 w - - 7 15", Side.Black, Piece.Cannon,"馬8進9", 15 ),
            GenerateMoveObject("2bnkab1r/3Ra4/7Rn/p1p1p1p1p/9/6P2/P1r5P/2C1C1N2/4A4/2BAK1B2 b - - 0 16", Side.Black, Piece.Cannon,"車八平六", 16 ),
            GenerateMoveObject("2bnkab1r/3Ra4/7Rn/p1p1p1p1p/9/6P2/P7P/2r1C1N2/4A4/2BAK1B2 w - - 0 16", Side.Black, Piece.Cannon,"車3進1", 16 ),
            GenerateMoveObject("2bnkab1r/3Ra4/7Rn/p1p1p1p1p/9/6P2/P3N3P/2r1C4/4A4/2BAK1B2 b - - 1 17", Side.Black, Piece.Cannon,"馬三進五", 17 ),
            GenerateMoveObject("2bnkab1r/3Ra4/7Rn/p1p1p1p1p/2r6/6P2/P3N3P/4C4/4A4/2BAK1B2 w - - 2 17", Side.Black, Piece.Cannon,"車3退3", 17 ),
            GenerateMoveObject("2bnkab1r/3Ra4/7Rn/p1p1C1p1p/2r6/6P2/P3N3P/9/4A4/2BAK1B2 b - - 0 18", Side.Black, Piece.Cannon,"炮五進四", 18 ),
            GenerateMoveObject("2bnka2r/3Ra4/4b2Rn/p1p1C1p1p/2r6/6P2/P3N3P/9/4A4/2BAK1B2 w - - 1 18", Side.Black, Piece.Cannon,"象7進5", 18 ),
            GenerateMoveObject("2bnka2r/3Ra4/4R3n/p1p1C1p1p/2r6/6P2/P3N3P/9/4A4/2BAK1B2 b - - 0 19", Side.Black, Piece.Cannon,"車二平五", 19 ),

		};

        return new GameObject()
        {
            DatePlayed = new DateOnly(2023,9,12),
            Moves = listOfMoves,
            StartingFen = "rnbakabnr/9/1c5c1/p1p1p1p1p/9/9/P1P1P1P1P/1C5C1/9/RNBAKABNR w - - 0 0",
            NameOfRedPlayer = "Jason",
            NameOfBlackPlayer = "朱文光",
            NameOfGame = "2023 全英個人賽 先勝朱文光"
        };
    }
    private static MoveObject GenerateMoveObject(string Fen, Side sideMoved, Piece movedPiece, string moveNotation, int round)
    {
        return new MoveObject()
        {
            Fen = Fen,
            SideMoved = sideMoved,
            MoveNotation = moveNotation,
            MovedPiece = movedPiece,
            Round = round
        };
    }
}
