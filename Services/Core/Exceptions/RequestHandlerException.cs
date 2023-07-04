namespace Services.Core.Exceptions;

public class RequestHandlerException : ServiceException
{
    public RequestHandlerException(object request, Exception innerException)
        : base($"Error handling request: {request}", innerException)
    {
        Request = request;
    }
    
    public object Request { get; }
}