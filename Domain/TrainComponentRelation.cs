namespace Domain;

public class TrainComponentRelation : Entity
{
    public int ContextId { get; set; }
    public int? Quantity { get; set; }
    public int TrainComponentId { get; set; }
    public int? TrainComponentParentId { get; set; }
}