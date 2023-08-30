var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSignalR();
var app = builder.Build();

//app.UseHttpsRedirection();
//app.UseDefaultFiles();
//app.UseStaticFiles();

app.UseStaticFiles();
//app.UseRouting();
//app.MapDefaultControllerRoute();

app.MapRazorPages();
app.MapHub<SimpleChat.Hubs.SimpleChat>("/simplechat");
app.MapGet("/hello", () => "Hello World!");
app.Run();
