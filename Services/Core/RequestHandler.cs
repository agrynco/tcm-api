﻿using Serilog;
using Services.Core.Exceptions;
using SlimMessageBus;

namespace Services.Core;

public abstract class RequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    protected RequestHandler(ILogger logger)
    {
        Logger = logger;
    }

    private ILogger Logger { get; }

    public Task<TResponse> OnHandle(TRequest request)
    {
        Logger.Information("{Handler}: Start => {@Request}", GetType(), request);

        try
        {
            var result = DoOnHandle(request);
            return result;
        }
        catch (Exception e)
        {
            Logger.Error(e, "{Handler}: Error => {@Error}, {@Request}", GetType(), e.Message, request);
            throw new RequestHandlerException(request, e);
        }
        finally
        {
            Logger.Information("{Handler}: End", GetType());
        }
    }

    protected abstract Task<TResponse> DoOnHandle(TRequest request);
}