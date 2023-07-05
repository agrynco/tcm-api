using Microsoft.AspNetCore.Mvc;
using Services.TrainComponentRelations;
using SlimMessageBus;

namespace Web.API.Controllers.TrainComponentRelations;

[Route("train-component-relations/{contextId:int}")]
public class TrainComponentRelationsController : ApiControllerBase
{
    private readonly IMessageBus _messageBus;

    public TrainComponentRelationsController(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Post(int contextId, [FromBody] TrainComponentRelationPostModel postModel)
    {
        if (postModel.TrainComponentId == postModel.TrainComponentParentId)
        {
            ModelState.AddModelError(nameof(postModel.TrainComponentId), "Train component cannot be its own parent");
        }
        
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.ToRequestError());
        }

        return Ok(await _messageBus.Send(new TrainComponentRelationsCreateRequest
        {
            TrainComponentContextId = contextId,
            TrainComponentId = postModel.TrainComponentId,
            TrainComponentParentId = postModel.TrainComponentParentId
        }));
    }
}