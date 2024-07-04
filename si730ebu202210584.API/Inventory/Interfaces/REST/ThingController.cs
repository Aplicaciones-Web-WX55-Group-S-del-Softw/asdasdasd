using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using si730ebu202210584.API.Inventory.Domain.Services;
using si730ebu202210584.API.Inventory.Interfaces.REST.Resources;
using si730ebu202210584.API.Inventory.Interfaces.REST.Transform;

namespace si730ebu202210584.API.Inventory.Interfaces.REST;
[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ThingController(IThingCommandService thingCommandService): ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ThingResource>> CreateThing([FromBody] CreateThingResource resource)
    {
        var createThingCommand = CreateThingCommandFromResourceAssembler.ToCommandFromResource(resource);

        var thing = await thingCommandService.Handle(createThingCommand);

        var thingResource = ThingResourceFromEntityAssembler.ToResourceFromEntity(thing);

        return CreatedAtAction(nameof(CreateThing), new { id = thingResource.id }, thingResource);
    }
    
}