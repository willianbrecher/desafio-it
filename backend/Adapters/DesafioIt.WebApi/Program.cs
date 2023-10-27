
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DesafioIt.Application;

var configuration = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
       .AddEnvironmentVariables()
       .Build();

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseConfiguration(configuration);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacModule(configuration)));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "ALLOW_ANY",
        builder =>
        {
            builder.AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true)
                    .AllowCredentials();

        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ALLOW_ANY");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
