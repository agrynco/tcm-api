using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Web.API;

public static class ModelStateDictionaryExtensions
{
    public static RequestError ToRequestError(this ModelStateDictionary modelStateDictionary)
    {
        RequestError requestError = new();

        foreach (var keyValuePair in modelStateDictionary)
        {
            foreach (ModelError modelError in keyValuePair.Value.Errors)
            {
                requestError.AddError(new RequestErrorItem
                {
                    Key = keyValuePair.Key,
                    ErrorMessage = modelError.ErrorMessage
                });
            }
        }

        return requestError;
    }
}