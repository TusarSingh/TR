using TR_Group.DAL.DatabaseContext;
using TR_Group.DAL.IdentiyTables;

//using Microsoft.EntityFrameworkCore.Design;

using Microsoft.EntityFrameworkCore;
#region
/*
 * using Microsoft.EntityFrameworkCore;
 * This namespace is use 
 * UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase")));
 */
#endregion

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TRGroup_DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase")));



// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
