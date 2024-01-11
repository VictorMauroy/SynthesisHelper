using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Database connection
var constrBuilder = new NpgsqlConnectionStringBuilder(
    builder.Configuration.GetConnectionString("WebApiDatabase")
);

builder.Services.AddDbContext<MonsterDbContext>(
    options => options.UseNpgsql(
        conStrBuilder.ConnectionString
    )
);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
