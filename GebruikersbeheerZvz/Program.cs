using FluentValidation;
using GebruikersbeheerZvz.Contexts;
using GebruikersbeheerZvz.Handlers.Validator;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add fluentvalidation
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

// Add mediatr
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorPipelineBehavior<,>));

// Add services to the container.
builder.Services.AddRazorPages();

// voeg dbcontext toe met connectionstring postgresql
builder.Services.AddDbContext<GebruikersbeheerZvzContext>(options => options
    .UseNpgsql("Host=localhost:5432;Database=GebruikersbeheerZvz;Username=postgres;Password=postgres"
        //,x => x.MigrationsAssembly("Migrations")
        ));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
