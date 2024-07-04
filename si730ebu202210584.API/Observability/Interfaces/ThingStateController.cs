using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using si730ebu202210584.API.Observability.Domain.Services;
using si730ebu202210584.API.Observability.Interfaces.REST.Resource;
using si730ebu202210584.API.Observability.Interfaces.REST.Transform;

namespace si730ebu202210584.API.Observability.Interfaces;
[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ThingStateController(IThingStateCommandService thingStateCommandService): ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ThingStateResource>> CreateThingState([FromBody] CreateThingStateResource resource)
    {
        var createThingStateCommand = CreateThingStateCommandFromResourceAssembler.ToCommandFromResource(resource);

        var thingState = await thingStateCommandService.Handle(createThingStateCommand);

        var thingStateResource = ThingStateResourceFromEntityAssembler.ToResourceFromEntity(thingState);

        return CreatedAtAction(nameof(CreateThingState), new { id = thingStateResource.Id }, thingStateResource);
    }
    
}
