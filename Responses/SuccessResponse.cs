namespace CustomerApi.Responses;

public class SuccessResponse<T>
{
    public string Message { get; set; } = "Success";
    public T Data { get; set; }

    public SuccessResponse(T data)
    {
        Data = data;
    }
}
