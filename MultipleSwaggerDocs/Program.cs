using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("example1", new OpenApiInfo { Title = "Example 1", Version = "v1" });
    c.SwaggerDoc("example2", new OpenApiInfo { Title = "Example 2", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x =>
    {
        x.SwaggerEndpoint("example1/swagger.json", "Example 1");
        x.SwaggerEndpoint("example2/swagger.json", "Example 2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
