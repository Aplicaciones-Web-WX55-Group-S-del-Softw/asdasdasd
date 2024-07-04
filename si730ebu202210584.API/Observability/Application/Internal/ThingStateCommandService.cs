using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;
using si730ebu202210584.API.Observability.Domain.Model;
using si730ebu202210584.API.Observability.Domain.Model.Commands;
using si730ebu202210584.API.Observability.Domain.Repositories;
using si730ebu202210584.API.Observability.Domain.Services;

namespace si730ebu202210584.API.Observability.Application.Internal;

public class ThingStateCommandService : IThingStateCommandService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IThingStateRepository _thingStateRepository;

    public ThingStateCommandService(IUnitOfWork unitOfWork, IThingStateRepository thingStateRepository)
    {
        _unitOfWork = unitOfWork;
        _thingStateRepository = thingStateRepository;
    }

    public async Task<ThingState> Handle(CreateThingStateCommand command)
    {
        ThingState thingState = new ThingState(command);
        await _thingStateRepository.AddAsync(thingState);
        await _unitOfWork.CompleteAsync();
        return thingState;
        
        
    }
}