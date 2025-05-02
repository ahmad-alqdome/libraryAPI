using FluentValidation.AspNetCore;
using libraryAPI;
using libraryAPI.Data.Repositories;
using libraryAPI.Entities.Dtos;
using libraryAPI.Validation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/****************************************************************************/


var sqlConnect = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(sqlConnect));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<ICategoyRepository, CategoyRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
    {
        policy.AllowAnyOrigin() // Replace with allowed origins
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// validation
builder.Services.AddControllers().AddFluentValidation(config => { 
    config.RegisterValidatorsFromAssemblyContaining<AuthorRequestValidator>(); }
);



/*****************************************************************************/
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
