using ComsumeApiProject_DataAccess.Services;
using ComsumeApiProject_DataAccess.Services.IServices;
using ComsumeApiProject_Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IActivityService, ActivityService>();
builder.Services.AddHttpClient<IAccountService, AccountService>();
SD.ActivityAPIBase = builder.Configuration["ServiceUrls:ActivityURL"];

builder.Services.AddScoped<IActivityService, ActivityService>();
builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
