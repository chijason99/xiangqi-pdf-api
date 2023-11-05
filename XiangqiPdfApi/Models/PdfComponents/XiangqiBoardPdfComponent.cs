using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace XiangqiPdfCreationApi.Model.PdfComponents;

public class XiangqiBoardPdfComponent : IDynamicComponent<int>
{
	public int State { get; set; }
    private string _fenOfPosition { get; init; }
    public XiangqiBoardPdfComponent(string fenOfPosition)
    {
        _fenOfPosition = fenOfPosition;
    }
    public DynamicComponentComposeResult Compose(DynamicContext context)
	{
		//var url = "https://picsum.photos/270/300";

		//using var client = new WebClient();
		//var response = client.DownloadData(url);
		var content = context.CreateElement(container =>
		{
			container.Text(_fenOfPosition);
		});

		return new DynamicComponentComposeResult
		{
			Content = content,
			HasMoreContent = false
		};
	}
}
