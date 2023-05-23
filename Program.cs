using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SaborDoSert�o.EndPoints.Admin.Comandas;
using SaborDoSert�o.EndPoints.Admin.Mesas;
using SaborDoSert�o.EndPoints.Admin.Produtos;
using SaborDoSert�o.EndPoints.Admin.Usuarios;
using SaborDoSert�o.EndPoints.Caixa.Comandas;
using SaborDoSert�o.EndPoints.Caixa.Mesas;
using SaborDoSert�o.EndPoints.Work.Comandas;
using SaborDoSert�o.EndPoints.Work.Mesas;
using SaborDoSert�o.EndPoints.LoginToken;
using SaborDoSert�o.InfraNet;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add BbContext como servico
builder.Services.AddDbContext<AppDBContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("SaborDoSertaoString");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

//Add Identity como servico do ASPNet
builder.Services.AddIdentity<IdentityUser, IdentityRole>(option =>
{
    option.Password.RequiredLength = 1;
    option.Password.RequireDigit = false;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireUppercase = false;

})
    .AddEntityFrameworkStores<AppDBContext>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateActor = true,

        RequireAudience = true,
        RequireExpirationTime = true,
        RequireSignedTokens = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:MySecret"]))
    };  
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



//admin
app.MapMethods(AdminMesasGetAll.Template, AdminMesasGetAll.Methods, AdminMesasGetAll.Handler);
app.MapMethods(AdminMesasPost.Template, AdminMesasPost.Methods, AdminMesasPost.Handler);
app.MapMethods(AdminMesasDelete.Template, AdminMesasDelete.Methods, AdminMesasDelete.Handler);
app.MapMethods(AdminProdutoPost.Template, AdminProdutoPost.Methods, AdminProdutoPost.Handler);
app.MapMethods(AdminProdutoDelete.Template, AdminProdutoDelete.Methods, AdminProdutoDelete.Handler);
app.MapMethods(AdminProdutoPut.Template, AdminProdutoPut.Methods, AdminProdutoPut.Handler);
app.MapMethods(AdminProdutosGetAll.Template, AdminProdutosGetAll.Methods, AdminProdutosGetAll.Handler);
app.MapMethods(AdminComandasGet.Template, AdminComandasGet.Methods, AdminComandasGet.Handler);
app.MapMethods(AdminUsuarioGet.Template, AdminUsuarioGet.Methods, AdminUsuarioGet.Handler);
app.MapMethods(AdminUsuariosGetAll.Template, AdminUsuariosGetAll.Methods, AdminUsuariosGetAll.Handler);
app.MapMethods(AdminUsuarioPost.Template, AdminUsuarioPost.Methods, AdminUsuarioPost.Handler);

//caixa
app.MapMethods(CaixaMesasGetAll.Template, CaixaMesasGetAll.Methods, CaixaMesasGetAll.Handler);
app.MapMethods(CaixaMesaComandasGet.Template, CaixaMesaComandasGet.Methods, CaixaMesaComandasGet.Handler);
app.MapMethods(CaixaComandasGetAll.Template, CaixaComandasGetAll.Methods, CaixaComandasGetAll.Hanlder);
app.MapMethods(CaixaComandaGet.Template, CaixaComandaGet.Methods, CaixaComandaGet.Handler);
app.MapMethods(CaixaComandaPagamentoPut.Template, CaixaComandaPagamentoPut.Methods, CaixaComandaPagamentoPut.Handler);


//work mesas
app.MapMethods(MesasGetAll.Template, MesasGetAll.Methods, MesasGetAll.Handler);
app.MapMethods(MesaComandaPost.Template, MesaComandaPost.Methods, MesaComandaPost.Handler);
app.MapMethods(MesaComandaGet.Template, MesaComandaGet.Methods, MesaComandaGet.Handler);
app.MapMethods(MesasComandaPedidoPost.Template, MesasComandaPedidoPost.Methods, MesasComandaPedidoPost.Handler);

//work comandas
app.MapMethods(ComandasGetAll.Template, ComandasGetAll.Methods, ComandasGetAll.Handler);
app.MapMethods(ComandaPost.Template, ComandaPost.Methods, ComandaPost.Handler);
app.MapMethods(ComandaPutPedido.Template, ComandaPutPedido.Methods, ComandaPutPedido.Handler);
app.MapMethods(ComandaGet.Template, ComandaGet.Methods, ComandaGet.Handler);

//login
app.MapMethods(LoginTokenPost.Template, LoginTokenPost.Methods, LoginTokenPost.Handler);

app.Run();


