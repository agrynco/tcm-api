namespace Services.Core.Exceptions;

public class MessageConsumerException : ServiceException
{
    public MessageConsumerException(object consumerMessage, Exception innerException)
        : base($"Error handling message: {consumerMessage}", innerException)
    {
        ConsumerMessage = consumerMessage;
    }
    
    public object ConsumerMessage { get; }
}