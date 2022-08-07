using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWork;
using NLayer.Repository.Repositories;
using NLayer.Service.Mapping;
using NLayer.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IUnitOfWork, IUnitOfWork>();

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
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("AllowCustomPolicies");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
