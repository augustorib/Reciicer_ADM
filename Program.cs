using Microsoft.EntityFrameworkCore;
using Reciicer.Data;
using Reciicer.Repository;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Reciicer.Service.Email;
using Reciicer.Service.Premiacao;
using Reciicer.Service.Material;
using Reciicer.Service.TipoMaterial;
using Reciicer.Service.Coleta;
using Reciicer.Service.Material_Coleta;
using Reciicer.Service.PontoColeta;
using Reciicer.Service.Endereco;


var builder = WebApplication.CreateBuilder(args);

//Repository Interface
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IPremiacaoRepository, PremiacaoRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<ITipoMaterialRepository, TipoMaterialRepository>();
builder.Services.AddScoped<IColetaRepository, ColetaRepository>();
builder.Services.AddScoped<IMaterial_ColetaRepository, Material_ColetaRepository>();
builder.Services.AddScoped<IPontoColetaRepository, PontoColetaRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();

//Services
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<PremiacaoService>();
builder.Services.AddScoped<MaterialService>();
builder.Services.AddScoped<TipoMaterialService>();
builder.Services.AddScoped<ColetaService>();
builder.Services.AddScoped<Material_ColetaService>();
builder.Services.AddScoped<PontoColetaService>();
builder.Services.AddScoped<EnderecoService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Dbcontext
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


//Identity Login
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

//builder.Services.Configure<IdentityOptions>(options =>
//{
//    // Password settings.
//    options.Password.RequireDigit = true;
//    options.Password.RequireLowercase = true;
//    options.Password.RequireNonAlphanumeric = true;
//    options.Password.RequireUppercase = true;
//    options.Password.RequiredLength = 6;
//    options.Password.RequiredUniqueChars = 1;

//    // User settings.
//    options.User.AllowedUserNameCharacters =
//    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
//    options.User.RequireUniqueEmail = false;
//});

//IDENTITY CONFIG
//teste politicas de senha
builder.Services.Configure<IdentityOptions>(options =>
{
   // Password settings.
   options.Password.RequireDigit = false;
   options.Password.RequireLowercase = false;
   options.Password.RequireNonAlphanumeric = false;
   options.Password.RequireUppercase = false;
   options.Password.RequiredLength = 1;
   options.Password.RequiredUniqueChars = 1;
   
});

builder.Services.AddLogging( config => config.AddConsole());
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(2);
        options.SlidingExpiration = true;

  
    });

//    // User settings.
//    options.User.AllowedUserNameCharacters =
//    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
//    options.User.RequireUniqueEmail = false;
//});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
