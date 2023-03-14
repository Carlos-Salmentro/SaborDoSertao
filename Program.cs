using Microsoft.EntityFrameworkCore;
using SaborDoSertão.EndPoints.Admin.Comandas;
using SaborDoSertão.EndPoints.Admin.Mesas;
using SaborDoSertão.EndPoints.Admin.Produtos;
using SaborDoSertão.EndPoints.Caixa.Comandas;
using SaborDoSertão.EndPoints.Caixa.Mesas;
using SaborDoSertão.EndPoints.Work.Comandas;
using SaborDoSertão.EndPoints.Work.Mesas;
using SaborDoSertão.InfraNet;
//using SaborDoSertão.Servicos.SeedService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDBContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("SaborDoSertaoString");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
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

//caixa
app.MapMethods(CaixaMesasGetAll.Template, CaixaMesasGetAll.Methods, CaixaMesasGetAll.Handler);
app.MapMethods(CaixaMesaComandaGet.Template, CaixaMesaComandaGet.Methods, CaixaMesaComandaGet.Handler);
app.MapMethods(CaixaComandasGetAll.Template, CaixaComandasGetAll.Methods, CaixaComandasGetAll.Hanlder);
app.MapMethods(CaixaComandaGet.Template, CaixaComandaGet.Methods, CaixaComandaGet.Handler);


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

app.Run();


