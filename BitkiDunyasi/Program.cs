using BitkiDunyasi.Migrations;
using BitkiDunyasi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<UserDetail, IdentityRole>()
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddEntityFrameworkStores<ApplicationDbContext>();
/*builder.Services.AddDefaultIdentity<UserDetail>(options => options.SignIn.RequireConfirmedAccount = true)
	.AddEntityFrameworkStores<ApplicationDbContext>();*/
builder.Services.ConfigureApplicationCookie(options =>
{
    // options.LoginPath=""
});

builder.Services.AddControllersWithViews();

builder.Services.AddMvc()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
	.AddDataAnnotationsLocalization();

builder.Services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
      {
                    new CultureInfo("en-US"),
                    new CultureInfo("tr")
        };
    options.DefaultRequestCulture = new RequestCulture(culture: "tr", uiCulture: "tr");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    });
    //opt.RequestCultureProviders = new List<IRequestCultureProvider>
    //{
    //    new QueryStringRequestCultureProvider(),
    //    new CookieRequestCultureProvider(),
    //    new AcceptLanguageHeaderRequestCultureProvider()
    //};



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

var locOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(locOptions.Value);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bitki}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
