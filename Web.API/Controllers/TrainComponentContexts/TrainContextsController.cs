using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers.TrainComponentContexts;

[Route("train-contexts")]
public class TrainContextsController : ApiControllerBase
{
    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Post([FromBody] TrainContextPostModel postModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.ToRequestError());
        }

        throw new NotImplementedException();
    }
}