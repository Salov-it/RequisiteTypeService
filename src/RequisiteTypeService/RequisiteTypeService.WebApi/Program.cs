using MediatR;
using RequisiteTypeService.Application.CQRS.Command.Create;
using RequisiteTypeService.Application.Interface;
using RequisiteTypeService.Application.Mapping;
using RequisiteTypeService.infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IRequisiteTypeContext).Assembly));

});

//Регистрация DbContexta и mediatr
builder.Services.AddDbContext<RequisiteTypeContext>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IRequisiteTypeContext>(provider => provider.GetService<RequisiteTypeContext>());

//Регистрация команды
builder.Services.AddMediatR(typeof(CreateRequisiteTypeСommand).GetTypeInfo().Assembly);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviseProvider = scope.ServiceProvider;
    try
    {
        var context = serviseProvider.GetRequiredService<RequisiteTypeContext>();
        DbInit.init(context);
    }
    catch (Exception ex)
    {

    }
};

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
