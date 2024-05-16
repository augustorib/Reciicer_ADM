using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Repository;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;

var builder = WebApplication.CreateBuilder(args);

//Repository Interface
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<INivelRepository, NivelRepository>();
builder.Services.AddScoped<IReciclagemRepository, ReciclagemRepository>();

//Services
builder.Services.AddScoped<ClienteService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Dbcontext
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);  

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
