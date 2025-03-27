using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorChat.Hubs; // Dodaj przestrzeń nazw dla ChatHub

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Dodaj SignalR do aplikacji, aby obsługiwać czat w czasie rzeczywistym
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

// Rejestrujemy SignalR Hub
app.MapBlazorHub();
app.MapHub<ChatHub>("/chathub"); // Dodajemy SignalR Hub pod ścieżkę /chathub
app.MapFallbackToPage("/_Host");

app.Run();
