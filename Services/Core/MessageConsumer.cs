using Serilog;
using Services.Core.Exceptions;
using SlimMessageBus;

namespace Services.Core;

public abstract class MessageConsumer<TMessage> : IConsumer<TMessage>
{
    protected MessageConsumer(ILogger logger)
    {
        Logger = logger;
    }

    private ILogger Logger { get; }

    public async Task OnHandle(TMessage message)
    {
        Logger.Information("{Consumer}: Start => {@Message}", GetType(), message);

        try
        {
            await DoOnHandle(message);
        }
        catch (Exception e)
        {
            Logger.Error(e, "{Handler}: Error => {@Error}, {@Message}", GetType(), e.Message, message);
            throw new MessageConsumerException(message!, e);
        }
        finally
        {
            Logger.Information("{Consumer}: End", GetType());   
        }
    }

    protected abstract Task DoOnHandle(TMessage message);
}