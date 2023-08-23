using Microsoft.EntityFrameworkCore;
using WebApp1.data;
using WebApp1.Interface;
using WebApp1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbcontext>(
    option => option.UseSqlServer(
    @"Data Source=DESKTOP-2J37TFF\SQLEXPRESS; Initial Catalog=Learning;User Id=sa; password=sa123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true",
    provideroptions => { provideroptions.EnableRetryOnFailure(); }
));
builder.Services.AddScoped<IShape, Circle>();
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

