namespace Web.API.Controllers.TrainComponentRelations;

public class TrainComponentRelationPostModel
{
    public int TrainComponentId { get; set; }
    public int? TrainComponentParentId { get; set; }
}