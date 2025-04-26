namespace CustomerApi.Responses;

public class ErrorResponse
{
    public string Error { get; set; }
    public string Timestamp { get; set; }
    public string Path { get; set; }

    public ErrorResponse(string error, string path)
    {
        Error = error;
        Timestamp = DateTime.UtcNow.ToString("o");
        Path = path;
    }
}
