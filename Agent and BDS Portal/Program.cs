using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using MudBlazor.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(items => items.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<Account_Services>();
//builder.Services.AddScoped<ProductionReport_Services>();
//builder.Services.AddScoped<SubmittedReport_Services>();


builder.Services.AddScoped<CGL_CreditDebit_Services>();
builder.Services.AddScoped<CGL_Policy_Holder_Services>();
builder.Services.AddScoped<CGL_Particulars_Services>();
builder.Services.AddScoped<CGL_Insured_Services>();
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
builder.Services.AddScoped<CGL_Receipted_Services>();
builder.Services.AddScoped<CGL_Coverage_Services>();
>>>>>>> Stashed changes
=======
builder.Services.AddScoped<CGL_Coverage_Services>();
builder.Services.AddScoped<CGL_Receipted_Services>();
builder.Services.AddScoped<CGL_Health_Question_Services>();
builder.Services.AddScoped<CGL_Substandard_Rating_Services>();
builder.Services.AddScoped<CGL_Health_Answer_Services>();
builder.Services.AddScoped<CGL_COC_Services>();
builder.Services.AddScoped<CGL_Beneficiary_Services>();
builder.Services.AddScoped<CGL_Insured_Status_Services>();
builder.Services.AddScoped<ImageService>();
>>>>>>> testcode

builder.Services.AddMudServices();


builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();
    
   
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
