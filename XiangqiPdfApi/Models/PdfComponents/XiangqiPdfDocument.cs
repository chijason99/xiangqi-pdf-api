using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Net;
using XiangqiPdfCreationApi.Models;

namespace XiangqiPdfCreationApi.Model.PdfComponents;

public class XiangqiPdfDocument : IDocument
{
    public GameObject GameObject { get; }

    private int _counter {  get; set; }
    private IList<MoveObject> _listOfMoves { get; set; }
    public XiangqiPdfDocument(GameObject gameObject)
    {
        GameObject = gameObject;
        _listOfMoves = gameObject.Moves;
        _counter = 0;
    }
    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public DocumentSettings GetSettings() => DocumentSettings.Default;

    public void Compose(IDocumentContainer container)
    {
        for (var i = 0; i < GameObject.Moves.Count; i += 2)
        {
            container
                .Page(page =>
                {
					page.DefaultTextStyle(x => x.FontFamily("MS Gothic"));
                    page.Margin(50);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.CurrentPageNumber();
                        x.Span(" / ");
                        x.TotalPages();
                    });
                });
        }
    }
    private void ComposeHeader(IContainer container)
    {
        var titleStyle = TextStyle.Default.FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

        container.Row(row =>
        {
            row.RelativeItem().Column(column =>
            {
                column.Item().AlignCenter().Text($"Game Name: {GameObject.NameOfGame}").Style(titleStyle);

                column.Item().Text(text =>
                {
                    text.Span("Red Player: ").SemiBold();
                    text.Span($"{GameObject.NameOfRedPlayer}");
                });

                column.Item().Text(text =>
                {
                    text.Span("Black Player: ").SemiBold();
                    text.Span($"{GameObject.NameOfBlackPlayer}");
                });


                column.Item().Text(text =>
                {
                    text.Span("Date Played: ").SemiBold();
                    text.Span($"{GameObject.DatePlayed}");
                });
            });
        });
    }

    private void ComposeContent(IContainer container)
    {
        container.PaddingTop(10).Column(column =>
        {
            column.Spacing(5);

            column.Item().Element(ComposeTableForPage);
        });
    }

	private void ComposeTableForPage(IContainer container)
	{
		container
			    .Table(table =>
			    {
				    table.ColumnsDefinition(column =>
				    {
					    column.ConstantColumn(270);
					    column.RelativeColumn();
				    });

                    var url = "https://picsum.photos/270/300";

                    using var client = new WebClient();
                    var response = client.DownloadData(url);

                    table.Cell().PaddingRight(10).PaddingBottom(10).Element(XiangqiBoard).PaddingVertical(10).PaddingHorizontal(20).Image(response);
					table.Cell().PaddingBottom(10).Element(CommentaryBox).Padding(20).Text(_listOfMoves[_counter].MoveNotation);
                    if (_counter + 1 < _listOfMoves.Count)
                    {
                        table.Cell().PaddingRight(10).Element(XiangqiBoard).PaddingVertical(10).PaddingHorizontal(20).Image(response);
                        table.Cell().PaddingBottom(10).Element(CommentaryBox).PaddingVertical(10).PaddingHorizontal(20).Text(_listOfMoves[_counter + 1].MoveNotation);
                    }
			    });

        _counter += 2;
	}
	private static IContainer CommentaryBox(IContainer container)
    {
        return container
                    .Height(300)
					.Background(Colors.Grey.Lighten3);
    }

    private static IContainer XiangqiBoard(IContainer container)
    {
        return container
                    .Height(300)
                    .Background(Colors.Grey.Lighten3);
    }
}
