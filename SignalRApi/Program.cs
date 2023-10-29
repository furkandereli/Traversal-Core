using Microsoft.EntityFrameworkCore;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using SignalRApi.Model;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<VisitorService>();
builder.Services.AddSignalR();

builder.Services.AddCors(options=>options.AddPolicy("CorsPolicy",
    builder => 
    {
        builder.AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials();
    }));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
// Add services to the container.
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.UseRouting();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();
app.MapHub<VisitorHub>("/VisitorHub");

app.Run();