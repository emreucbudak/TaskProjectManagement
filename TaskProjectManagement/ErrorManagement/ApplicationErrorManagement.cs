using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using TaskProjectManagement.Domain.ErrorModels;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;

namespace TaskProjectManagement.ErrorManagement
{
    public static class ApplicationErrorManagement
    {
        public  static void AppErr(this WebApplication app,ILogger logger)
        {
            app.UseExceptionHandler(apps => {
                apps.Run(async context =>
                {
                    var errorMessage =  context.Features.GetRequiredFeature<IExceptionHandlerFeature>();
                    Errors err = new Errors();
                    err.ErrorMessage = errorMessage.Error.Message;
                    err.ErrorStatusCode = errorMessage.Error switch
                    {
                        ItemNotFoundException => StatusCodes.Status404NotFound,
                        _ => StatusCodes.Status400BadRequest  
                    };
                    logger.LogError($"Hata : {err.ErrorMessage}, Hata Kodu {err.ErrorStatusCode}");
                    var result = System.Text.Json.JsonSerializer.Serialize(new
                    {
                        error = err.ErrorMessage
                    });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(result);


                }
                    );
            });
            { }
        }
    }
}
