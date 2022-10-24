using Portfolio.Configurations;

var builder = WebApplication.CreateBuilder(args);

ConfigProvider.Configuration = builder.Configuration;

builder.Services.AddApplication();

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
