using Microsoft.EntityFrameworkCore;
using SaborDoSert�o.EndPoints.Admin.Mesas;
using SaborDoSert�o.EndPoints.Admin.Produtos;
using SaborDoSert�o.EndPoints.Work.Mesas;
using SaborDoSert�o.InfraNet;
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
app.MapMethods(MesasPost.Template, MesasPost.Methods, MesasPost.Handler);
app.MapMethods(MesasDelete.Template, MesasDelete.Methods, MesasDelete.Handler);
app.MapMethods(ProdutoPost.Template, ProdutoPost.Methods, ProdutoPost.Handler);
app.MapMethods(ProdutoDelete.Template, ProdutoDelete.Methods, ProdutoDelete.Handler);
app.MapMethods(ProdutoPut.Template, ProdutoPut.Methods, ProdutoPut.Handler);
app.MapMethods(ProdutosGet.Template, ProdutosGet.Methods, ProdutosGet.Handler);
app.MapMethods(SaborDoSert�o.EndPoints.Admin.Mesas.MesasGetAll.Template, SaborDoSert�o.EndPoints.Admin.Mesas.MesasGetAll.Methods, SaborDoSert�o.EndPoints.Admin.Mesas.MesasGetAll.Handler);

//work
app.MapMethods(SaborDoSert�o.EndPoints.Work.Mesas.MesasGetAll.Template, SaborDoSert�o.EndPoints.Work.Mesas.MesasGetAll.Methods, SaborDoSert�o.EndPoints.Work.Mesas.MesasGetAll.Handler);
app.MapMethods(MesaComandaPost.Template, MesaComandaPost.Methods, MesaComandaPost.Handler);
app.MapMethods(MesaComandaGet.Template, MesaComandaGet.Methods, MesaComandaGet.Handler);


app.Run();
