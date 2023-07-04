using Microsoft.AspNetCore.Mvc;
using Services.TrainComponentContexts.Create;
using SlimMessageBus;

namespace Web.API.Controllers.TrainComponentContexts;

[Route("train-contexts")]
public class TrainComponentContextsController : ApiControllerBase
{
    private readonly IMessageBus _messageBus;

    public TrainComponentContextsController(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Post([FromBody] TrainComponentContextPostModel postModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.ToRequestError());
        }

        return Ok(await _messageBus.Send(new TrainComponentContextsCreateRequest
        {
            Name = postModel.Name
        }));
    }
}