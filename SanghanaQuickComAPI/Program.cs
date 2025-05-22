using Entity.DBLayer;
using Microsoft.EntityFrameworkCore;
using QuickComm.BusinessLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EcommerceContext>(
    options => options.UseSqlServer(
       builder.Configuration.GetConnectionString("SanghanaConnectionString")
       )

    );
builder.Services.AddScoped<IInterfaceentity, Dbclass>();
builder.Services.AddScoped<Class1>();

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

app.Run();
