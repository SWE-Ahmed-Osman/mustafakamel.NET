using Fathy.Common.Auth;
using Fathy.Common.Storage;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Portfolio.Dashboard.Delete.Repositories;
using Portfolio.Dashboard.Get.Repositories;
using Portfolio.Dashboard.Post.Repositories;
using Portfolio.Dashboard.Update.Repositories;
using Portfolio.Database;
using Portfolio.Repositories;
using Portfolio.Utilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<IPortfolioContext, PortfolioContext>(optionsAction =>
        optionsAction.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings:SqlServer")))
    .AddIdentity<IdentityUser, IdentityRole>(identityOptions =>
    {
        identityOptions.SignIn.RequireConfirmedAccount =
            builder.Configuration.GetValue<bool>("Database:IdentityOptions:SignIn:RequireConfirmedAccount");
        identityOptions.User.RequireUniqueEmail =
            builder.Configuration.GetValue<bool>("Database:IdentityOptions:User:RequireUniqueEmail");
    }).AddEntityFrameworkStores<PortfolioContext>().AddDefaultTokenProviders();

builder.Services.AddAuthService(new OpenApiInfo
{
    Title = builder.Configuration.GetValue<string>("Swagger:OpenApiInfo:Title"),
    Version = builder.Configuration.GetValue<string>("Swagger:OpenApiInfo:Version"),
    Description = builder.Configuration.GetValue<string>("Swagger:OpenApiInfo:Description")
});

builder.Services.AddStorageService(builder.Configuration.GetValue<string>("ConnectionStrings:AzureStorage"),
    builder.Configuration.GetValue<string>("BlobContainerName"));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddTransient<IPortfolioRepository, PortfolioRepository>();

builder.Services.AddTransient<IGetDashboardRepository, GetDashboardRepository>();
builder.Services.AddTransient<IPostDashboardRepository, PostDashboardRepository>();
builder.Services.AddTransient<IDeleteDashboardRepository, DeleteDashboardRepository>();
builder.Services.AddTransient<IUpdateDashboardRepository, UpdateDashboardRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.CreateDbIfNotExists();

app.Run();
