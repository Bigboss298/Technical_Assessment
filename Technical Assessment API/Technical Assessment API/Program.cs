using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Technical_Assessment_API.Implementation.Repository;
using Technical_Assessment_API.Implementation.Services;
using Technical_Assessment_API.Interface.Repository;
using Technical_Assessment_API.Interface.Services;
using Technical_Assessment_API.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

var configuration = builder.Configuration;
var paystackApiKey = configuration["OMDBApi:ApiKey"];
builder.Services.AddScoped<IMovieSearchService, MovieSearchService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


builder.Services.AddScoped<ISearchQueryRepository, SearchQueryRepository>();
builder.Services.AddScoped<ISearchQueryServices, SearchQueryService>();

builder.Services.AddCors(c => c
                .AddPolicy("Tech_Assess Api", builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tech_Assess Api", Version = "v1" });
});
builder.Services.AddDbContext<ApplicationContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("MyConnection")));

var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tech_Assess Api v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("Tech_Assess Api");

app.Run();
