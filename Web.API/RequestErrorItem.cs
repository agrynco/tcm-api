namespace Web.API;

public class RequestErrorItem
{
    public required string ErrorMessage { get; init; } = default!;
    public required string Key { get; init; } = default!;
}