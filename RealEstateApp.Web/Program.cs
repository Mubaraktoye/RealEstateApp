using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Migrations;
using RealEstateApp.Services.DIExtention;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

ConfigurationManager configuration = builder.Configuration;
builder.Services.AddDbContext<RealEstateAppContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbServerConnection"))).AddUnitOfWork<RealEstateAppContext>();

//========= Initilizing auto mapper =============
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

//========= Injected Services =============
builder.Services.AddInjectedServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
