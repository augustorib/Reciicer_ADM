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
using Reciicer.Service.ClientePremiacao;
using Reciicer.Service.UsuarioIdentity;
using Reciicer.Models.Entities;
using Reciicer.Service.Cooperativa;
using Reciicer.Service.Recolhimento;
using Reciicer.Service.Estoque;
using Reciicer.Service.EstoqueMaterial;
using Reciicer.Service.RecolhimentoEstoqueMaterial;
using Reciicer.Service.Relatorio;
using Reciicer.Service.Error;
using Reciicer.Service.Audit;



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
builder.Services.AddScoped<IClientePremiacaoRepository, ClientePremiacaoRepository>();
builder.Services.AddScoped<ICooperativaRepository, CooperativaRepository>();
builder.Services.AddScoped<IRecolhimentoRepository, RecolhimentoRepository>();
builder.Services.AddScoped<IRecolhimentoEstoqueMaterialRepository, RecolhimentoEstoqueMaterialRepository>();
builder.Services.AddScoped<IEstoqueRepository, EstoqueRepository>();
builder.Services.AddScoped<IEstoqueMaterialRepository, EstoqueMaterialRepository>();

//Services
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<PremiacaoService>();
builder.Services.AddScoped<MaterialService>();
builder.Services.AddScoped<TipoMaterialService>();
builder.Services.AddScoped<ColetaService>();
builder.Services.AddScoped<Material_ColetaService>();
builder.Services.AddScoped<PontoColetaService>();
builder.Services.AddScoped<EnderecoService>();
builder.Services.AddScoped<ClientePremiacaoService>();
builder.Services.AddScoped<UsuarioIdentityService>();
builder.Services.AddScoped<CooperativaService>();
builder.Services.AddScoped<RecolhimentoService>();
builder.Services.AddScoped<EstoqueService>();
builder.Services.AddScoped<EstoqueMaterialService>();
builder.Services.AddScoped<RecolhimentoEstoqueMaterialService>();
builder.Services.AddScoped<RelatorioService>();
builder.Services.AddScoped<ErrorHandlingService>();
builder.Services.AddScoped<AuditService>();
builder.Services.AddScoped<IEmailService, EmailService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();

// Add Dbcontext
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

        
//Identity Login
builder.Services.AddIdentity<UsuarioIdentity, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();


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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/Error");
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
