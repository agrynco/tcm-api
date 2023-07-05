using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers.TrainComponentRelations;

public class TrainComponentRelationPostModel
{
    public int TrainComponentId { get; set; }
    public int? TrainComponentParentId { get; set; }
}

[Route("train-component-relations/{contextId:int}")]
public class TrainComponentRelationsController : ApiControllerBase
{
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

        throw new NotImplementedException();
    }
}