using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddLocalization();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU3NzIzMUAzMjMyMmUzMDJlMzBnaHJyUlQ1b3FJWDdkQWxpQ0E3TEsvaldRMjJlam0rRFR5czRlekw2a1dVPQ==");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
