using API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Minimal API
app.MapGet("/products/{id}", async (Guid id, IProductService service) =>
{
    var product = await service.GetByIdAsync(id);

    return product is null
        ? Results.NotFound()
        : Results.Ok(product);
});


app.Run();
