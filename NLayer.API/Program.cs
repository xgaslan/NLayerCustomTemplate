using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWork;
using NLayer.Repository.Repositories;
using NLayer.Service.Mapping;
using NLayer.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUnitOfWork, IUnitOfWork>();
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddAutoMapper(typeof(MapProfile));

//TODO DbContext eklenince acilacak
//builder.Services.AddDbContext<BaseContext>(
//    db => db.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"))
//);

builder.Services.AddCors(c =>
    c.AddPolicy("AllowCustomPolicies", 
        builder => 
            builder.AllowAnyOrigin().
                AllowAnyMethod()
                .AllowAnyHeader()
            ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowCustomPolicies");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
