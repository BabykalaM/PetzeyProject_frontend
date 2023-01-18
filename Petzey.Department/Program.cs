using Microsoft.AspNet.OData.Extensions;
using NLog;
using Petzey.Dept.Data;
using Petzey.Dept.Domain.Automapper;
using Petzey.Dept.Domain.Repository;


var builder = WebApplication.CreateBuilder(args);
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "./NLog.config"));

// Add services to the container.
builder.Services.AddSingleton<IDeptRepository, DeptRepository>();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddAutoMapper(typeof(AutomapperDept).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOData();
//CORS
builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseCors(policyName: "CorsPolicy");

//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.EnableDependencyInjection();
    endpoints.Select().OrderBy().Filter().MaxTop(100).SkipToken();
    endpoints.MapControllers();
});

app.Run();
