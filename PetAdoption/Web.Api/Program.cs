using Microsoft.EntityFrameworkCore;
using WebData.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PetDbContext>(opts=> {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:DevelopmentConnection"]);
});
builder.Services.AddScoped<IPetRepository, EFPetRepository>();
builder.Services.AddScoped<IAccountRepository, EFAccountRepository>();
builder.Services.AddScoped<IMessageRepository, EFMessageRepository>();
builder.Services.AddScoped<IPetWaitingListRepository, EFPetWaitingListRepository>();

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<PetDbContext>();
InitialDB.SeedDatabase(context);

app.MapGet("/", () => "Hello World!");

app.Run();
