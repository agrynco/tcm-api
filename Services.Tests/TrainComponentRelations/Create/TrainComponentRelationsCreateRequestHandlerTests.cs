using System.Threading.Tasks;
using Serilog;
using Services.TrainComponentRelations.Create;
using DAL.Abstract.TrainComponentRelations;
using Domain;
using Xunit;

namespace Services.Tests.TrainComponentRelations.Create;

public class TrainComponentRelationsCreateRequestHandlerTests
{
    [Fact]
    public async Task Throws_when_component_references_itself()
    {
        var logger = new LoggerConfiguration().CreateLogger();
        var repo = new StubRepo();
        var handler = new TrainComponentRelationsCreateRequestHandler(logger, repo);
        var request = new TrainComponentRelationsCreateRequest
        {
            TrainComponentId = 1,
            TrainComponentParentId = 1,
            TrainComponentContextId = 2
        };

        await Assert.ThrowsAsync<TrainComponentSelfReferenceException>(() => handler.OnHandle(request));
    }

    private class StubRepo : ITrainComponentRelationsRepository
    {
        public Task<int> Create(TrainComponentRelation entity) => Task.FromResult(0);
        public Task<TrainComponentRelationItem[]> Get(int trainComponentContextId, int? parentComponentId) => Task.FromResult(System.Array.Empty<TrainComponentRelationItem>());
    }
}
