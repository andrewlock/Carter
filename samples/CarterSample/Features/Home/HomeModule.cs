namespace CarterSample.Features.Home
{
    using Carter;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Routing;

    public class HomeModule : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/", (HttpResponse res) =>
            {
                res.StatusCode = 409;
                return Results.Text("There's no place like 127.0.0.1");
            });
        }
    }
}
