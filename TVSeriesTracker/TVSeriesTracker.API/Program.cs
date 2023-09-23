var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "TVSeriesTrackerAPI",
        Version = "v1",
        Description = "Simple REST API for mobile and web application",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Micha³ Z",
            Email = "michalzuch26@gmail.com"
        },

        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "Used License",
            Url = new Uri("https://example.com/license")
        }
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "TVSeriesTracker.API.xml");
    c.IncludeXmlComments(filePath);
    }
);
builder.Services.AddHealthChecks();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TVSeriesTrackerAPI"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHealthChecks("/hc");

app.MapControllers();

app.Run();
