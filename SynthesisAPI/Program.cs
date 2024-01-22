using Microsoft.EntityFrameworkCore;
using Npgsql;
using SynthesisAPI;
using SynthesisAPI.Models;
using SynthesisAPI.Services;


var builder = WebApplication.CreateBuilder(args);


// Database connection
var constrBuilder = new NpgsqlConnectionStringBuilder(
    builder.Configuration.GetConnectionString("DefaultConnection")
){
    Username = builder.Configuration["DB_USERID"],
    Password = builder.Configuration["DB_PASSWORD"]
};

builder.Services.AddDbContext<MonsterDbContext>(
    options => options.UseNpgsql(
        constrBuilder.ConnectionString
    )
);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile)); // Enable the custom mapping profile 
builder.Services.AddScoped<ICombinationService, CombinationService>();

builder.Services.AddCors(options => {
    options.AddPolicy("ReactPolicy",
        builder => {
            builder.WithOrigins("http://localhost:3000") //I should update the link to connect to my react app.
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Required in order to share data between the API and the React project.
app.UseCors("ReactPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
