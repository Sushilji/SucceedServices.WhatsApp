using Microsoft.EntityFrameworkCore;
using SucceedServices.WhatsApp.Data;
using SucceedServices.WhatsApp.Services;
using SucceedServices.WhatsApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IWhatsAppService,WhatsAppService>();
builder.Services.AddScoped<IMessageLogRepository,MessageLogRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString(
                "DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=WhatsApp}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
