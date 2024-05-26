using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Repository;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;
using Reciicer.Service.Reciclagem;
using Reciicer.Service.Material;
using Reciicer.Service.TipoMaterial;


var builder = WebApplication.CreateBuilder(args);

//Repository Interface
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<INivelRepository, NivelRepository>();
builder.Services.AddScoped<IReciclagemRepository, ReciclagemRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<ITipoMaterialRepository, TipoMaterialRepository>();
builder.Services.AddScoped<IMaterial_ReciclagemRepository, Material_ReciclagemRepository>();
builder.Services.AddScoped<IPontuacaoMaterialRepository, PontuacaoMaterialRepository>();

//Services
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<MaterialService>();
builder.Services.AddScoped<ReciclagemService>();
builder.Services.AddScoped<TipoMaterialService>();

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
