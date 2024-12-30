using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace BBS.Application.CustomActionResults;

public class CsvFileResult() : FileResult("text/csv")
{
    // protected override void WriteFile(HttpResponse response)
    // {
    //     if (!string.IsNullOrWhiteSpace(Body))
    //     {
    //         var data = Encoding.UTF8.GetBytes(Body);
    //         var result = Encoding.UTF8.GetPreamble().Concat(data).ToArray();
    //         response.OutputStream.Write(result, 0, result.GetLength(0));
    //     }
    // }

    public required string Body { get; set; }
}