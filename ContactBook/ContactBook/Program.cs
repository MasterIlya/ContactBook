using ContactBook.Configuration;
using ContactBook;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddMvc();
services.AddControllersWithViews();
services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var sBuilder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();
var appSettings = new ApplicationSettings();
appSettings.Init(sBuilder);
new DependencyInjection(appSettings, services).Init();

var app = builder.Build();


app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Contacts}/{action=GetContacts}/{id?}");
});

app.Run();
