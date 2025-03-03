using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

public  static class ModelStateExtensions
{
    public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
    {
        return dictionary
            .SelectMany(m => m.Value!.Errors)
            .Select(m => m.ErrorMessage)
            .ToList();
    }
}